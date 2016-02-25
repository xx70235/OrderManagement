﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OrderManagement.Model;
using OrderManagement.Utilities;

namespace OrderManagement.CustomeChart
{
    public partial class ServerMonitorControl : UserControl
    {
        public ServerMonitorControl()
        {
            InitializeComponent();
            //Navi2MonitorPage();
        }

        public void Navi2MonitorPage()
        {
            this.webBrowser1.Navigate("http://10.0.0.25:8085/");
        }

        public void AddServerNode(string name, string ip, int port)
        {
            ServerNode sn = new ServerNode();
            sn.NodeIp = ip;
            sn.NodeName = name;
            sn.Port = port;
            //sn.Status = status;
            HardwareMonitor hwm = new HardwareMonitor();
            string status = hwm.GetMonitorResult(ip);
            if (status == null)
                sn.Status = "离线";
            else
                sn.Status = "在线";
            DataTable dt = DataBaseUtility.DataSelect("select * from SERVERNODE");
            DataRow newRow = dt.NewRow();
            newRow["NODE_NAME"] = sn.NodeName;
            newRow["NODE_IP"] = sn.NodeIp;
            newRow["NODE_PORT"] = sn.Port;
            newRow["NODE_STATUS"] = sn.Status;
            newRow["TASK_NUM"] = 0;
            dt.Rows.Add(newRow);
            DataBaseUtility.DataUpdate("SERVERNODE", dt);
        }

        public void getServerInfo()
        {
            if (dgvServerNode.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选中生产节点");
                return;
            }
            if (dgvServerNode.SelectedRows.Count == 1)
            {
                DataGridViewRow dgvr = dgvServerNode.SelectedRows[0];
                ServerNode co = (ServerNode)dgvr.DataBoundItem;
                if (co.Status.Contains("在线"))
                {
                    this.lbCurrentNode.Text = co.NodeName;
                    this.webBrowser1.Navigate(@"http://"+co.NodeIp+":8085/");
                }
                else
                {
                    MessageBox.Show("该节点不在线，无法显示节点信息");
                }
            }
        }

        private void dgvServerNode_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
    }
}