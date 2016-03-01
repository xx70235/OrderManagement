using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OrderManagement.Model;
using OrderManagement.Utilities;

namespace OrderManagement
{
    public partial class OldForm1 : Form
    {

        TPOrderQuery tpQuery;
        XmlUtility xmlUtility;
        TaskQueue taskQueue;
        List<AssistData> assistInNeedList;
        List<CommonOrder> commonInNeedList;
        List<CommonOrder> commonOrderList;
        ThematicOrder thematicOrder;
        DataNameMap dataNameMap;

        public OldForm1()
        {
            InitializeComponent();
            dtp_startDate.CustomFormat = "yyyy-MM-dd";
            dtp_startDate.Format = DateTimePickerFormat.Custom;
            dtp_endDate.CustomFormat = "yyyy-MM-dd";
            dtp_endDate.Format = DateTimePickerFormat.Custom;

            cb_dataCategory.Text = "生态环境";
            tpQuery = new TPOrderQuery();
            xmlUtility = new XmlUtility();
            dataNameMap = new DataNameMap();
            //TaskQueue taskQueue = new TaskQueue();
        }

        private void bt_tpOrderQuery_Click(object sender, EventArgs e)
        {
            string queryParam = tpQuery.GenerateQueryParam(cb_dataCategory.Text, dtp_startDate.Value.ToString("yyyy-MM-dd"), dtp_endDate.Value.ToString("yyyy-MM-dd"));
            string queryResult = tpQuery.ExcuteQuery(queryParam);

            //根据订单编号移除已存在订单
            List<ThematicOrder> thematicOrderList = xmlUtility.retriveThematicOrder(queryResult);
            //DataSet ds = new DataSet();

            //BindingSource bs =  dgv_thematicOrder.DataBindings
            dgv_thematicOrder.DataSource = thematicOrderList;
            //TODO:数据库更新操作
        }

        private void bt_OrderRetrive_Click(object sender, EventArgs e)
        {
            if (dgv_thematicOrder.SelectedRows.Count == 0)
                MessageBox.Show("请先选中欲解析的订单");
            if (dgv_thematicOrder.SelectedRows.Count == 1)
            {
                DataGridViewRow dgvr = dgv_thematicOrder.SelectedRows[0];
                ThematicOrder to = (ThematicOrder)dgvr.DataBoundItem;
                this.thematicOrder = new ThematicOrder();
                this.thematicOrder = to;
                tb_detailedOrderId.Text = to.Orderid;

                cb_detailedProductName.Text = to.ProductName;
                cb_detailedProductType.Text = to.ProductType;
                tb_detailedEnglishName.Text = to.EnglishName;
                dtp_detailedStartDate.Text = to.StartDate;
                dtp_DetailedEndDate.Text = to.EndDate;
                tb_detailedCoverrage.Text = to.CoverScope;
                getDataInNeed(to);


            }
        }

        private void getDataInNeed(ThematicOrder to)
        {
            ProductDataMap pdm = new ProductDataMap();
            List<string> commonInNeed = pdm.GetCommonInNeed(to);
            List<string> assistInNeed = pdm.GetAssistInNeed(to);
            List<CommonOrder> commonListTmp = new List<CommonOrder>();
            List<AssistData> assistListTmp = new List<AssistData>();
            this.commonOrderList = new List<CommonOrder>();
            foreach (string name in commonInNeed)
            {
                CommonOrder co = new CommonOrder();
                co.ProductName = name;
                co.CoverScope = to.CoverScope;
                co.StartDate = to.StartDate;
                co.EndDate = to.EndDate;
                //TODO:查找数据库，找出该数据是否在库
                co.EnglishName = "";
                co.ProductType = "";
                co.IsInDataBase = false;
                commonListTmp.Add(co);
                if (co.IsInDataBase == false)
                {
                    co.Status = OrderStatus.等待生产队列.ToString();
                    commonOrderList.Add(co);
                }
            }
            this.commonInNeedList = commonListTmp;
            dgv_commonProductInNeed.DataSource = commonInNeedList;

            foreach (string name in assistInNeed)
            {
                AssistData ad = new AssistData();
                ad.ProductName = name;
                ad.CoverScope = to.CoverScope;
                ad.StartDate = to.StartDate;
                ad.EndDate = to.EndDate;
                //TODO:查找数据库，找出该数据是否在库
                ad.IsInDataBase = false;
                ad.ProductType = "";
                ad.EnglishName = "";
                assistListTmp.Add(ad);
            }
            dgv_assistDataInNeed.DataSource = assistInNeedList;
        }

        private void bt_addToTaskQueue_Click(object sender, EventArgs e)
        {

            if (this.thematicOrder == null && cb_detailedProductName.Text.Length == 0)
            {
                MessageBox.Show("请确定是否已选中订单，或已输入本订单并已解析订单数据需求");
                return;
            }
            if (cb_detailedProductName.Text.Length == 0)
            {
                MessageBox.Show("请先解析订单或填写本地订单信息");
                return;
            }
            if (this.commonInNeedList.Count == 0)
            {
                MessageBox.Show("请先解析订单或查看本地订单的数据需求");
                return;
            }
            if (this.thematicOrder == null)
            {
                ThematicOrder to = new ThematicOrder();
                //TODO:生成orderID
                to.Orderid = "";
                to.ProductName = cb_detailedProductName.Text;
                to.ProductType = cb_detailedProductType.Text;
                to.EnglishName = tb_detailedEnglishName.Text;
                to.Industry = cb_detailedProductType.Text;
                to.StartDate = dtp_detailedStartDate.Value.ToString("yyyy-MM-dd");
                to.EndDate = dtp_DetailedEndDate.Value.ToString("yyyy-MM-dd");
                to.Status = OrderStatus.等待生产队列;
                to.OrderDate = DateTime.Now.ToString("yyyy-MM-dd");
                to.IsInDataBase = true;
                to.IsLocalOrder = true;
                this.thematicOrder = to;
            }
            else
            {
                this.thematicOrder.Status = OrderStatus.等待生产队列;
            }
          


            //TODO:
            if (this.thematicOrder.IsLocalOrder == false)
            {
                ThematicOrderStateFeedBack tosfb = new ThematicOrderStateFeedBack();
                string result = tosfb.FeedBackThematicOrder(this.thematicOrder, this.thematicOrder.Status.ToString());
                MessageBox.Show(result);
            }
            else
            {
                ThematicOrderRegister tor = new ThematicOrderRegister();
                string result = tor.RegistThematicOrder(this.thematicOrder);
                string orderid = xmlUtility.GetOrderIdForLocalOrder(result);
                MessageBox.Show("注册成功，OrderId为"+orderid);
            }

            TaskQueue taskQueue = new TaskQueue(this.thematicOrder, this.commonInNeedList, this.assistInNeedList);
        }

        private void bt_declineOrder_Click(object sender, EventArgs e)
        {
            if (this.thematicOrder == null)
            {
                MessageBox.Show("请确定是否已选中订单，或已输入本订单并已解析订单数据需求");
                return;
            }

            if (this.thematicOrder.Orderid.Length == 0)
            {
                MessageBox.Show("本地订单不能拒绝生产，如无法生产，请勿将其加入生产队列即可");
                return;
            }

            this.thematicOrder.Status = OrderStatus.已拒绝;
            ThematicOrderStateFeedBack tosfb = new ThematicOrderStateFeedBack();
            string result = tosfb.FeedBackThematicOrder(this.thematicOrder, "拒绝生产");
            MessageBox.Show(result);

        }

        private void bt_feedBackDataWaiting_Click(object sender, EventArgs e)
        {
            if (this.thematicOrder == null)
            {
                MessageBox.Show("请确定是否已选中订单，或已输入本订单并已解析订单数据需求");
                return;
            }

            if (this.thematicOrder.Orderid.Length == 0)
            {
                MessageBox.Show("本地订单无需反馈数据等待状态");
                return;
            }

            this.thematicOrder.Status = OrderStatus.等待数据;
            ThematicOrderStateFeedBack tosfb = new ThematicOrderStateFeedBack();
            string result = tosfb.FeedBackThematicOrder(this.thematicOrder, "数据等待中");
            MessageBox.Show(result);

        }

        private void bt_getDataRequest_Click(object sender, EventArgs e)
        {
            if (cb_detailedProductName.Text.Length == 0)
            {
                MessageBox.Show("请先输入订单信息");
                return;
            }
            if (this.thematicOrder != null && this.tb_detailedOrderId.TextLength != 0)
            {
                return;
            }
           
            ThematicOrder to = new ThematicOrder();
            //TODO:生成orderID
            to.Orderid = "";
            to.ProductName = cb_detailedProductName.Text;
            to.ProductType = cb_detailedProductType.Text;
            to.EnglishName = tb_detailedEnglishName.Text;
            to.Industry = cb_detailedProductType.Text;
            to.StartDate = dtp_detailedStartDate.Value.ToString("yyyy-MM-dd");
            to.EndDate = dtp_DetailedEndDate.Value.ToString("yyyy-MM-dd");
            to.CoverScope = tb_detailedCoverrage.Text;
            to.Status = OrderStatus.等待生产队列;
            to.OrderDate = DateTime.Now.ToString("yyyy-MM-dd");
            to.IsLocalOrder = true;
            this.thematicOrder = to;
            getDataInNeed(to);
        }

        private void cb_detailedProductName_SelectedIndexChanged(object sender, EventArgs e)
        {

            tb_detailedEnglishName.Text = dataNameMap.GetThematicEnglishName(cb_detailedProductName.SelectedItem.ToString());
        }

        private void bt_addLocalThematicOrder_Click(object sender, EventArgs e)
        {
            this.thematicOrder = null;
            tb_detailedOrderId.Clear();
            cb_detailedProductName.Enabled = true;
            cb_detailedProductName.Text = "";
            cb_detailedProductType.Enabled = true;
            cb_detailedProductType.Text = "生态环境";
            tb_detailedEnglishName.ReadOnly = false;
            tb_detailedEnglishName.Clear();
            dtp_DetailedEndDate.Enabled = true;
            dtp_detailedStartDate.Enabled = true;
            tb_detailedCoverrage.ReadOnly = false;
            tb_detailedCoverrage.Clear();
        }

        private void bt_checkAllThematicOrder_Click(object sender, EventArgs e)
        {
            //TODO:查看数据库中所有订单
        }

        private void bt_submitCommonOrder_Click(object sender, EventArgs e)
        {
            if(this.commonOrderList== null)
            {
                MessageBox.Show("请先解析订单或查看本地订单的数据需求");
                return;
            }
            if(this.commonOrderList.Count ==0)
            {
                MessageBox.Show("该订单无共性产品需求");
                return;
            }
            this.dgv_commonOrder.DataSource = this.commonOrderList;
            MessageBox.Show("共性产品需求提交成功，请在“共性产品需求页面查看具体情况”");
        }

        private void bt_reloadStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("更新状态成功");
        }

        private void bt_downloadCommonData_Click(object sender, EventArgs e)
        {
            MessageBox.Show("数据尚未完成生产，暂时不能下载");
        }

        private void dgv_assistDataInNeed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }


    }
}
