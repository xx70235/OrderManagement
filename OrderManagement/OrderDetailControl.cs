using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OrderManagement.Model;
using OrderManagement.Utilities;

namespace OrderManagement
{
    public partial class OrderDetailControl : UserControl
    {
        public OrderDetailControl()
        {
            InitializeComponent();
        }

   List<AssistData> assistInNeedList;
        List<CommonOrder> commonInNeedList;
        List<CommonOrder> commonOrderList;
        ThematicOrder thematicOrder;
        DataNameMap dataNameMap;

      

        public void RetriveOrder(ThematicOrder to)
        {

            //this.thematicOrder = new ThematicOrder();
            //this.thematicOrder = to;
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
               

                co.EnglishName = dataNameMap.GetCommonEnglishName(co.ProductName); ;
                co.ProductType = dataNameMap.GetCommonCategory(co.ProductName); ;
                //TODO:查找数据库，找出该数据是否在库
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

            CommonProductRequireSubmit cprs = new CommonProductRequireSubmit();
            //string result = cprs.SubmitCPRequire(this.commonOrderList);
            XmlUtility xmlUtility = new XmlUtility();
            //string commonOrderId = xmlUtility.GetOrderIdForCommonOrder(result);
            //foreach(CommonOrder  co in this.commonOrderList)
            //{
            //    co.Orderid = commonOrderId;
            //}

            
            //this.dgv_commonOrder.DataSource = this.commonOrderList;
            MessageBox.Show("共性产品需求提交成功，请在“共性产品需求页面查看具体情况”");
        }
        //public void DisableAddLocalThematicOrder()
        //{
        //    this.bt_addLocalThematicOrder.Enabled = false;
        //}


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
            if(engname!= null)
            { 
               tb_detailedEnglishName.Text = engname;
            }
        }

        private void bt_RegisterLocalThematicOrder_Click(object sender, EventArgs e)
        {
            if(this.thematicOrder!=null)
            {
                ThematicOrderRegister tor = new ThematicOrderRegister();
                string result  = tor.RegistThematicOrder(this.thematicOrder);

                if(result.Contains("成功"))
                {
                    XmlUtility xmlUtility = new XmlUtility();
                    this.thematicOrder.Orderid = xmlUtility.GetOrderIdForLocalOrder(result);
                    tb_detailedOrderId.Text = this.thematicOrder.Orderid;
                    MessageBox.Show("注册成功，定单ID为："+this.thematicOrder.Orderid);
                    //TODO:将定单写入数据库
                }


            }
            else
            {
                MessageBox.Show("请首先查看数据需求！");
            }
        }

        private void dataRepainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            DataGridView myDataGridView = (DataGridView)sender;

            if (myDataGridView.Rows.Count > 0)
            {
                int i = myDataGridView.ColumnHeadersHeight;//标题行高
                int j = myDataGridView.Rows.GetRowsHeight(DataGridViewElementStates.Visible); //所有可见行总高
                int k = myDataGridView.Height; //控件高度
                int l = myDataGridView.Rows.GetLastRow(DataGridViewElementStates.Visible);//最后一行索引
                int count = myDataGridView.Columns.Count;//列总数
                int width = 0;

                //当网格未充满控件时才画线
                if (i + j < k)
                {
                    using (Brush gridBrush = new SolidBrush(myDataGridView.GridColor))
                    {
                        using (Pen gridLinePen = new Pen(gridBrush))
                        {
                            //处理标题列
                            if (myDataGridView.RowHeadersVisible)
                            {
                                width = myDataGridView.RowHeadersWidth;
                                e.Graphics.DrawLine(gridLinePen, width, i + j, width, k);
                            }
                            else
                            {
                                width = 1;
                            }

                            //处理正常列
                            for (int index = 0; index < count; index++)
                            {
                                if (myDataGridView.Columns[index].Visible)
                                {
                                    width += myDataGridView.Columns[index].Width;

                                    e.Graphics.DrawLine(gridLinePen, width, i + j, width, k);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void dgv_commonProductInNeed_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            dataRepainting(sender,e);
        }

        private void dgv_assistDataInNeed_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            dataRepainting(sender,e);
        }

      
   

    }
}
