namespace OrderManagement
{
    partial class OrderDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_ThematicOrderStatus = new System.Windows.Forms.Label();
            this.bt_MapSelection = new System.Windows.Forms.Button();
            this.bt_RegisterLocalThematicOrder = new System.Windows.Forms.Button();
            this.bt_submitCommonOrder = new System.Windows.Forms.Button();
            this.bt_feedBackDataWaiting = new System.Windows.Forms.Button();
            this.bt_declineOrder = new System.Windows.Forms.Button();
            this.bt_addToTaskQueue = new System.Windows.Forms.Button();
            this.dgv_assistDataInNeed = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coverScopeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englishNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isInDataBaseDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.assistDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_commonProductInNeed = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coverScopeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englishNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isInDataBaseDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.commonOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bt_getDataRequest = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_detailedProductType = new System.Windows.Forms.ComboBox();
            this.cb_detailedProductName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_DetailedEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_detailedStartDate = new System.Windows.Forms.DateTimePicker();
            this.tb_detailedCoverrage = new System.Windows.Forms.TextBox();
            this.tb_detailedEnglishName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_detailedOrderId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.thematicOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ttMapSelection = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_assistDataInNeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commonProductInNeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commonOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thematicOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_ThematicOrderStatus);
            this.groupBox2.Controls.Add(this.bt_MapSelection);
            this.groupBox2.Controls.Add(this.bt_RegisterLocalThematicOrder);
            this.groupBox2.Controls.Add(this.bt_submitCommonOrder);
            this.groupBox2.Controls.Add(this.bt_feedBackDataWaiting);
            this.groupBox2.Controls.Add(this.bt_declineOrder);
            this.groupBox2.Controls.Add(this.bt_addToTaskQueue);
            this.groupBox2.Controls.Add(this.dgv_assistDataInNeed);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dgv_commonProductInNeed);
            this.groupBox2.Controls.Add(this.bt_getDataRequest);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cb_detailedProductType);
            this.groupBox2.Controls.Add(this.cb_detailedProductName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtp_DetailedEndDate);
            this.groupBox2.Controls.Add(this.dtp_detailedStartDate);
            this.groupBox2.Controls.Add(this.tb_detailedCoverrage);
            this.groupBox2.Controls.Add(this.tb_detailedEnglishName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_detailedOrderId);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(9, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1142, 350);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "订单详情";
            // 
            // lb_ThematicOrderStatus
            // 
            this.lb_ThematicOrderStatus.AutoSize = true;
            this.lb_ThematicOrderStatus.Location = new System.Drawing.Point(375, 310);
            this.lb_ThematicOrderStatus.Name = "lb_ThematicOrderStatus";
            this.lb_ThematicOrderStatus.Size = new System.Drawing.Size(0, 12);
            this.lb_ThematicOrderStatus.TabIndex = 29;
            // 
            // bt_MapSelection
            // 
            this.bt_MapSelection.Enabled = false;
            this.bt_MapSelection.Location = new System.Drawing.Point(260, 262);
            this.bt_MapSelection.Margin = new System.Windows.Forms.Padding(4);
            this.bt_MapSelection.Name = "bt_MapSelection";
            this.bt_MapSelection.Size = new System.Drawing.Size(71, 23);
            this.bt_MapSelection.TabIndex = 28;
            this.bt_MapSelection.Text = "地图选取";
            this.ttMapSelection.SetToolTip(this.bt_MapSelection, "按住Alt键进行框选，双击鼠标左键结束");
            this.bt_MapSelection.UseVisualStyleBackColor = true;
            this.bt_MapSelection.Click += new System.EventHandler(this.bt_MapSelection_Click);
            // 
            // bt_RegisterLocalThematicOrder
            // 
            this.bt_RegisterLocalThematicOrder.Location = new System.Drawing.Point(165, 300);
            this.bt_RegisterLocalThematicOrder.Margin = new System.Windows.Forms.Padding(4);
            this.bt_RegisterLocalThematicOrder.Name = "bt_RegisterLocalThematicOrder";
            this.bt_RegisterLocalThematicOrder.Size = new System.Drawing.Size(88, 33);
            this.bt_RegisterLocalThematicOrder.TabIndex = 26;
            this.bt_RegisterLocalThematicOrder.Text = "注册本地定单";
            this.bt_RegisterLocalThematicOrder.UseVisualStyleBackColor = true;
            this.bt_RegisterLocalThematicOrder.Click += new System.EventHandler(this.bt_RegisterLocalThematicOrder_Click);
            // 
            // bt_submitCommonOrder
            // 
            this.bt_submitCommonOrder.Location = new System.Drawing.Point(701, 300);
            this.bt_submitCommonOrder.Margin = new System.Windows.Forms.Padding(4);
            this.bt_submitCommonOrder.Name = "bt_submitCommonOrder";
            this.bt_submitCommonOrder.Size = new System.Drawing.Size(88, 33);
            this.bt_submitCommonOrder.TabIndex = 25;
            this.bt_submitCommonOrder.Text = "提交数据需求";
            this.bt_submitCommonOrder.UseVisualStyleBackColor = true;
            this.bt_submitCommonOrder.Click += new System.EventHandler(this.bt_submitCommonOrder_Click);
            // 
            // bt_feedBackDataWaiting
            // 
            this.bt_feedBackDataWaiting.Location = new System.Drawing.Point(811, 300);
            this.bt_feedBackDataWaiting.Margin = new System.Windows.Forms.Padding(4);
            this.bt_feedBackDataWaiting.Name = "bt_feedBackDataWaiting";
            this.bt_feedBackDataWaiting.Size = new System.Drawing.Size(88, 33);
            this.bt_feedBackDataWaiting.TabIndex = 23;
            this.bt_feedBackDataWaiting.Text = "反馈等待数据";
            this.bt_feedBackDataWaiting.UseVisualStyleBackColor = true;
            this.bt_feedBackDataWaiting.Click += new System.EventHandler(this.bt_feedBackDataWaiting_Click);
            // 
            // bt_declineOrder
            // 
            this.bt_declineOrder.Location = new System.Drawing.Point(1031, 300);
            this.bt_declineOrder.Margin = new System.Windows.Forms.Padding(4);
            this.bt_declineOrder.Name = "bt_declineOrder";
            this.bt_declineOrder.Size = new System.Drawing.Size(88, 33);
            this.bt_declineOrder.TabIndex = 22;
            this.bt_declineOrder.Text = "拒绝订单";
            this.bt_declineOrder.UseVisualStyleBackColor = true;
            this.bt_declineOrder.Click += new System.EventHandler(this.bt_declineOrder_Click);
            // 
            // bt_addToTaskQueue
            // 
            this.bt_addToTaskQueue.Location = new System.Drawing.Point(921, 300);
            this.bt_addToTaskQueue.Margin = new System.Windows.Forms.Padding(4);
            this.bt_addToTaskQueue.Name = "bt_addToTaskQueue";
            this.bt_addToTaskQueue.Size = new System.Drawing.Size(88, 33);
            this.bt_addToTaskQueue.TabIndex = 21;
            this.bt_addToTaskQueue.Text = "加入生产队列";
            this.bt_addToTaskQueue.UseVisualStyleBackColor = true;
            this.bt_addToTaskQueue.Click += new System.EventHandler(this.bt_addToTaskQueue_Click);
            // 
            // dgv_assistDataInNeed
            // 
            this.dgv_assistDataInNeed.AutoGenerateColumns = false;
            this.dgv_assistDataInNeed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_assistDataInNeed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn1,
            this.productTypeDataGridViewTextBoxColumn1,
            this.coverScopeDataGridViewTextBoxColumn1,
            this.englishNameDataGridViewTextBoxColumn1,
            this.startDateDataGridViewTextBoxColumn1,
            this.endDateDataGridViewTextBoxColumn1,
            this.isInDataBaseDataGridViewCheckBoxColumn1});
            this.dgv_assistDataInNeed.DataSource = this.assistDataBindingSource;
            this.dgv_assistDataInNeed.Location = new System.Drawing.Point(377, 170);
            this.dgv_assistDataInNeed.Name = "dgv_assistDataInNeed";
            this.dgv_assistDataInNeed.RowTemplate.Height = 23;
            this.dgv_assistDataInNeed.Size = new System.Drawing.Size(743, 115);
            this.dgv_assistDataInNeed.TabIndex = 20;
            // 
            // productNameDataGridViewTextBoxColumn1
            // 
            this.productNameDataGridViewTextBoxColumn1.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn1.HeaderText = "产品名称";
            this.productNameDataGridViewTextBoxColumn1.Name = "productNameDataGridViewTextBoxColumn1";
            // 
            // productTypeDataGridViewTextBoxColumn1
            // 
            this.productTypeDataGridViewTextBoxColumn1.DataPropertyName = "ProductType";
            this.productTypeDataGridViewTextBoxColumn1.HeaderText = "产品类型";
            this.productTypeDataGridViewTextBoxColumn1.Name = "productTypeDataGridViewTextBoxColumn1";
            // 
            // coverScopeDataGridViewTextBoxColumn1
            // 
            this.coverScopeDataGridViewTextBoxColumn1.DataPropertyName = "CoverScope";
            this.coverScopeDataGridViewTextBoxColumn1.HeaderText = "覆盖范围";
            this.coverScopeDataGridViewTextBoxColumn1.Name = "coverScopeDataGridViewTextBoxColumn1";
            // 
            // englishNameDataGridViewTextBoxColumn1
            // 
            this.englishNameDataGridViewTextBoxColumn1.DataPropertyName = "EnglishName";
            this.englishNameDataGridViewTextBoxColumn1.HeaderText = "产品简称";
            this.englishNameDataGridViewTextBoxColumn1.Name = "englishNameDataGridViewTextBoxColumn1";
            // 
            // startDateDataGridViewTextBoxColumn1
            // 
            this.startDateDataGridViewTextBoxColumn1.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn1.HeaderText = "开始时间";
            this.startDateDataGridViewTextBoxColumn1.Name = "startDateDataGridViewTextBoxColumn1";
            // 
            // endDateDataGridViewTextBoxColumn1
            // 
            this.endDateDataGridViewTextBoxColumn1.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn1.HeaderText = "结束时间";
            this.endDateDataGridViewTextBoxColumn1.Name = "endDateDataGridViewTextBoxColumn1";
            // 
            // isInDataBaseDataGridViewCheckBoxColumn1
            // 
            this.isInDataBaseDataGridViewCheckBoxColumn1.DataPropertyName = "IsInDataBase";
            this.isInDataBaseDataGridViewCheckBoxColumn1.HeaderText = "是否在库";
            this.isInDataBaseDataGridViewCheckBoxColumn1.Name = "isInDataBaseDataGridViewCheckBoxColumn1";
            // 
            // assistDataBindingSource
            // 
            this.assistDataBindingSource.DataSource = typeof(OrderManagement.Model.AssistData);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(284, 170);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 12);
            this.label12.TabIndex = 19;
            this.label12.Text = "所需辅助数据：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(284, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "所需共性产品：";
            // 
            // dgv_commonProductInNeed
            // 
            this.dgv_commonProductInNeed.AutoGenerateColumns = false;
            this.dgv_commonProductInNeed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_commonProductInNeed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn,
            this.coverScopeDataGridViewTextBoxColumn,
            this.englishNameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.isInDataBaseDataGridViewCheckBoxColumn});
            this.dgv_commonProductInNeed.DataSource = this.commonOrderBindingSource;
            this.dgv_commonProductInNeed.Location = new System.Drawing.Point(377, 31);
            this.dgv_commonProductInNeed.Name = "dgv_commonProductInNeed";
            this.dgv_commonProductInNeed.RowTemplate.Height = 23;
            this.dgv_commonProductInNeed.Size = new System.Drawing.Size(743, 116);
            this.dgv_commonProductInNeed.TabIndex = 17;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "产品名称";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.HeaderText = "产品类别";
            this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            // 
            // coverScopeDataGridViewTextBoxColumn
            // 
            this.coverScopeDataGridViewTextBoxColumn.DataPropertyName = "CoverScope";
            this.coverScopeDataGridViewTextBoxColumn.HeaderText = "覆盖范围";
            this.coverScopeDataGridViewTextBoxColumn.Name = "coverScopeDataGridViewTextBoxColumn";
            // 
            // englishNameDataGridViewTextBoxColumn
            // 
            this.englishNameDataGridViewTextBoxColumn.DataPropertyName = "EnglishName";
            this.englishNameDataGridViewTextBoxColumn.HeaderText = "产品简称";
            this.englishNameDataGridViewTextBoxColumn.Name = "englishNameDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "开始时间";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "结束时间";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // isInDataBaseDataGridViewCheckBoxColumn
            // 
            this.isInDataBaseDataGridViewCheckBoxColumn.DataPropertyName = "IsInDataBase";
            this.isInDataBaseDataGridViewCheckBoxColumn.HeaderText = "是否在库";
            this.isInDataBaseDataGridViewCheckBoxColumn.Name = "isInDataBaseDataGridViewCheckBoxColumn";
            // 
            // commonOrderBindingSource
            // 
            this.commonOrderBindingSource.DataSource = typeof(OrderManagement.Model.CommonOrder);
            // 
            // bt_getDataRequest
            // 
            this.bt_getDataRequest.Location = new System.Drawing.Point(14, 300);
            this.bt_getDataRequest.Margin = new System.Windows.Forms.Padding(4);
            this.bt_getDataRequest.Name = "bt_getDataRequest";
            this.bt_getDataRequest.Size = new System.Drawing.Size(88, 33);
            this.bt_getDataRequest.TabIndex = 8;
            this.bt_getDataRequest.Text = "查看数据需求";
            this.bt_getDataRequest.UseVisualStyleBackColor = true;
            this.bt_getDataRequest.Click += new System.EventHandler(this.bt_getDataRequest_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 262);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "空间范围：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 224);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "结束时间：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 186);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "开始时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "产品简称：";
            // 
            // cb_detailedProductType
            // 
            this.cb_detailedProductType.Enabled = false;
            this.cb_detailedProductType.FormattingEnabled = true;
            this.cb_detailedProductType.Items.AddRange(new object[] {
            "林业",
            "农业",
            "矿产",
            "区域河流",
            "生态环境"});
            this.cb_detailedProductType.Location = new System.Drawing.Point(102, 109);
            this.cb_detailedProductType.Margin = new System.Windows.Forms.Padding(4);
            this.cb_detailedProductType.Name = "cb_detailedProductType";
            this.cb_detailedProductType.Size = new System.Drawing.Size(151, 20);
            this.cb_detailedProductType.TabIndex = 13;
            this.cb_detailedProductType.Text = "生态环境";
            // 
            // cb_detailedProductName
            // 
            this.cb_detailedProductName.Enabled = false;
            this.cb_detailedProductName.FormattingEnabled = true;
            this.cb_detailedProductName.Items.AddRange(new object[] {
            "生态系统类型面积变化率",
            "生态系统敏感性指数",
            "植被水分利用效率",
            "景观破碎度",
            "景观分离度",
            "人类活动干扰强度",
            "景观多样性指数",
            "聚集度指数",
            "湖泊面积变化率",
            "荒漠化指数",
            "草地退化指数",
            "水源涵养量",
            "风蚀区土壤侵蚀模数",
            "水蚀区土壤侵蚀模数",
            "碳固定量",
            "全球环境监测指数",
            "生态系统宏观结构",
            "草原干旱指数",
            "雪盖面积变化率",
            "生态系统稳定性指数"});
            this.cb_detailedProductName.Location = new System.Drawing.Point(102, 69);
            this.cb_detailedProductName.Margin = new System.Windows.Forms.Padding(4);
            this.cb_detailedProductName.Name = "cb_detailedProductName";
            this.cb_detailedProductName.Size = new System.Drawing.Size(151, 20);
            this.cb_detailedProductName.TabIndex = 8;
            this.cb_detailedProductName.SelectedIndexChanged += new System.EventHandler(this.cb_detailedProductName_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "产品类别：";
            // 
            // dtp_DetailedEndDate
            // 
            this.dtp_DetailedEndDate.Enabled = false;
            this.dtp_DetailedEndDate.Location = new System.Drawing.Point(102, 225);
            this.dtp_DetailedEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_DetailedEndDate.Name = "dtp_DetailedEndDate";
            this.dtp_DetailedEndDate.Size = new System.Drawing.Size(151, 21);
            this.dtp_DetailedEndDate.TabIndex = 11;
            this.dtp_DetailedEndDate.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // dtp_detailedStartDate
            // 
            this.dtp_detailedStartDate.Enabled = false;
            this.dtp_detailedStartDate.Location = new System.Drawing.Point(102, 187);
            this.dtp_detailedStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_detailedStartDate.Name = "dtp_detailedStartDate";
            this.dtp_detailedStartDate.Size = new System.Drawing.Size(151, 21);
            this.dtp_detailedStartDate.TabIndex = 8;
            this.dtp_detailedStartDate.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // tb_detailedCoverrage
            // 
            this.tb_detailedCoverrage.Location = new System.Drawing.Point(102, 262);
            this.tb_detailedCoverrage.Name = "tb_detailedCoverrage";
            this.tb_detailedCoverrage.Size = new System.Drawing.Size(151, 21);
            this.tb_detailedCoverrage.TabIndex = 10;
            // 
            // tb_detailedEnglishName
            // 
            this.tb_detailedEnglishName.Location = new System.Drawing.Point(102, 149);
            this.tb_detailedEnglishName.Name = "tb_detailedEnglishName";
            this.tb_detailedEnglishName.ReadOnly = true;
            this.tb_detailedEnglishName.Size = new System.Drawing.Size(151, 21);
            this.tb_detailedEnglishName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "产品名称：";
            // 
            // tb_detailedOrderId
            // 
            this.tb_detailedOrderId.Location = new System.Drawing.Point(102, 31);
            this.tb_detailedOrderId.Name = "tb_detailedOrderId";
            this.tb_detailedOrderId.ReadOnly = true;
            this.tb_detailedOrderId.Size = new System.Drawing.Size(151, 21);
            this.tb_detailedOrderId.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "订单编号：";
            // 
            // thematicOrderBindingSource
            // 
            this.thematicOrderBindingSource.DataSource = typeof(OrderManagement.Model.ThematicOrder);
            // 
            // OrderDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 374);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "OrderDetailForm";
            this.ShowIcon = false;
            this.Text = "订单详情";
<<<<<<< HEAD
=======

            this.TopMost = true;

>>>>>>> origin/master
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_assistDataInNeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commonProductInNeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commonOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thematicOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_submitCommonOrder;
        private System.Windows.Forms.Button bt_feedBackDataWaiting;
        private System.Windows.Forms.Button bt_declineOrder;
        private System.Windows.Forms.Button bt_addToTaskQueue;
        private System.Windows.Forms.DataGridView dgv_assistDataInNeed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_commonProductInNeed;
        private System.Windows.Forms.BindingSource commonOrderBindingSource;
        private System.Windows.Forms.Button bt_getDataRequest;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_detailedProductType;
        private System.Windows.Forms.ComboBox cb_detailedProductName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_DetailedEndDate;
        private System.Windows.Forms.DateTimePicker dtp_detailedStartDate;
        private System.Windows.Forms.TextBox tb_detailedCoverrage;
        private System.Windows.Forms.TextBox tb_detailedEnglishName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_detailedOrderId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource thematicOrderBindingSource;
        private System.Windows.Forms.BindingSource assistDataBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coverScopeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn englishNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isInDataBaseDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coverScopeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn englishNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isInDataBaseDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button bt_RegisterLocalThematicOrder;
        private System.Windows.Forms.Button bt_MapSelection;
        private System.Windows.Forms.Label lb_ThematicOrderStatus;
        private System.Windows.Forms.ToolTip ttMapSelection;




    }
}