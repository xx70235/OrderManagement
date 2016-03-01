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
    public partial class TaskConfigForm : Form
    {

        List<InputParameter> intPutDataList;
        List<OutputParameter> outPutDataList;
        string productName;
        string modelName;
        string model_id;
        string serviceUrl;
        DataNameMap dataNameMap;
        TaskStatusControl tsc;
        public bool IsMapSelection { get; set; }

        public TaskConfigForm(TaskStatusControl tsc)
        {
            dataNameMap = new DataNameMap();
            this.tsc = tsc;
            InitializeComponent();
            
        }
        public TaskConfigForm(bool isLocalOrder = true)
        {

            dataNameMap = new DataNameMap();
            // this.mainForm = mainForm;
            InitializeComponent();          
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

        private void bt_updateTaskConfig_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("当前任务配置已提交");
            this.Close();
        }

        public void RetriveTaskConfigInfo(ThematicTaskStatus to)
        {
            DataTable dt = DataBaseUtility.DataSelect("select * from TASK_ORDER where TASK_ORDER_ID='"+to.ThematicId+"'");
            List<ThematicOrder> thematicOrderList = new List<ThematicOrder>();
            if (dt == null)
            {
                MessageBox.Show("查询未返回结果,请检查数据库!");
                return;
            }
            foreach (DataRow row in dt.Rows)
            {
                ThematicOrder order = new ThematicOrder();
                order.Orderid = row["TASK_ORDER_ID"].ToString();
                order.ProductName = row["PRODUCT_NAME"].ToString();
                
                order.EnglishName = row["ENGLISH_NAME"].ToString();
                order.OrderDate = row["CREATE_DATE"].ToString();
                order.ProductType = row["PRODUCT_TYPE"].ToString();
                order.StartDate = row["START_DATE"].ToString();
                order.EndDate = row["END_DATE"].ToString();
                order.CoverScope = row["LEFT_TOP_LON"].ToString() + "," + row["LEFT_TOP_LAT"].ToString() + "," + row["RIGHT_BOTTOM_LON"].ToString() + "," + row["RIGHT_BOTTOM_LAT"].ToString();
                thematicOrderList.Add(order);              
            }            
            tb_detailedOrderId.Text = thematicOrderList[0].Orderid;

            cb_detailedProductName.Text = thematicOrderList[0].ProductName;
            this.productName = thematicOrderList[0].ProductName;
            cb_detailedProductType.Text = thematicOrderList[0].ProductType;
            tb_detailedEnglishName.Text = thematicOrderList[0].EnglishName;
            dtp_detailedStartDate.Text = thematicOrderList[0].StartDate;
            dtp_DetailedEndDate.Text = thematicOrderList[0].EndDate;
            tb_detailedCoverrage.Text = thematicOrderList[0].CoverScope;
            getDataInNeed(to);         
        }
        private void getDataInNeed(ThematicTaskStatus to)
        {            
            List<InputParameter> taskInputInNeed = GetInputParameterInNeed(to);
            List<OutputParameter> taskOutputInNeed = GetOutputParameterInNeed(to);
            this.dgv_taskInputInNeed.DataSource = taskInputInNeed;
            this.dgv_taskOutputInNeed.DataSource = taskOutputInNeed;

        }
        private List<InputParameter> GetInputParameterInNeed(ThematicTaskStatus to)
        {
            String ProductName=this.productName;
            DataTable dt = DataBaseUtility.DataSelect("select * from MODELINFOMANAGEMENT where MODEL_NAME='" + ProductName + "'");
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
                this.tsc.currentServiceUrl = model.Model_url;

                modelList.Add(model);
            }
            if (modelList[0].Model_id!=null&&!"".Equals(modelList[0].Model_id))
            {
                this.model_id = modelList[0].Model_id;
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
                input.InputPara_model_name = this.productName;
                input.InputPara_name = row["INPUTPARA_NAME"].ToString();
                input.InputPara_valueType = row["INPUTPARA_VALUETYPE"].ToString();
                input.InputPara_defaultValue = row["INPUTPARA_DEFAULTVALUE"].ToString();
                input.InputPara_currentValue = row["INPUTPARA_CURRENTVALUE"].ToString();
                input.InputPara_des = row["INPUTPAR_DES"].ToString();
                inputList.Add(input);
            }
            return inputList;
        }

        private List<OutputParameter> GetOutputParameterInNeed(ThematicTaskStatus to)
        {
            DataTable dt2=null;
            if (this.model_id!=null&&!"".Equals(this.model_id))
            {
               dt2 = DataBaseUtility.DataSelect("select * from OUTPUTPARAMETER where MODEL_ID='" + this.model_id + "'");    
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
                output.OutputPara_model_name = this.productName;
                output.OutputPara_name = row["OUTPUTPARA_NAME"].ToString();
                output.OutputPara_valueType = row["OUTPUTPARA_VALUETYPE"].ToString();
                output.OutputPara_defaultValue = row["OUTPUTPARA_DEFAULTVALUE"].ToString();
                output.OutputPara_currentValue = row["OUTPUTPARA_CURRENTVALUE"].ToString();
                output.OutputPara_des = row["OUTPUTPAR_DES"].ToString();
                outputList.Add(output);
            }
            return outputList;
        }
    }

}

