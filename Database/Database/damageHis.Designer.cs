namespace Database
{
    partial class damageHis
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hotelMSDataSet6 = new Database.HotelMSDataSet6();
            this.物件损坏记录BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.物件损坏记录TableAdapter = new Database.HotelMSDataSet6TableAdapters.物件损坏记录TableAdapter();
            this.房间号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物品名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.损坏数量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.赔偿金额DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物件损坏记录BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.房间号DataGridViewTextBoxColumn,
            this.物品名称DataGridViewTextBoxColumn,
            this.损坏数量DataGridViewTextBoxColumn,
            this.赔偿金额DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.物件损坏记录BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 347);
            this.dataGridView1.TabIndex = 0;
            // 
            // hotelMSDataSet6
            // 
            this.hotelMSDataSet6.DataSetName = "HotelMSDataSet6";
            this.hotelMSDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 物件损坏记录BindingSource
            // 
            this.物件损坏记录BindingSource.DataMember = "物件损坏记录";
            this.物件损坏记录BindingSource.DataSource = this.hotelMSDataSet6;
            // 
            // 物件损坏记录TableAdapter
            // 
            this.物件损坏记录TableAdapter.ClearBeforeFill = true;
            // 
            // 房间号DataGridViewTextBoxColumn
            // 
            this.房间号DataGridViewTextBoxColumn.DataPropertyName = "房间号";
            this.房间号DataGridViewTextBoxColumn.HeaderText = "房间号";
            this.房间号DataGridViewTextBoxColumn.Name = "房间号DataGridViewTextBoxColumn";
            // 
            // 物品名称DataGridViewTextBoxColumn
            // 
            this.物品名称DataGridViewTextBoxColumn.DataPropertyName = "物品名称";
            this.物品名称DataGridViewTextBoxColumn.HeaderText = "物品名称";
            this.物品名称DataGridViewTextBoxColumn.Name = "物品名称DataGridViewTextBoxColumn";
            // 
            // 损坏数量DataGridViewTextBoxColumn
            // 
            this.损坏数量DataGridViewTextBoxColumn.DataPropertyName = "损坏数量";
            this.损坏数量DataGridViewTextBoxColumn.HeaderText = "损坏数量";
            this.损坏数量DataGridViewTextBoxColumn.Name = "损坏数量DataGridViewTextBoxColumn";
            // 
            // 赔偿金额DataGridViewTextBoxColumn
            // 
            this.赔偿金额DataGridViewTextBoxColumn.DataPropertyName = "赔偿金额";
            this.赔偿金额DataGridViewTextBoxColumn.HeaderText = "赔偿金额";
            this.赔偿金额DataGridViewTextBoxColumn.Name = "赔偿金额DataGridViewTextBoxColumn";
            // 
            // 物件损坏记录
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 349);
            this.Controls.Add(this.dataGridView1);
            this.Name = "物件损坏记录";
            this.Text = "物件损坏记录";
            this.Load += new System.EventHandler(this.物件损坏记录_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物件损坏记录BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelMSDataSet6 hotelMSDataSet6;
        private System.Windows.Forms.BindingSource 物件损坏记录BindingSource;
        private HotelMSDataSet6TableAdapters.物件损坏记录TableAdapter 物件损坏记录TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房间号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 损坏数量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 赔偿金额DataGridViewTextBoxColumn;
    }
}