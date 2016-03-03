using GMap.NET;
using OrderManagement.Model;
using OrderManagement.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderManagement
{
    public partial class OrderDetailForm : Form
    {

        List<AssistData> assistInNeedList;
        List<CommonOrder> commonInNeedList;
        List<CommonOrder> commonOrderList;
        ThematicOrder thematicOrder;
        DataNameMap dataNameMap;
        OrderManagementForm mainForm;
        public bool IsMapSelection { get; set; }

        public OrderDetailForm(OrderManagementForm mainForm)
        {
            dataNameMap = new DataNameMap();
            this.mainForm = mainForm;
            InitializeComponent();
            bt_MapSelection.Enabled = true;
        }
        public OrderDetailForm(bool isLocalOrder=true)
        {

            dataNameMap = new DataNameMap();
            // this.mainForm = mainForm;
            InitializeComponent();
            if(!isLocalOrder)
            {
                this.bt_getDataRequest.Enabled = false;
                this.bt_RegisterLocalThematicOrder.Enabled = false;
                this.bt_MapSelection.Enabled = false;
            }
        }

        //public OrderDetailForm(ThematicOrder thematicOrder)
        //{
        //    dataNameMap = new DataNameMap();
        //    this.thematicOrder = thematicOrder;
        //    // this.mainForm = mainForm;
        //    InitializeComponent();
        //}

        public void SetCoverRage(string coverrage)
        {
            this.tb_detailedCoverrage.Text = coverrage;
        }

        public void RetriveOrder(ThematicOrder to)
        {

            //this.thematicOrder = new ThematicOrder();
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


<<<<<<< HEAD
                co.EnglishName = dataNameMap.GetCommonEnglishName(co.ProductName) ;
                co.ProductType = dataNameMap.GetCommonCategory(co.ProductName); 
                //TODO:查找数据库，找出该数据是否在库
                co.IsInDataBase = true;
=======
                co.EnglishName = dataNameMap.GetCommonEnglishName(co.ProductName); ;
                co.ProductType = dataNameMap.GetCommonCategory(co.ProductName); ;
                //TODO:查找数据库，找出该数据是否在库
                co.IsInDataBase = false;
>>>>>>> origin/master
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
                if (!ad.IsInDataBase)
                {
                    bt_addToTaskQueue.Enabled = false;
                }
                ad.ProductType = "";
                ad.EnglishName = "";
                assistListTmp.Add(ad);
            }
            dgv_assistDataInNeed.DataSource = assistInNeedList;
            if (checkIfCommonNeedSubmitted(this.thematicOrder.Orderid))
            {
                lb_ThematicOrderStatus.Text = "该定单所需的共性产品需求已提交至运营服务系统";
                bt_submitCommonOrder.Enabled = false;
                bt_feedBackDataWaiting.Enabled = false;

            }

        }

        private bool checkIfCommonNeedSubmitted(string orderid)
        {
            DataTable dt = DataBaseUtility.DataSelect("select * from TASK_ORDER_STATUS where TASK_ORDER_ID ='" + orderid + "'");
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["STATUS_SECTION"].ToString().Contains("等待数据"))
                    {

                        return true;
                    }
                }
            }
            return false;
        }

        private void bt_submitCommonOrder_Click(object sender, EventArgs e)
        {
            if (this.commonOrderList == null)
            {
                MessageBox.Show("请先解析订单或查看本地订单的数据需求");
                return;
            }
            if (this.commonOrderList.Count == 0)
            {
                MessageBox.Show("该订单无共性产品需求");
                return;
            }

            foreach (CommonOrder co in this.commonOrderList)
            {
                DataTable dt = DataBaseUtility.DataSelect("select * from GXORDER");
                CommonProductRequireSubmit cprs = new CommonProductRequireSubmit();

                string result = cprs.SubmitCPRequire(co);
                if (result ==null|| !result.Contains("成功"))
                {
                    MessageBox.Show("需求提交失败!");
                    return;
                }
                XmlUtility xmlUtility = new XmlUtility();
                string commonOrderId = xmlUtility.GetOrderIdForCommonOrder(result);

                DataRow newRow = dt.NewRow();
                newRow["COMM_ORDER_ID"] = commonOrderId;//一个Common Order ID可能对应了多个产品需求
                newRow["PRODUCTNAME"] = co.ProductName;
                newRow["PRODUCTTYPE"] = co.ProductType;
                newRow["COVERSCOPE"] = co.CoverScope;
                newRow["STARTDATE"] = co.StartDate;
                newRow["ENDDATE"] = co.EndDate;
                newRow["CREATEDAT"] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                newRow["STATUS"] = "等待数据";
                dt.Rows.Add(newRow);
                DataBaseUtility.DataUpdate("GXORDER", dt);
            }


            MessageBox.Show("共性产品需求提交成功，请在“共性产品需求页面查看具体情况");
            ((Button)sender).Enabled = false;
        }


        public void EnableAddLocalThematicOrder()
        {
            //this.thematicOrder = null;
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
            string tmp = cb_detailedProductName.SelectedItem.ToString();
            string engname = dataNameMap.GetThematicEnglishName(tmp);
            if (engname != null)
            {
                tb_detailedEnglishName.Text = engname;
            }
        }

        private void bt_RegisterLocalThematicOrder_Click(object sender, EventArgs e)
        {
            if (this.thematicOrder != null)
            {
                ThematicOrderRegister tor = new ThematicOrderRegister();
                string result = tor.RegistThematicOrder(this.thematicOrder);

                if (result.Contains("成功"))
                {
                    XmlUtility xmlUtility = new XmlUtility();
                    this.thematicOrder.Orderid = xmlUtility.GetOrderIdForLocalOrder(result);
                    tb_detailedOrderId.Text = this.thematicOrder.Orderid;
                    MessageBox.Show("注册成功，定单ID为：" + this.thematicOrder.Orderid);

                    DataTable dt = DataBaseUtility.DataSelect("select * from TASK_ORDER");

                    if (dt.Select("TASK_ORDER_ID='" + thematicOrder.Orderid + "'").Length != 0)//查看数据库中是否存在该订单
                    {
                        thematicOrder.IsInDataBase = true;
                    }
                    else
                    {
                        DataRow newRow = dt.NewRow();
                        newRow["TASK_ORDER_ID"] = this.thematicOrder.Orderid;
                        newRow["SOURCE"] = "本地";
                        newRow["CREATE_DATE"] = thematicOrder.OrderDate;
                        newRow["PRODUCT_NAME"] = thematicOrder.ProductName;
                        newRow["PRODUCT_TYPE"] = thematicOrder.ProductType;
                        newRow["START_DATE"] = thematicOrder.StartDate;
                        newRow["END_DATE"] = thematicOrder.EndDate;
                        newRow["LEFT_TOP_LON"] = thematicOrder.CoverScope.Split(',')[0];
                        newRow["LEFT_TOP_LAT"] = thematicOrder.CoverScope.Split(',')[1];
                        newRow["RIGHT_BOTTOM_LON"] = thematicOrder.CoverScope.Split(',')[2];
                        newRow["RIGHT_BOTTOM_LAT"] = thematicOrder.CoverScope.Split(',')[3];
                        dt.Rows.Add(newRow);
                        DataBaseUtility.DataUpdate("TASK_ORDER", dt);
                    }
                }else
                {
                    MessageBox.Show("该订单未能成功注册至课题3服务运营平台，请联系服务运营平台客服人员。");
                }


            }
            else
            {
                MessageBox.Show("请首先查看数据需求！");
            }
        }

        private void bt_MapSelection_Click(object sender, EventArgs e)
        {
            if (this.mainForm != null)
            {
                //this.TopMost = false;
                this.mainForm.ClearMap();
                this.IsMapSelection = true;

            }
        }

        private void bt_feedBackDataWaiting_Click(object sender, EventArgs e)
        {
            ThematicOrderFeedBack tofb = new ThematicOrderFeedBack();
            if (this.thematicOrder != null)
            {
                string para = tofb.GenerateWaitCommonDataParam(this.thematicOrder.Orderid);
                string result = tofb.SubmitFeedBack(para);
                if (result.Contains("成功"))
                {
                    DataTable dt = DataBaseUtility.DataSelect("select * from TASK_ORDER_STATUS");
                    if (dt.Select("TASK_ORDER_ID='" + thematicOrder.Orderid + "'").Length != 0)//查看数据库中是否存在该订单
                    {
                        DataRow row = dt.Select("TASK_ORDER_ID='" + thematicOrder.Orderid + "'")[0];
                        row["STATUS_SECTION"] = "等待数据";
                        row["STATUS_DESC"] = "正在等待共性产品数据，待数据完备后开始生产";
                        row["IS_LAST_STATUS"] = "是";
                        row["LASTUPDATEDAT"] = DateTime.Now;
                        DataBaseUtility.DataUpdate("TASK_ORDER_STATUS", dt);
                    }
                    else
                    {
                        DataRow newRow = dt.NewRow();
                        newRow["TASK_ORDER_ID"] = this.thematicOrder.Orderid;
                        newRow["STATUS_SECTION"] = "等待数据";
                        newRow["STATUS_DESC"] = "正在等待共性产品数据，待数据完备后开始生产";
                        newRow["START_DATE"] = this.thematicOrder.StartDate;
                        newRow["END_DATE"] = this.thematicOrder.EndDate;
                        newRow["IS_LAST_STATUS"] = "是";
                        newRow["LASTUPDATEDAT"] = DateTime.Now;
                        dt.Rows.Add(newRow);
                        DataBaseUtility.DataUpdate("TASK_ORDER_STATUS", dt);
                    }

                    MessageBox.Show("状态反馈成功！");
                    ((Button)sender).Enabled = false;
                }
            }

        }

        private void bt_declineOrder_Click(object sender, EventArgs e)
        {
            ThematicOrderFeedBack tofb = new ThematicOrderFeedBack();
            if (this.thematicOrder != null)
            {
                string para = tofb.GenerateRejectParam(this.thematicOrder.Orderid);
                string result = tofb.SubmitFeedBack(para);
                if (result.Contains("成功"))
                {
                    DataTable dt = DataBaseUtility.DataSelect("select * from TASK_ORDER_STATUS");
                    if (dt.Select("TASK_ORDER_ID='" + thematicOrder.Orderid + "'").Length != 0)//查看数据库中是否存在该订单
                    {
                        DataRow row = dt.Select("TASK_ORDER_ID='" + thematicOrder.Orderid + "'")[0];
                        row["STATUS_SECTION"] = "已拒绝";
                        row["STATUS_DESC"] = "该订单无法生产，已拒绝";
                        row["IS_LAST_STATUS"] = "是";
                        row["LASTUPDATEDAT"] = DateTime.Now;
                        DataBaseUtility.DataUpdate("TASK_ORDER_STATUS", dt);
                    }
                    else
                    {
                        DataRow newRow = dt.NewRow();
                        newRow["TASK_ORDER_ID"] = this.thematicOrder.Orderid;
                        newRow["STATUS_SECTION"] = "已拒绝";
                        newRow["STATUS_DESC"] = "该订单无法生产，已拒绝";
                        newRow["START_DATE"] = this.thematicOrder.StartDate;
                        newRow["END_DATE"] = this.thematicOrder.EndDate;
                        newRow["IS_LAST_STATUS"] = "是";
                        newRow["LASTUPDATEDAT"] = DateTime.Now;
                        dt.Rows.Add(newRow);
                        DataBaseUtility.DataUpdate("TASK_ORDER_STATUS", dt);
                    }

                    MessageBox.Show("状态反馈成功！");
                    ((Button)sender).Enabled = false;
                }

            }
        }

        private void bt_addToTaskQueue_Click(object sender, EventArgs e)
        {
            if (this.thematicOrder != null)
            {
                //首先检查该订单是否已处理过，如果已处理则返回当前状态，该订单检查只适合在任务分配时使用，不适用于等待数据或拒绝订单
                bool isModify=false;//当等待数据变为进入生产队列时，该标记为true，意为该条状态需要修改
                DataTable dt2 = DataBaseUtility.DataSelect(@"select * from TASK_ORDER_STATUS");
                DataRow[] tmps = dt2.Select("TASK_ORDER_ID='" + thematicOrder.Orderid + "'");
                if (tmps.Length != 0)
                {
                    if (!tmps[0]["STATUS_SECTION"].ToString().Contains("等待数据"))
                    {
                         MessageBox.Show("该订单已处理，当前状态为：" + tmps[0]["STATUS_SECTION"].ToString()+",无需再次操作。");
                         return;
                    }
                    isModify = true;
                }
                //检查处理完毕

                //查找在线节点
                DataTable dt = DataBaseUtility.DataSelect(@"select * from SERVERNODE where NODE_STATUS = '在线'");
                List<ServerNode>  serverNodeList = new List<ServerNode>();
                foreach (DataRow row in dt.Rows)
                {
                    ServerNode sn = new ServerNode();
                    sn.Id = int.Parse(row["ID"].ToString());
                    sn.NodeIp = row["NODE_IP"].ToString();
                    sn.NodeName = row["NODE_NAME"].ToString();
                    sn.Port = int.Parse(row["NODE_PORT"].ToString());
                    sn.Status = "在线";
                    sn.TaskNum = int.Parse(row["TASK_NUM"].ToString());
                    serverNodeList.Add(sn);
                }
                
                //将选中的节点任务数+1
                Random r = new Random();
                int index = r.Next(serverNodeList.Count);
                DataRow rowtmp = dt.Select("ID='" + serverNodeList[index].Id + "'")[0];
                rowtmp["TASK_NUM"] = serverNodeList[index].TaskNum + 1;
                //rowtmp["NODE_NAME"] = "最新的";
                DataBaseUtility.DataUpdate("SERVERNODE", dt);
                if(!isModify)
                { 
                //向TASK_ORDER_STATUS表中写入处理记录
                DataRow newRow = dt2.NewRow();
                newRow["TASK_ORDER_ID"] = this.thematicOrder.Orderid;
                newRow["STATUS_SECTION"] = "等待生产队列";
                newRow["STATUS_DESC"] = "已进入生产队列，等待生产";
                newRow["START_DATE"] = this.thematicOrder.StartDate;
                newRow["END_DATE"] = this.thematicOrder.EndDate;
                newRow["LASTUPDATEDAT"] = DateTime.Now;
                newRow["NODE_NAME"] = serverNodeList[index].NodeName;
                newRow["NODE_IP"] = serverNodeList[index].NodeIp;
                newRow["IS_LAST_STATUS"] = "是";
                dt2.Rows.Add(newRow);
                DataBaseUtility.DataUpdate("TASK_ORDER_STATUS", dt2);
                }
                else
                {
                    DataRow row = tmps[0];
                    //row["TASK_ORDER_ID"] = this.thematicOrder.Orderid;
                    row["STATUS_SECTION"] = "等待生产队列";
                    row["STATUS_DESC"] = "已进入生产队列，等待生产";
                    //row["START_DATE"] = this.thematicOrder.StartDate;
                    //row["END_DATE"] = this.thematicOrder.EndDate;
                    row["LASTUPDATEDAT"] = DateTime.Now;
                    row["NODE_NAME"] = serverNodeList[index].NodeName;
                    row["NODE_IP"] = serverNodeList[index].NodeIp;
                    row["IS_LAST_STATUS"] = "是";
                    DataBaseUtility.DataUpdate("TASK_ORDER_STATUS", dt2);
                }
                MessageBox.Show("生产任务:" + this.thematicOrder.Orderid+"加入生产队列成功。");
            }
        }




    }

}

