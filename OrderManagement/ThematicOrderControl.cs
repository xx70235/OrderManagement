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

namespace OrderManagement
{
    public partial class ThematicOrderControl : DevExpress.XtraEditors.XtraUserControl
    {

        ThematicOrder thematicOrder;
        OrderManagementForm topForm;
        public ThematicOrderControl(OrderManagementForm topForm)
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
                        if (dgv_thematicOrder.Rows[e.RowIndex].Selected == false)
                        {
                            dgv_thematicOrder.ClearSelection();
                            dgv_thematicOrder.Rows[e.RowIndex].Selected = true;
                        }
                        //只选中一行时设置活动单元格
                        if (dgv_thematicOrder.SelectedRows.Count == 1)
                        {
                            dgv_thematicOrder.CurrentCell = dgv_thematicOrder.Rows[e.RowIndex].Cells[e.ColumnIndex];
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
                        if (dgv_thematicOrder.Rows[e.RowIndex].Selected == false)
                        {
                            dgv_thematicOrder.ClearSelection();
                            dgv_thematicOrder.Rows[e.RowIndex].Selected = true;
                        }
                        //只选中一行时设置活动单元格
                        if (dgv_thematicOrder.SelectedRows.Count == 1)
                        {
                            dgv_thematicOrder.CurrentCell = dgv_thematicOrder.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        }
                        //弹出操作菜单
                        //cms_rightButton.Show(MousePosition.X, MousePosition.Y);
                        DataGridViewRow dgvr = dgv_thematicOrder.SelectedRows[0];
                        ThematicOrder to = (ThematicOrder)dgvr.DataBoundItem;
                        this.topForm.ShowSelectedOrderInMap(to.Orderid);
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
            retriveOrder();
        }
        
        public void retriveOrder()
        {
            OrderDetailForm odf = new OrderDetailForm(false);
            if(dgv_thematicOrder==null)
            {
                MessageBox.Show("请先获取订单，并选中需解析的订单");
                return;
            }
            if (dgv_thematicOrder.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选中欲解析的订单");
                return;
            }
            if (dgv_thematicOrder.SelectedRows.Count == 1)
            {
                DataGridViewRow dgvr = dgv_thematicOrder.SelectedRows[0];
                ThematicOrder to = (ThematicOrder)dgvr.DataBoundItem;

                odf.RetriveOrder(to);
                this.thematicOrder = new ThematicOrder();
                this.thematicOrder = to;

            }
            odf.Show();
            odf.BringToFront();
        }

        private void 删除订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("开发中");
        }

        private void dgv_thematicOrder_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_thematicOrder.SelectedRows.Count == 1)
            {
                DataGridViewRow dgvr = dgv_thematicOrder.SelectedRows[0];
                ThematicOrder to = (ThematicOrder)dgvr.DataBoundItem;
                this.topForm.ShowSelectedOrderInMap(to.Orderid);
            }
        }
    }

}

