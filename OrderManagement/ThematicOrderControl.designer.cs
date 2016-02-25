using System.Windows.Forms;
namespace OrderManagement
{
    partial class ThematicOrderControl
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
            this.dgv_thematicOrder = new System.Windows.Forms.DataGridView();
            this.cms_rightButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_retriveOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englishNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coverScopeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isLocalOrderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isInDataBaseDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.thematicOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thematicOrder)).BeginInit();
            this.cms_rightButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thematicOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_thematicOrder
            // 
            this.dgv_thematicOrder.AutoGenerateColumns = false;
            this.dgv_thematicOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_thematicOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_thematicOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_thematicOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thematicOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderidDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn,
            this.englishNameDataGridViewTextBoxColumn,
            this.coverScopeDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.isLocalOrderDataGridViewCheckBoxColumn,
            this.isInDataBaseDataGridViewCheckBoxColumn});
            this.dgv_thematicOrder.DataSource = this.thematicOrderBindingSource;
            this.dgv_thematicOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_thematicOrder.Location = new System.Drawing.Point(0, 0);
            this.dgv_thematicOrder.Name = "dgv_thematicOrder";
            this.dgv_thematicOrder.RowTemplate.Height = 23;
            this.dgv_thematicOrder.Size = new System.Drawing.Size(1340, 234);
            this.dgv_thematicOrder.TabIndex = 0;
            this.dgv_thematicOrder.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_thematicOrder_CellMouseDown);
            this.dgv_thematicOrder.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_thematicOrder_CellPainting);
            this.dgv_thematicOrder.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_thematicOrder_RowHeaderMouseClick);
            // 
            // cms_rightButton
            // 
            this.cms_rightButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_retriveOrder});
            this.cms_rightButton.Name = "cms_rightButton";
            this.cms_rightButton.Size = new System.Drawing.Size(123, 26);
            // 
            // tsmi_retriveOrder
            // 
            this.tsmi_retriveOrder.Name = "tsmi_retriveOrder";
            this.tsmi_retriveOrder.Size = new System.Drawing.Size(122, 22);
            this.tsmi_retriveOrder.Text = "解析订单";
            this.tsmi_retriveOrder.Click += new System.EventHandler(this.tsmi_retriveOrder_Click);
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
            // englishNameDataGridViewTextBoxColumn
            // 
            this.englishNameDataGridViewTextBoxColumn.DataPropertyName = "EnglishName";
            this.englishNameDataGridViewTextBoxColumn.HeaderText = "产品简称";
            this.englishNameDataGridViewTextBoxColumn.Name = "englishNameDataGridViewTextBoxColumn";
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
            // isLocalOrderDataGridViewCheckBoxColumn
            // 
            this.isLocalOrderDataGridViewCheckBoxColumn.DataPropertyName = "IsLocalOrder";
            this.isLocalOrderDataGridViewCheckBoxColumn.HeaderText = "是否为本地订单";
            this.isLocalOrderDataGridViewCheckBoxColumn.Name = "isLocalOrderDataGridViewCheckBoxColumn";
            // 
            // isInDataBaseDataGridViewCheckBoxColumn
            // 
            this.isInDataBaseDataGridViewCheckBoxColumn.DataPropertyName = "IsInDataBase";
            this.isInDataBaseDataGridViewCheckBoxColumn.HeaderText = "是否已在数据库中";
            this.isInDataBaseDataGridViewCheckBoxColumn.Name = "isInDataBaseDataGridViewCheckBoxColumn";
            // 
            // thematicOrderBindingSource
            // 
            this.thematicOrderBindingSource.DataSource = typeof(OrderManagement.Model.ThematicOrder);
            // 
            // ThematicOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_thematicOrder);
            this.Name = "ThematicOrderControl";
            this.Size = new System.Drawing.Size(1340, 234);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thematicOrder)).EndInit();
            this.cms_rightButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thematicOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_thematicOrder;
        private System.Windows.Forms.BindingSource thematicOrderBindingSource;
        private ContextMenuStrip cms_rightButton;
        private ToolStripMenuItem tsmi_retriveOrder;
        private DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn englishNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coverScopeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isLocalOrderDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isInDataBaseDataGridViewCheckBoxColumn;
    }
}
