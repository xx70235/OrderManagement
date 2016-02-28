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
        ThematicTaskStatus currentTaskStatus;
        public string currentServiceUrl;

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
                currentTaskStatus = to;
            }
        }
        

        public void taskParameterConfig()
        {
            TaskConfigForm tcf = new TaskConfigForm(this);
            if (dgvTaskStatus == null)
            {
                MessageBox.Show("请先获取任务队列，并选中需进行配置的任务");
                return;
            }
            if (dgvTaskStatus.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选中需配置的任务");
                return;
            }
            if (dgvTaskStatus.SelectedRows.Count == 1)
            {
                DataGridViewRow dgvr = dgvTaskStatus.SelectedRows[0];
                ThematicTaskStatus to = (ThematicTaskStatus)dgvr.DataBoundItem;
                MessageBox.Show("当前选择行为:"+to.ThematicId);
                tcf.RetriveTaskConfigInfo(to);
            }
            tcf.Show();
            tcf.BringToFront();
           
        }

        public void invokeServiceToProduce()
        {


            EcoSystemServices.EcoSystemServicesClient client = new EcoSystemServices.EcoSystemServicesClient();
            int start = System.Environment.TickCount;



            //string mgx1 = @"C:\服务部署环境\863模型-20150419\Config\0测试数据\数据\数据\03-问题要素\04-生态系统敏感性指数\input\BEIJJING_2000M01S01_NPP.TIF";
            //string mgx2 = @"C:\服务部署环境\863模型-20150419\Config\0测试数据\数据\数据\03-问题要素\04-生态系统敏感性指数\output\2000敏感性专题.tif";
            int end = 0;
            string info = null;
            IAsyncResult ar = null;
            string xmlContent = null;
            xmlContent = System.IO.File.ReadAllText(@"C:\\荒漠化指数.xml");
            //MessageBox.Show("XML内容：" + xmlContent);
            MessageBox.Show("已提交任务到服务器，开始生产");
            ar = client.BeginModel_Invoke(xmlContent, delegate
            {
                //回调方法体
                end = System.Environment.TickCount;
                info = client.EndModel_Invoke(ar);
                //string currentResult = "生态系统敏感性指数服务计算结果：" + info + "\n耗时：" + (end - start) / 1000 + "s(精确到ms)";                
                MessageBox.Show("当前任务计算结果：" + info + "\n耗时：" + (end - start) / 1000 + "s(精确到ms)");
                
            }, new object());
            Console.ReadLine();
            
        }
       
        private void changeStatusControlAndMap()
        {
            //throw new NotImplementedException();
        }
        

    }
}
