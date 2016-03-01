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
using System.IO;

using OrderManagement.Utilities;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Reflection;
using System.Web;
using EnvironmentServices_New;

namespace OrderManagement
{
    public partial class TaskStatusControl : UserControl
    {
        
        OrderManagementForm topForm;
        ThematicTaskStatus currentTaskStatus;
        public string currentServiceUrl;      
        string currentProductName;
        string currentModel_id;
        string serverNodeIp;

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
                this.topForm.ShowSelectedOrderInMap(to.ThematicId,to);
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
                //MessageBox.Show("当前选择行为:"+to.ThematicId);
                tcf.RetriveTaskConfigInfo(to);
            }
            tcf.Show();
            tcf.BringToFront();
           
        }

        public void invokeServiceToProduce()
        {
            ThematicTaskStatus to = null;
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
                to = (ThematicTaskStatus)dgvr.DataBoundItem;
                if (to!=null)
                {
                    string xml = constructAllTaskConfig(to);
                    //string xmlContent = System.IO.File.ReadAllText(@"C:\\荒漠化指数.xml");
                    serverNodeIp = to.NodeIp;
                    currentServiceUrl = currentServiceUrl.Replace("202.205.84.114", serverNodeIp);
                    changeStatusControlAndMap(to, "生产中", "");
                    dynamicCall(to, currentServiceUrl, xml);

                    //MessageBox.Show("当前调用XML信息为：" + xml);                
                }
            }

            //EcoSystemServices.EcoSystemServicesClient client = new EcoSystemServices.EcoSystemServicesClient();
            //int start = System.Environment.TickCount;



            ////string mgx1 = @"C:\服务部署环境\863模型-20150419\Config\0测试数据\数据\数据\03-问题要素\04-生态系统敏感性指数\input\BEIJJING_2000M01S01_NPP.TIF";
            ////string mgx2 = @"C:\服务部署环境\863模型-20150419\Config\0测试数据\数据\数据\03-问题要素\04-生态系统敏感性指数\output\2000敏感性专题.tif";
            //int end = 0;
            //string info = null;
            //IAsyncResult ar = null;
            //string xmlContent = xml;
            //xmlContent = System.IO.File.ReadAllText(@"C:\\荒漠化指数.xml");
            ////MessageBox.Show("XML内容：" + xmlContent);
            //MessageBox.Show("已提交任务到服务器，开始生产");
            //ar = client.BeginModel_Invoke(xmlContent, delegate
            //{
            //    //回调方法体
            //    end = System.Environment.TickCount;
            //    info = client.EndModel_Invoke(ar);
            //    //string currentResult = "生态系统敏感性指数服务计算结果：" + info + "\n耗时：" + (end - start) / 1000 + "s(精确到ms)";                
            //    MessageBox.Show("当前任务计算结果：" + info + "\n耗时：" + (end - start) / 1000 + "s(精确到ms)");
                
            //}, new object());
            //Console.ReadLine();
            
        }
        public  string dynamicCall(ThematicTaskStatus to  ,string url, string xmlContent)
        {
            string result = url.Substring(url.LastIndexOf("/") + 1);
            int start = System.Environment.TickCount;
            int end;
            IAsyncResult ar = null;
            string info = null;
            try
            {
                IEcoSystemServices client = ServiceManager.CreateWCFServiceByURL<IEcoSystemServices>(url);
                ar = client.BeginModel_Invoke(xmlContent, delegate
                {
                    end = System.Environment.TickCount;
                    info = client.EndModel_Invoke(ar);
                    string currentResult = "服务计算结果：" + info + "\n耗时：" + (end - start) / 1000 + "s)";
                    changeStatusControlAndMap(to, "生产完成", currentResult);
                    //System.Windows.Forms.MessageBox.Show(currentResult);
                }, new object());
            }
            catch (Exception ef)
            {
                MessageBox.Show("服务调用失败，请检查数据：" + ef);

            }
            finally {
                if (info==null)
                {
                    info = "Failed";
                }
           
            }
            return info;
        }

        private string constructAllTaskConfig(ThematicTaskStatus to)
        {
            ThematicOrder order = null;
            DataTable dt = DataBaseUtility.DataSelect("select * from TASK_ORDER where TASK_ORDER_ID='" + to.ThematicId + "'");
            List<ThematicOrder> thematicOrderList = new List<ThematicOrder>();
            if (dt == null)
            {
                MessageBox.Show("不存在当前任务配置信息,请检查数据库!");
                return null;
            }
            foreach (DataRow row in dt.Rows)
            {
                order = new ThematicOrder();
                order.Orderid = row["TASK_ORDER_ID"].ToString();
                order.ProductName = row["PRODUCT_NAME"].ToString();

                order.EnglishName = row["ENGLISH_NAME"].ToString();
                order.OrderDate = row["CREATE_DATE"].ToString();
                order.ProductType = row["PRODUCT_TYPE"].ToString();
                order.StartDate = row["START_DATE"].ToString();
                order.EndDate = row["END_DATE"].ToString();
                order.CoverScope = row["LEFT_TOP_LON"].ToString() + "," + row["LEFT_TOP_LAT"].ToString() + "," + row["RIGHT_BOTTOM_LON"].ToString() + "," + row["RIGHT_BOTTOM_LAT"].ToString();                
            }
            currentProductName = order.ProductName;
            List<InputParameter> taskInputInNeed = QueryInputParameterInNeed(currentProductName);
            List<OutputParameter> taskOutputInNeed = QueryOutputParameterInNeed(currentProductName);
            string xmlContent = constructInvokeXml(taskInputInNeed, taskOutputInNeed,currentProductName); 
            return xmlContent;
        
        }
        private string updateCurrentModelName(ThematicTaskStatus to) 
        {
            ThematicOrder order = null;
            DataTable dt = DataBaseUtility.DataSelect("select * from TASK_ORDER where TASK_ORDER_ID='" + to.ThematicId + "'");
            
            if (dt == null)
            {
                MessageBox.Show("不存在当前任务配置信息,请检查数据库!");
                return null;
            }
            foreach (DataRow row in dt.Rows)
            {
                order = new ThematicOrder();
                order.Orderid = row["TASK_ORDER_ID"].ToString();
                order.ProductName = row["PRODUCT_NAME"].ToString();

                order.EnglishName = row["ENGLISH_NAME"].ToString();
                order.OrderDate = row["CREATE_DATE"].ToString();
                order.ProductType = row["PRODUCT_TYPE"].ToString();
                order.StartDate = row["START_DATE"].ToString();
                order.EndDate = row["END_DATE"].ToString();
                order.CoverScope = row["LEFT_TOP_LON"].ToString() + "," + row["LEFT_TOP_LAT"].ToString() + "," + row["RIGHT_BOTTOM_LON"].ToString() + "," + row["RIGHT_BOTTOM_LAT"].ToString();
            }
            currentProductName = order.ProductName;
            return currentProductName;
        }

        private string constructInvokeXml(List<InputParameter> taskInputInNeed, List<OutputParameter> taskOutputInNeed, string productName)
        {
            Dictionary<string, string> dicValue = new Dictionary<string, string>();
            Dictionary<string, string> dicAliasName = new Dictionary<string, string>();
            foreach (var item in taskInputInNeed)
            {
                dicValue[item.InputPara_name] = item.InputPara_defaultValue;
                dicAliasName[item.InputPara_name] = item.InputPara_des;
            }
            foreach (var item in taskOutputInNeed)
            {
                dicValue[item.OutputPara_name] = item.OutputPara_defaultValue;
                dicAliasName[item.OutputPara_name] = item.OutputPara_des;
            }
            //dicValue["btnInFileJGLD"] = this.btnInFileJGLD;
            //dicAliasName["btnInFileJGLD"] = "景观廊道数据";
            //dicValue["btnInFileSTXT"] = this.btnInFileSTXT;
            //dicAliasName["btnInFileSTXT"] = "生态系统类型图";
            //dicValue["btnOutFile1"] = this.btnOutFile1;
            //dicAliasName["btnOutFile1"] = "人类活动干扰强度指数专题产品：";
            //dicValue["txtGridSize"] = this.txtGridSize;
            //dicAliasName["txtGridSize"] = "网格大小";
            //dicValue["cmbCode"] = this.cmbCode + "";
            //dicAliasName["cmbCode"] = "生态系统类型编码（CODE）";
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();
            foreach (KeyValuePair<string, string> current in dicValue)
            {
                if (current.Key.ToLower().StartsWith("btnout"))
                {
                    list2.Add(current.Key);
                }
                else if (current.Key.ToLower().StartsWith("btn"))
                {
                    list1.Add(current.Key);
                }
                else if (current.Key.ToLower().StartsWith("cmb") || current.Key.StartsWith("txt"))
                {
                    list3.Add(current.Key);
                }
            }
            
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            stringBuilder.AppendLine(string.Format("<GeneralArgsConfig FunctionName=\"{0}\" Category=\"{1}\">", productName, "格局要素"));
            stringBuilder.AppendLine("<fileArg>");
            foreach (string current2 in list1)
            {
                stringBuilder.AppendLine(string.Format("<Arg Name=\"{0}\" Desc=\"{1}\"> ", current2, (dicAliasName[current2] == "") ? "" : dicAliasName[current2]));
                stringBuilder.AppendLine(string.Format("<value>{0}</value>", dicValue[current2]));
                stringBuilder.AppendLine(string.Format("</Arg>", new object[0]));
            }
            foreach (string current3 in list2)
            {
                stringBuilder.AppendLine(string.Format("<Arg Name=\"{0}\" Desc=\"{1}\"> ", current3, (dicAliasName[current3] == "") ? "" : dicAliasName[current3]));
                stringBuilder.AppendLine(string.Format("<value>{0}</value>", dicValue[current3]));
                stringBuilder.AppendLine(string.Format("</Arg>", new object[0]));
            }
            stringBuilder.AppendLine("</fileArg>");
            stringBuilder.AppendLine("<valueArg>");
            foreach (string current4 in list3)
            {
                stringBuilder.AppendLine(string.Format("<Arg Name=\"{0}\" Desc=\"{1}\"> ", current4, (dicAliasName[current4] == "") ? "" : dicAliasName[current4]));
                stringBuilder.AppendLine(string.Format("<value>{0}</value>", dicValue[current4]));
                stringBuilder.AppendLine(string.Format("</Arg>", new object[0]));
            }
            stringBuilder.AppendLine("</valueArg>");
            stringBuilder.AppendLine("</GeneralArgsConfig>");
            return stringBuilder.ToString();
        }
        private void changeStatusControlAndMap(ThematicTaskStatus to,string status,string extraInfo)
        {
            if ("生产中".Equals(status))
            {
                to.TaskStatus = OrderStatus.生产中;
                to.StatusDes = "已进入生产队列，正在生产中" + extraInfo;
                
                DataTable dt = DataBaseUtility.DataSelect("select * from TASK_ORDER_STATUS where TASK_ORDER_ID='" + to.ThematicId + "'");               
                if (dt == null)
                {
                    MessageBox.Show("不存在当前任务配置信息,请检查数据库!");
                    return ;
                }
                foreach (DataRow row in dt.Rows)
                {
                    row["STATUS_SECTION"] = to.TaskStatus.ToString();                    
                    row["STATUS_DESC"] = to.StatusDes+";"+extraInfo;                   
                }
                DataBaseUtility.DataUpdate("TASK_ORDER_STATUS",dt);
                //修改前端地图控件颜色
                this.Refresh();
                this.topForm.ShowSelectedOrderInMap(to.ThematicId,to);
                
            }
            if ("生产完成".Equals(status))
            {
                to.TaskStatus = OrderStatus.生产完成;
                to.StatusDes = "已生产完成，可下载结果数据到本地" + extraInfo;                
                DataTable dt = DataBaseUtility.DataSelect("select * from TASK_ORDER_STATUS where TASK_ORDER_ID='" + to.ThematicId + "'");
                if (dt == null)
                {
                    MessageBox.Show("不存在当前任务配置信息,请检查数据库!");
                    return;
                }
                foreach (DataRow row in dt.Rows)
                {
                    row["STATUS_SECTION"] = to.TaskStatus.ToString();
                    row["STATUS_DESC"] = to.StatusDes + ";" + extraInfo;
                }
                DataBaseUtility.DataUpdate("TASK_ORDER_STATUS", dt);
                //修改前端地图控件颜色                
                
            }
            //throw new NotImplementedException();
        }
        private List<InputParameter> QueryInputParameterInNeed(string productName)
        {
           

            DataTable dt = DataBaseUtility.DataSelect("select * from MODELINFOMANAGEMENT where MODEL_NAME='" + productName + "'");
            List<TaskModelInfo> modelList = new List<TaskModelInfo>();
            if (dt == null)
            {
                MessageBox.Show("查询未返回结果,请检查数据库!");
                return null;
            }
            foreach (DataRow row in dt.Rows)
            {
                TaskModelInfo model = new TaskModelInfo();
                model.Model_id = row["MODEL_ID"].ToString();
                model.Model_name = row["MODEL_NAME"].ToString();
                model.Model_url = row["MODEL_URL"].ToString();
                this.currentServiceUrl = model.Model_url;
                modelList.Add(model);
            }
            if (modelList[0].Model_id != null && !"".Equals(modelList[0].Model_id))
            {
                currentModel_id = modelList[0].Model_id;
            }
            DataTable dt2 = DataBaseUtility.DataSelect("select * from INPUTPARAMETER where MODEL_ID='" + modelList[0].Model_id + "'");
            List<InputParameter> inputList = new List<InputParameter>();
            if (dt2 == null)
            {
                MessageBox.Show("查询未返回结果,请检查数据库!");
                return null;
            }
            foreach (DataRow row in dt2.Rows)
            {
                InputParameter input = new InputParameter();
                input.InputPara_model_name = productName;
                input.InputPara_name = row["INPUTPARA_NAME"].ToString();
                input.InputPara_valueType = row["INPUTPARA_VALUETYPE"].ToString();
                input.InputPara_defaultValue = row["INPUTPARA_DEFAULTVALUE"].ToString();
                input.InputPara_currentValue = row["INPUTPARA_CURRENTVALUE"].ToString();
                input.InputPara_des = row["INPUTPAR_DES"].ToString();
                inputList.Add(input);
            }
            return inputList;
        }

        private List<OutputParameter> QueryOutputParameterInNeed(string productName)
        {
            DataTable dt2 = null;
            if (currentModel_id != null && !"".Equals(currentModel_id))
            {
                dt2 = DataBaseUtility.DataSelect("select * from OUTPUTPARAMETER where MODEL_ID='" + currentModel_id + "'");
            }
            List<OutputParameter> outputList = new List<OutputParameter>();
            if (dt2 == null)
            {
                MessageBox.Show("查询未返回结果,请检查数据库!");
                return null;
            }
            foreach (DataRow row in dt2.Rows)
            {
                OutputParameter output = new OutputParameter();
                output.OutputPara_model_name = productName;
                output.OutputPara_name = row["OUTPUTPARA_NAME"].ToString();
                output.OutputPara_valueType = row["OUTPUTPARA_VALUETYPE"].ToString();
                output.OutputPara_defaultValue = row["OUTPUTPARA_DEFAULTVALUE"].ToString();
                output.OutputPara_currentValue = row["OUTPUTPARA_CURRENTVALUE"].ToString();
                output.OutputPara_des = row["OUTPUTPAR_DES"].ToString();
                outputList.Add(output);
            }
            return outputList;
        }


        public  void downloadDataToLocal()
        {
            ThematicTaskStatus to = null;            
            string locaPath=null;
            string remoteFile;
            if (dgvTaskStatus == null)
            {
                MessageBox.Show("请先获取任务队列，并选中完成生产的任务");
                return;
            }
            if (dgvTaskStatus.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选中完成生产的任务");
                return;
            }
            if (dgvTaskStatus.SelectedRows.Count == 1)
            {
                DataGridViewRow dgvr = dgvTaskStatus.SelectedRows[0];
                to = (ThematicTaskStatus)dgvr.DataBoundItem;
                updateCurrentModelName(to);
               List<OutputParameter> outList=QueryOutputParameterInNeed(currentProductName);
                if (to != null)
                {
                    if (to.TaskStatus == OrderStatus.生产完成)
                    {
                        System.Windows.Forms.FolderBrowserDialog folderSave = new System.Windows.Forms.FolderBrowserDialog();                        
                        if(folderSave.ShowDialog()==DialogResult.OK)
                         {
                             locaPath = folderSave.SelectedPath;
                             string btnOutFile = outList[0].OutputPara_currentValue;
                             remoteFile = FtpHelper.ftpPath + btnOutFile.Substring(btnOutFile.LastIndexOf("\\") + 1);
                             string ftpPath = remoteFile.Substring(0, remoteFile.LastIndexOf("/") + 1);
                             string fileName = remoteFile.Substring(remoteFile.LastIndexOf("/") + 1);
                             FtpHelper.Instance.DownloadMultiple(FtpHelper.userId, FtpHelper.pwd, remoteFile.Substring(0, remoteFile.LastIndexOf("/") + 1), locaPath, remoteFile.Substring(remoteFile.LastIndexOf("/") + 1));
                             MessageBox.Show("下载成功");
                          }                                                                                                                            
                    }
                    else
                    {
                        MessageBox.Show("专题产品生产尚未完成，请稍后尝试下载");
                    }
                    
                }
            }
            
            
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
            if (currentTaskStatus!=null)
            {
                this.topForm.ShowSelectedOrderInMap(currentTaskStatus.ThematicId,currentTaskStatus);
            }            
        }

        private void dgvTaskStatus_CellMouseDown(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (e.RowIndex >= 0)
                    {
                        //若行已是选中状态就不再进行设置
                        if (dgvTaskStatus.Rows[e.RowIndex].Selected == false)
                        {
                            dgvTaskStatus.ClearSelection();
                            dgvTaskStatus.Rows[e.RowIndex].Selected = true;
                        }
                        this.topForm.ShowSelectedOrderInMap(currentTaskStatus.ThematicId, currentTaskStatus);
                        
                        //弹出操作菜单
                        bt_refresh.Show(MousePosition.X, MousePosition.Y);
                    }
                }
                
           
            }
            catch (System.ArgumentOutOfRangeException e1)
            {
                //e1.ToString();
            }

        }
    }
}
