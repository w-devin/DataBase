namespace Database
{
    partial class Prices
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
            this.hotelMSDataSet4 = new Database.HotelMSDataSet4();
            this.物件价格BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.物件价格TableAdapter = new Database.HotelMSDataSet4TableAdapters.物件价格TableAdapter();
            this.名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.价格DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.物件价格BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.名称DataGridViewTextBoxColumn,
            this.价格DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.物件价格BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 396);
            this.dataGridView1.TabIndex = 0;
            // 
            // hotelMSDataSet4
            // 
            this.hotelMSDataSet4.DataSetName = "HotelMSDataSet4";
            this.hotelMSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 物件价格BindingSource
            // 
            this.物件价格BindingSource.DataMember = "物件价格";
            this.物件价格BindingSource.DataSource = this.hotelMSDataSet4;
            // 
            // 物件价格TableAdapter
            // 
            this.物件价格TableAdapter.ClearBeforeFill = true;
            // 
            // 名称DataGridViewTextBoxColumn
            // 
            this.名称DataGridViewTextBoxColumn.DataPropertyName = "名称";
            this.名称DataGridViewTextBoxColumn.HeaderText = "名称";
            this.名称DataGridViewTextBoxColumn.Name = "名称DataGridViewTextBoxColumn";
            // 
            // 价格DataGridViewTextBoxColumn
            // 
            this.价格DataGridViewTextBoxColumn.DataPropertyName = "价格";
            this.价格DataGridViewTextBoxColumn.HeaderText = "价格";
            this.价格DataGridViewTextBoxColumn.Name = "价格DataGridViewTextBoxColumn";
            // 
            // Prices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 395);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Prices";
            this.Text = "物件价格";
            this.Load += new System.EventHandler(this.Prices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.物件价格BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelMSDataSet4 hotelMSDataSet4;
        private System.Windows.Forms.BindingSource 物件价格BindingSource;
        private HotelMSDataSet4TableAdapters.物件价格TableAdapter 物件价格TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 价格DataGridViewTextBoxColumn;
    }
}