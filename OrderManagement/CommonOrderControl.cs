using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;

using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking;
using System.Windows.Forms;
using OrderManagement.Model;
using GMap.NET.WindowsForms;
using OrderManagement.Utilities;

namespace OrderManagement
{
    public partial class CommonOrderControl : DevExpress.XtraEditors.XtraUserControl
    {

        ThematicOrder thematicOrder;
        OrderManagementForm topForm;
        public CommonOrderControl(OrderManagementForm topForm)
        {
            InitializeComponent();
            this.IsVisible = DockingStyle.Bottom;
            this.topForm = topForm;
        }

        public DockingStyle IsVisible { get; set; }

        private void dgv_thematicOrder_CellMouseDown(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (e.RowIndex >= 0)
                    {
                        //若行已是选中状态就不再进行设置
                        if (dgv_CommonOrder.Rows[e.RowIndex].Selected == false)
                        {
                            dgv_CommonOrder.ClearSelection();
                            dgv_CommonOrder.Rows[e.RowIndex].Selected = true;
                        }
                        //只选中一行时设置活动单元格
                        if (dgv_CommonOrder.SelectedRows.Count == 1)
                        {
                            dgv_CommonOrder.CurrentCell = dgv_CommonOrder.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        }
                        //弹出操作菜单
                        cms_rightButton.Show(MousePosition.X, MousePosition.Y);
                    }
                }
                else if (e.Button == MouseButtons.Left)
                {
                    if (e.RowIndex >= 0)
                    {
                        //若行已是选中状态就不再进行设置
                        if (dgv_CommonOrder.Rows[e.RowIndex].Selected == false)
                        {
                            dgv_CommonOrder.ClearSelection();
                            dgv_CommonOrder.Rows[e.RowIndex].Selected = true;
                        }
                        //只选中一行时设置活动单元格
                        if (dgv_CommonOrder.SelectedRows.Count == 1)
                        {
                            dgv_CommonOrder.CurrentCell = dgv_CommonOrder.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        }
                        //弹出操作菜单
                        //cms_rightButton.Show(MousePosition.X, MousePosition.Y);
                        DataGridViewRow dgvr = dgv_CommonOrder.SelectedRows[0];
                        CommonOrder co = (CommonOrder)dgvr.DataBoundItem;
                        this.topForm.ShowSelectedOrderInMap(co.Orderid,null);
                    }
                }
            }
            catch (System.ArgumentOutOfRangeException e1)
            {
                //e1.ToString();
            }
        }

        private void dgv_thematicOrder_CellPainting(object sender, System.Windows.Forms.DataGridViewCellPaintingEventArgs e)
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

        private void tsmi_retriveOrder_Click(object sender, EventArgs e)
        {
            //OrderDetailForm odf = new OrderDetailForm();
            updateCommonOrderStatus();
           
        }

        public void updateCommonOrderStatus()
        {
            if (dgv_CommonOrder.SelectedRows.Count == 0)
            { 
                MessageBox.Show("请先选中欲解析的共性产品需求");
                return;
            }
            if (dgv_CommonOrder.SelectedRows.Count == 1)
            {
                DataGridViewRow dgvr = dgv_CommonOrder.SelectedRows[0];
                CommonOrder co = (CommonOrder)dgvr.DataBoundItem;
                CommonOrderStatusFeedBack cosf = new CommonOrderStatusFeedBack();
                string xmlpara = cosf.GenerateCommonOrderFeedBackStr(co.Orderid);
                string result = cosf.GetFeedBack(xmlpara);
                string status = OrderManagement.Utilities.XmlUtility.GetStatusForCommonOrder(result);
                if (status==null)
                    return;
                co.Status = status;
                dgvr.Cells[7].Value = status;//订单状态
                dgv_CommonOrder.Update();
                //dgvr.Cells.
                dgvr.Cells[8].Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");//订单时间
                dgv_CommonOrder.Update();

                DataTable dt = DataBaseUtility.DataSelect("select * from GXORDER where COMM_ORDER_ID ='" + co.Orderid + "'");
                foreach (DataRow row in dt.Rows)
                {
                    row["STATUS"] = status;
                    row["LASTUPDATEDAT"] = dgvr.Cells[8].Value;
                }
                DataBaseUtility.DataUpdate("GXORDER", dt);
            }
        }

        private void dgv_CommonOrder_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_CommonOrder.SelectedRows.Count == 1)
            {
                DataGridViewRow dgvr = dgv_CommonOrder.SelectedRows[0];
                CommonOrder co = (CommonOrder)dgvr.DataBoundItem;
                this.topForm.ShowSelectedOrderInMap(co.Orderid,null);
            }
        }
    }

}

