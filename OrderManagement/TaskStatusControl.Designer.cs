namespace OrderManagement
{
    partial class TaskStatusControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvTaskStatus = new System.Windows.Forms.DataGridView();
            this.thematicIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isLastStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lastUpdateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nodeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nodeIpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thematicTaskStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thematicTaskStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTaskStatus
            // 
            this.dgvTaskStatus.AutoGenerateColumns = false;
            this.dgvTaskStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaskStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thematicIdDataGridViewTextBoxColumn,
            this.taskStatusDataGridViewTextBoxColumn,
            this.statusDesDataGridViewTextBoxColumn,
            this.isLastStatusDataGridViewCheckBoxColumn,
            this.lastUpdateTimeDataGridViewTextBoxColumn,
            this.nodeNameDataGridViewTextBoxColumn,
            this.nodeIpDataGridViewTextBoxColumn});
            this.dgvTaskStatus.DataSource = this.thematicTaskStatusBindingSource;
            this.dgvTaskStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaskStatus.Location = new System.Drawing.Point(0, 0);
            this.dgvTaskStatus.Name = "dgvTaskStatus";
            this.dgvTaskStatus.RowTemplate.Height = 23;
            this.dgvTaskStatus.Size = new System.Drawing.Size(969, 164);
            this.dgvTaskStatus.TabIndex = 0;
            this.dgvTaskStatus.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvTaskStatus_CellPainting);
            this.dgvTaskStatus.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTaskStatus_RowHeaderMouseClick);
            // 
            // thematicIdDataGridViewTextBoxColumn
            // 
            this.thematicIdDataGridViewTextBoxColumn.DataPropertyName = "ThematicId";
            this.thematicIdDataGridViewTextBoxColumn.HeaderText = "订单ID";
            this.thematicIdDataGridViewTextBoxColumn.Name = "thematicIdDataGridViewTextBoxColumn";
            this.thematicIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // taskStatusDataGridViewTextBoxColumn
            // 
            this.taskStatusDataGridViewTextBoxColumn.DataPropertyName = "TaskStatus";
            this.taskStatusDataGridViewTextBoxColumn.HeaderText = "任务状态";
            this.taskStatusDataGridViewTextBoxColumn.Name = "taskStatusDataGridViewTextBoxColumn";
            this.taskStatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDesDataGridViewTextBoxColumn
            // 
            this.statusDesDataGridViewTextBoxColumn.DataPropertyName = "StatusDes";
            this.statusDesDataGridViewTextBoxColumn.HeaderText = "状态描述";
            this.statusDesDataGridViewTextBoxColumn.Name = "statusDesDataGridViewTextBoxColumn";
            this.statusDesDataGridViewTextBoxColumn.Width = 400;
            // 
            // isLastStatusDataGridViewCheckBoxColumn
            // 
            this.isLastStatusDataGridViewCheckBoxColumn.DataPropertyName = "IsLastStatus";
            this.isLastStatusDataGridViewCheckBoxColumn.HeaderText = "是否最新状态";
            this.isLastStatusDataGridViewCheckBoxColumn.Name = "isLastStatusDataGridViewCheckBoxColumn";
            // 
            // lastUpdateTimeDataGridViewTextBoxColumn
            // 
            this.lastUpdateTimeDataGridViewTextBoxColumn.DataPropertyName = "LastUpdateTime";
            this.lastUpdateTimeDataGridViewTextBoxColumn.HeaderText = "最后更新时间";
            this.lastUpdateTimeDataGridViewTextBoxColumn.Name = "lastUpdateTimeDataGridViewTextBoxColumn";
            this.lastUpdateTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // nodeNameDataGridViewTextBoxColumn
            // 
            this.nodeNameDataGridViewTextBoxColumn.DataPropertyName = "NodeName";
            this.nodeNameDataGridViewTextBoxColumn.HeaderText = "生产节点名称";
            this.nodeNameDataGridViewTextBoxColumn.Name = "nodeNameDataGridViewTextBoxColumn";
            this.nodeNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // nodeIpDataGridViewTextBoxColumn
            // 
            this.nodeIpDataGridViewTextBoxColumn.DataPropertyName = "NodeIp";
            this.nodeIpDataGridViewTextBoxColumn.HeaderText = "生产节点IP";
            this.nodeIpDataGridViewTextBoxColumn.Name = "nodeIpDataGridViewTextBoxColumn";
            this.nodeIpDataGridViewTextBoxColumn.Width = 150;
            // 
            // thematicTaskStatusBindingSource
            // 
            this.thematicTaskStatusBindingSource.DataSource = typeof(OrderManagement.Model.ThematicTaskStatus);
            // 
            // TaskStatusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTaskStatus);
            this.Name = "TaskStatusControl";
            this.Size = new System.Drawing.Size(969, 164);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thematicTaskStatusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTaskStatus;
        private System.Windows.Forms.BindingSource thematicTaskStatusBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn thematicIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isLastStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodeIpDataGridViewTextBoxColumn;
    }
}
