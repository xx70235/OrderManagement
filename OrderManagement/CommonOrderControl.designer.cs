using System.Windows.Forms;
namespace OrderManagement
{
    partial class CommonOrderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_CommonOrder = new System.Windows.Forms.DataGridView();
            this.cms_rightButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mi_CommonOrderStatusUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_DataDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.commonOrderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.commonOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thematicOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coverScopeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CommonOrder)).BeginInit();
            this.cms_rightButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commonOrderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commonOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thematicOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_CommonOrder
            // 
            this.dgv_CommonOrder.AutoGenerateColumns = false;
            this.dgv_CommonOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CommonOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CommonOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_CommonOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CommonOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderidDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn,
            this.coverScopeDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.UpdateDate});
            this.dgv_CommonOrder.DataSource = this.commonOrderBindingSource1;
            this.dgv_CommonOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CommonOrder.Location = new System.Drawing.Point(0, 0);
            this.dgv_CommonOrder.Name = "dgv_CommonOrder";
            this.dgv_CommonOrder.RowTemplate.Height = 23;
            this.dgv_CommonOrder.Size = new System.Drawing.Size(1340, 234);
            this.dgv_CommonOrder.TabIndex = 0;
            this.dgv_CommonOrder.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_thematicOrder_CellMouseDown);
            this.dgv_CommonOrder.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_thematicOrder_CellPainting);
            this.dgv_CommonOrder.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CommonOrder_RowHeaderMouseClick);
            // 
            // cms_rightButton
            // 
            this.cms_rightButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_CommonOrderStatusUpdate,
            this.mi_DataDownload});
            this.cms_rightButton.Name = "cms_rightButton";
            this.cms_rightButton.Size = new System.Drawing.Size(147, 48);
            // 
            // mi_CommonOrderStatusUpdate
            // 
            this.mi_CommonOrderStatusUpdate.Name = "mi_CommonOrderStatusUpdate";
            this.mi_CommonOrderStatusUpdate.Size = new System.Drawing.Size(146, 22);
            this.mi_CommonOrderStatusUpdate.Text = "更新需求状态";
            this.mi_CommonOrderStatusUpdate.Click += new System.EventHandler(this.tsmi_retriveOrder_Click);
            // 
            // mi_DataDownload
            // 
            this.mi_DataDownload.Name = "mi_DataDownload";
            this.mi_DataDownload.Size = new System.Drawing.Size(146, 22);
            this.mi_DataDownload.Text = "下载数据";
            // 
            // commonOrderBindingSource1
            // 
            this.commonOrderBindingSource1.DataSource = typeof(OrderManagement.Model.CommonOrder);
            // 
            // commonOrderBindingSource
            // 
            this.commonOrderBindingSource.DataSource = typeof(OrderManagement.Model.CommonOrder);
            // 
            // thematicOrderBindingSource
            // 
            this.thematicOrderBindingSource.DataSource = typeof(OrderManagement.Model.ThematicOrder);
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "Orderid";
            this.orderidDataGridViewTextBoxColumn.HeaderText = "订单编号";
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
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
            this.productTypeDataGridViewTextBoxColumn.HeaderText = "产品类型";
            this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            // 
            // coverScopeDataGridViewTextBoxColumn
            // 
            this.coverScopeDataGridViewTextBoxColumn.DataPropertyName = "CoverScope";
            this.coverScopeDataGridViewTextBoxColumn.HeaderText = "覆盖范围";
            this.coverScopeDataGridViewTextBoxColumn.Name = "coverScopeDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "开始日期";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "结束日期";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "订购时间";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "订单状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // UpdateDate
            // 
            this.UpdateDate.DataPropertyName = "UpdateDate";
            this.UpdateDate.HeaderText = "状态更新时间";
            this.UpdateDate.Name = "UpdateDate";
            // 
            // CommonOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_CommonOrder);
            this.Name = "CommonOrderControl";
            this.Size = new System.Drawing.Size(1340, 234);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CommonOrder)).EndInit();
            this.cms_rightButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commonOrderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commonOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thematicOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_CommonOrder;
        private System.Windows.Forms.BindingSource thematicOrderBindingSource;
        private ContextMenuStrip cms_rightButton;
        private ToolStripMenuItem mi_CommonOrderStatusUpdate;
        private ToolStripMenuItem mi_DataDownload;
        private BindingSource commonOrderBindingSource;
        private BindingSource commonOrderBindingSource1;
        private DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coverScopeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn UpdateDate;
    }
}
