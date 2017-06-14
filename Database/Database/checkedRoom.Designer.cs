namespace Database
{
    partial class checkedRoom
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
            this.hotelMSDataSet2 = new Database.HotelMSDataSet2();
            this.已预定房间BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.已预定房间TableAdapter = new Database.HotelMSDataSet2TableAdapters.已预定房间TableAdapter();
            this.房间号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房间标准DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.已预定房间BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.房间号DataGridViewTextBoxColumn,
            this.房间标准DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.已预定房间BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // hotelMSDataSet2
            // 
            this.hotelMSDataSet2.DataSetName = "HotelMSDataSet2";
            this.hotelMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 已预定房间BindingSource
            // 
            this.已预定房间BindingSource.DataMember = "已预定房间";
            this.已预定房间BindingSource.DataSource = this.hotelMSDataSet2;
            // 
            // 已预定房间TableAdapter
            // 
            this.已预定房间TableAdapter.ClearBeforeFill = true;
            // 
            // 房间号DataGridViewTextBoxColumn
            // 
            this.房间号DataGridViewTextBoxColumn.DataPropertyName = "房间号";
            this.房间号DataGridViewTextBoxColumn.HeaderText = "房间号";
            this.房间号DataGridViewTextBoxColumn.Name = "房间号DataGridViewTextBoxColumn";
            // 
            // 房间标准DataGridViewTextBoxColumn
            // 
            this.房间标准DataGridViewTextBoxColumn.DataPropertyName = "房间标准";
            this.房间标准DataGridViewTextBoxColumn.HeaderText = "房间标准";
            this.房间标准DataGridViewTextBoxColumn.Name = "房间标准DataGridViewTextBoxColumn";
            // 
            // checkedRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 397);
            this.Controls.Add(this.dataGridView1);
            this.Name = "checkedRoom";
            this.Text = "已预定房间";
            this.Load += new System.EventHandler(this.checkedRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.已预定房间BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelMSDataSet2 hotelMSDataSet2;
        private System.Windows.Forms.BindingSource 已预定房间BindingSource;
        private HotelMSDataSet2TableAdapters.已预定房间TableAdapter 已预定房间TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房间号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房间标准DataGridViewTextBoxColumn;
    }
}