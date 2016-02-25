using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking;
using System.Windows.Forms;
using OrderManagement.Model;
using GMap.NET.WindowsForms;

namespace OrderManagement
{
    public partial class TaskStatusControl : UserControl
    {
        
        OrderManagementForm topForm;
        ThematicTaskStatus currentTask;
        public TaskStatusControl()
        {
            InitializeComponent();            
        }
        public TaskStatusControl(OrderManagementForm topForm)
        {
            InitializeComponent();
            this.IsVisible = DockingStyle.Bottom;
            this.topForm = topForm;
        }
        public DockingStyle IsVisible { get; set; }
        private void dgvTaskStatus_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvTaskStatus_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvTaskStatus.SelectedRows.Count == 1)
            {
                DataGridViewRow dgvr = dgvTaskStatus.SelectedRows[0];
                ThematicTaskStatus to = (ThematicTaskStatus)dgvr.DataBoundItem;
                this.topForm.ShowSelectedOrderInMap(to.ThematicId);
                              
            }
        }

        public void taskOutputConfig()
        {
            throw new NotImplementedException();
        }

        public void taskInputConfig()
        {
            //OrderDetailForm odf = new OrderDetailForm(false);
            //if (taskStatus == null)
            //{
            //    MessageBox.Show("请先获取订单，并选中需解析的订单");
            //    return;
            //}
            //if (dgv_thematicOrder.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("请先选中欲解析的订单");
            //    return;
            //}
            //if (dgv_thematicOrder.SelectedRows.Count == 1)
            //{
            //    DataGridViewRow dgvr = dgv_thematicOrder.SelectedRows[0];
            //    ThematicOrder to = (ThematicOrder)dgvr.DataBoundItem;

            //    odf.RetriveOrder(to);
            //    this.thematicOrder = new ThematicOrder();
            //    this.thematicOrder = to;

            //}
            //odf.Show();
            //odf.BringToFront();
           
        }

        public void invokeServiceToProduce()
        {
            throw new NotImplementedException();
        }
    }
}
