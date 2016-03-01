namespace OrderManagement
{
    partial class TaskConfigForm
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
            this.bt_addToTaskQueue = new System.Windows.Forms.Button();
            this.dgv_taskOutputInNeed = new System.Windows.Forms.DataGridView();
            this.outputParamodelnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputParanameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputParavalueTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputParadefaultValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputParacurrentValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputParadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskOutputBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_taskInputInNeed = new System.Windows.Forms.DataGridView();
            this.inputParamodelnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputParanameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputParavalueTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputParadefaultValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputParacurrentValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputParadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskInputBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taskOutputInNeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskOutputBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taskInputInNeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskInputBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thematicOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_ThematicOrderStatus);
            this.groupBox2.Controls.Add(this.bt_addToTaskQueue);
            this.groupBox2.Controls.Add(this.dgv_taskOutputInNeed);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dgv_taskInputInNeed);
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
            this.groupBox2.Text = "任务订单信息";
            // 
            // lb_ThematicOrderStatus
            // 
            this.lb_ThematicOrderStatus.AutoSize = true;
            this.lb_ThematicOrderStatus.Location = new System.Drawing.Point(375, 310);
            this.lb_ThematicOrderStatus.Name = "lb_ThematicOrderStatus";
            this.lb_ThematicOrderStatus.Size = new System.Drawing.Size(0, 12);
            this.lb_ThematicOrderStatus.TabIndex = 29;
            // 
            // bt_addToTaskQueue
            // 
            this.bt_addToTaskQueue.Location = new System.Drawing.Point(722, 300);
            this.bt_addToTaskQueue.Margin = new System.Windows.Forms.Padding(4);
            this.bt_addToTaskQueue.Name = "bt_addToTaskQueue";
            this.bt_addToTaskQueue.Size = new System.Drawing.Size(88, 33);
            this.bt_addToTaskQueue.TabIndex = 21;
            this.bt_addToTaskQueue.Text = "提交任务配置";
            this.bt_addToTaskQueue.UseVisualStyleBackColor = true;
            this.bt_addToTaskQueue.Click += new System.EventHandler(this.bt_updateTaskConfig_Click_1);
            // 
            // dgv_taskOutputInNeed
            // 
            this.dgv_taskOutputInNeed.AutoGenerateColumns = false;
            this.dgv_taskOutputInNeed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_taskOutputInNeed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.outputParamodelnameDataGridViewTextBoxColumn,
            this.outputParanameDataGridViewTextBoxColumn,
            this.outputParavalueTypeDataGridViewTextBoxColumn,
            this.outputParadefaultValueDataGridViewTextBoxColumn,
            this.outputParacurrentValueDataGridViewTextBoxColumn,
            this.outputParadesDataGridViewTextBoxColumn});
            this.dgv_taskOutputInNeed.DataSource = this.taskOutputBindingSource;
            this.dgv_taskOutputInNeed.Location = new System.Drawing.Point(349, 170);
            this.dgv_taskOutputInNeed.Name = "dgv_taskOutputInNeed";
            this.dgv_taskOutputInNeed.RowTemplate.Height = 23;
            this.dgv_taskOutputInNeed.Size = new System.Drawing.Size(787, 115);
            this.dgv_taskOutputInNeed.TabIndex = 20;
            // 
            // outputParamodelnameDataGridViewTextBoxColumn
            // 
            this.outputParamodelnameDataGridViewTextBoxColumn.DataPropertyName = "OutputPara_model_name";
            this.outputParamodelnameDataGridViewTextBoxColumn.HeaderText = "所属产品名称";
            this.outputParamodelnameDataGridViewTextBoxColumn.Name = "outputParamodelnameDataGridViewTextBoxColumn";
            this.outputParamodelnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // outputParanameDataGridViewTextBoxColumn
            // 
            this.outputParanameDataGridViewTextBoxColumn.DataPropertyName = "OutputPara_name";
            this.outputParanameDataGridViewTextBoxColumn.HeaderText = "输出参数名称";
            this.outputParanameDataGridViewTextBoxColumn.Name = "outputParanameDataGridViewTextBoxColumn";
            this.outputParanameDataGridViewTextBoxColumn.Width = 150;
            // 
            // outputParavalueTypeDataGridViewTextBoxColumn
            // 
            this.outputParavalueTypeDataGridViewTextBoxColumn.DataPropertyName = "OutputPara_valueType";
            this.outputParavalueTypeDataGridViewTextBoxColumn.HeaderText = "参数类型";
            this.outputParavalueTypeDataGridViewTextBoxColumn.Name = "outputParavalueTypeDataGridViewTextBoxColumn";
            // 
            // outputParadefaultValueDataGridViewTextBoxColumn
            // 
            this.outputParadefaultValueDataGridViewTextBoxColumn.DataPropertyName = "OutputPara_defaultValue";
            this.outputParadefaultValueDataGridViewTextBoxColumn.HeaderText = "默认值";
            this.outputParadefaultValueDataGridViewTextBoxColumn.Name = "outputParadefaultValueDataGridViewTextBoxColumn";
            // 
            // outputParacurrentValueDataGridViewTextBoxColumn
            // 
            this.outputParacurrentValueDataGridViewTextBoxColumn.DataPropertyName = "OutputPara_currentValue";
            this.outputParacurrentValueDataGridViewTextBoxColumn.HeaderText = "当前值";
            this.outputParacurrentValueDataGridViewTextBoxColumn.Name = "outputParacurrentValueDataGridViewTextBoxColumn";
            // 
            // outputParadesDataGridViewTextBoxColumn
            // 
            this.outputParadesDataGridViewTextBoxColumn.DataPropertyName = "OutputPara_des";
            this.outputParadesDataGridViewTextBoxColumn.HeaderText = "参数描述";
            this.outputParadesDataGridViewTextBoxColumn.Name = "outputParadesDataGridViewTextBoxColumn";
            this.outputParadesDataGridViewTextBoxColumn.Width = 300;
            // 
            // taskOutputBindingSource
            // 
            this.taskOutputBindingSource.DataSource = typeof(OrderManagement.Model.OutputParameter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(284, 170);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 19;
            this.label12.Text = "任务输出：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(284, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "任务输入：";
            // 
            // dgv_taskInputInNeed
            // 
            this.dgv_taskInputInNeed.AutoGenerateColumns = false;
            this.dgv_taskInputInNeed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_taskInputInNeed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inputParamodelnameDataGridViewTextBoxColumn,
            this.inputParanameDataGridViewTextBoxColumn,
            this.inputParavalueTypeDataGridViewTextBoxColumn,
            this.inputParadefaultValueDataGridViewTextBoxColumn,
            this.inputParacurrentValueDataGridViewTextBoxColumn,
            this.inputParadesDataGridViewTextBoxColumn});
            this.dgv_taskInputInNeed.DataSource = this.taskInputBindingSource;
            this.dgv_taskInputInNeed.Location = new System.Drawing.Point(349, 31);
            this.dgv_taskInputInNeed.Name = "dgv_taskInputInNeed";
            this.dgv_taskInputInNeed.RowTemplate.Height = 23;
            this.dgv_taskInputInNeed.Size = new System.Drawing.Size(787, 116);
            this.dgv_taskInputInNeed.TabIndex = 17;
            // 
            // inputParamodelnameDataGridViewTextBoxColumn
            // 
            this.inputParamodelnameDataGridViewTextBoxColumn.DataPropertyName = "InputPara_model_name";
            this.inputParamodelnameDataGridViewTextBoxColumn.HeaderText = "所属产品名称";
            this.inputParamodelnameDataGridViewTextBoxColumn.Name = "inputParamodelnameDataGridViewTextBoxColumn";
            this.inputParamodelnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // inputParanameDataGridViewTextBoxColumn
            // 
            this.inputParanameDataGridViewTextBoxColumn.DataPropertyName = "InputPara_name";
            this.inputParanameDataGridViewTextBoxColumn.HeaderText = "输入参数名称";
            this.inputParanameDataGridViewTextBoxColumn.Name = "inputParanameDataGridViewTextBoxColumn";
            this.inputParanameDataGridViewTextBoxColumn.Width = 150;
            // 
            // inputParavalueTypeDataGridViewTextBoxColumn
            // 
            this.inputParavalueTypeDataGridViewTextBoxColumn.DataPropertyName = "InputPara_valueType";
            this.inputParavalueTypeDataGridViewTextBoxColumn.HeaderText = "参数类型";
            this.inputParavalueTypeDataGridViewTextBoxColumn.Name = "inputParavalueTypeDataGridViewTextBoxColumn";
            // 
            // inputParadefaultValueDataGridViewTextBoxColumn
            // 
            this.inputParadefaultValueDataGridViewTextBoxColumn.DataPropertyName = "InputPara_defaultValue";
            this.inputParadefaultValueDataGridViewTextBoxColumn.HeaderText = "默认值";
            this.inputParadefaultValueDataGridViewTextBoxColumn.Name = "inputParadefaultValueDataGridViewTextBoxColumn";
            // 
            // inputParacurrentValueDataGridViewTextBoxColumn
            // 
            this.inputParacurrentValueDataGridViewTextBoxColumn.DataPropertyName = "InputPara_currentValue";
            this.inputParacurrentValueDataGridViewTextBoxColumn.HeaderText = "当前值";
            this.inputParacurrentValueDataGridViewTextBoxColumn.Name = "inputParacurrentValueDataGridViewTextBoxColumn";
            // 
            // inputParadesDataGridViewTextBoxColumn
            // 
            this.inputParadesDataGridViewTextBoxColumn.DataPropertyName = "InputPara_des";
            this.inputParadesDataGridViewTextBoxColumn.HeaderText = "参数说明";
            this.inputParadesDataGridViewTextBoxColumn.Name = "inputParadesDataGridViewTextBoxColumn";
            this.inputParadesDataGridViewTextBoxColumn.Width = 300;
            // 
            // taskInputBindingSource
            // 
            this.taskInputBindingSource.DataSource = typeof(OrderManagement.Model.InputParameter);
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
            // TaskConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 374);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "TaskConfigForm";
            this.ShowIcon = false;
            this.Text = "任务信息配置";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taskOutputInNeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskOutputBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taskInputInNeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskInputBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thematicOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void cb_detailedProductName_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void bt_addToTaskQueue_Click_1(object sender, System.EventArgs e)
        {

        }

        private void bt_MapSelection_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_addToTaskQueue;
        private System.Windows.Forms.DataGridView dgv_taskOutputInNeed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_taskInputInNeed;
        private System.Windows.Forms.BindingSource taskInputBindingSource;
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
        private System.Windows.Forms.BindingSource taskOutputBindingSource;
        private System.Windows.Forms.Label lb_ThematicOrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputParamodelnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputParanameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputParavalueTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputParadefaultValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputParacurrentValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputParadesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputParamodelnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputParanameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputParavalueTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputParadefaultValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputParacurrentValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputParadesDataGridViewTextBoxColumn;




    }
}