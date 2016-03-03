namespace OrderManagement.CustomeChart
{
    partial class ServerMonitorControl
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.dgvServerNode = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCurrentNode = new System.Windows.Forms.Label();
            this.nodeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nodeIpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverNodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serverNodeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServerNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverNodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverNodeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 167);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(507, 212);
            this.webBrowser1.TabIndex = 0;
            // 
            // dgvServerNode
            // 
            this.dgvServerNode.AutoGenerateColumns = false;
            this.dgvServerNode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServerNode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nodeNameDataGridViewTextBoxColumn,
            this.nodeIpDataGridViewTextBoxColumn,
            this.portDataGridViewTextBoxColumn,
            this.TaskNum,
            this.statusDataGridViewTextBoxColumn});
            this.dgvServerNode.DataSource = this.serverNodeBindingSource;
            this.dgvServerNode.Location = new System.Drawing.Point(3, 3);
            this.dgvServerNode.Name = "dgvServerNode";
            this.dgvServerNode.RowTemplate.Height = 23;
            this.dgvServerNode.Size = new System.Drawing.Size(535, 132);
            this.dgvServerNode.TabIndex = 1;
            this.dgvServerNode.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvServerNode_CellPainting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // TaskNum
            // 
            this.TaskNum.DataPropertyName = "TaskNum";
            this.TaskNum.HeaderText = "任务数量";
            this.TaskNum.Name = "TaskNum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "当前显示节点：";
            // 
            // lbCurrentNode
            // 
            this.lbCurrentNode.AutoSize = true;
            this.lbCurrentNode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCurrentNode.Location = new System.Drawing.Point(119, 143);
            this.lbCurrentNode.Name = "lbCurrentNode";
            this.lbCurrentNode.Size = new System.Drawing.Size(0, 21);
            this.lbCurrentNode.TabIndex = 3;
            // 
            // nodeNameDataGridViewTextBoxColumn
            // 
            this.nodeNameDataGridViewTextBoxColumn.DataPropertyName = "NodeName";
            this.nodeNameDataGridViewTextBoxColumn.HeaderText = "节点名称";
            this.nodeNameDataGridViewTextBoxColumn.Name = "nodeNameDataGridViewTextBoxColumn";
            // 
            // nodeIpDataGridViewTextBoxColumn
            // 
            this.nodeIpDataGridViewTextBoxColumn.DataPropertyName = "NodeIp";
            this.nodeIpDataGridViewTextBoxColumn.HeaderText = "节点地址";
            this.nodeIpDataGridViewTextBoxColumn.Name = "nodeIpDataGridViewTextBoxColumn";
            // 
            // portDataGridViewTextBoxColumn
            // 
            this.portDataGridViewTextBoxColumn.DataPropertyName = "port";
            this.portDataGridViewTextBoxColumn.HeaderText = "节点端口";
            this.portDataGridViewTextBoxColumn.Name = "portDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "节点状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // serverNodeBindingSource
            // 
            this.serverNodeBindingSource.DataSource = typeof(OrderManagement.Model.ServerNode);
            // 
            // serverNodeBindingSource1
            // 
            this.serverNodeBindingSource1.DataSource = typeof(OrderManagement.Model.ServerNode);
            // 
            // ServerMonitorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCurrentNode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvServerNode);
            this.Controls.Add(this.webBrowser1);
            this.Name = "ServerMonitorControl";
            this.Size = new System.Drawing.Size(538, 414);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServerNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverNodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverNodeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.DataGridView dgvServerNode;
        private System.Windows.Forms.BindingSource serverNodeBindingSource;
        private System.Windows.Forms.BindingSource serverNodeBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodeIpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCurrentNode;
    }
}
