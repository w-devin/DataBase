namespace Database
{
    partial class allRooms
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
            this.hotelMSDataSet1 = new Database.HotelMSDataSet1();
            this.所有房间BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.所有房间TableAdapter = new Database.HotelMSDataSet1TableAdapters.所有房间TableAdapter();
            this.房间号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房间标准DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.已预定DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.已居住DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.所有房间BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.房间号DataGridViewTextBoxColumn,
            this.房间标准DataGridViewTextBoxColumn,
            this.已预定DataGridViewTextBoxColumn,
            this.已居住DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.所有房间BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // hotelMSDataSet1
            // 
            this.hotelMSDataSet1.DataSetName = "HotelMSDataSet1";
            this.hotelMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 所有房间BindingSource
            // 
            this.所有房间BindingSource.DataMember = "所有房间";
            this.所有房间BindingSource.DataSource = this.hotelMSDataSet1;
            // 
            // 所有房间TableAdapter
            // 
            this.所有房间TableAdapter.ClearBeforeFill = true;
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
            // 已预定DataGridViewTextBoxColumn
            // 
            this.已预定DataGridViewTextBoxColumn.DataPropertyName = "已预定";
            this.已预定DataGridViewTextBoxColumn.HeaderText = "已预定";
            this.已预定DataGridViewTextBoxColumn.Name = "已预定DataGridViewTextBoxColumn";
            // 
            // 已居住DataGridViewTextBoxColumn
            // 
            this.已居住DataGridViewTextBoxColumn.DataPropertyName = "已居住";
            this.已居住DataGridViewTextBoxColumn.HeaderText = "已居住";
            this.已居住DataGridViewTextBoxColumn.Name = "已居住DataGridViewTextBoxColumn";
            // 
            // allRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 428);
            this.Controls.Add(this.dataGridView1);
            this.Name = "allRooms";
            this.Text = "所有房间";
            this.Load += new System.EventHandler(this.allRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.所有房间BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelMSDataSet1 hotelMSDataSet1;
        private System.Windows.Forms.BindingSource 所有房间BindingSource;
        private HotelMSDataSet1TableAdapters.所有房间TableAdapter 所有房间TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房间号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房间标准DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 已预定DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 已居住DataGridViewTextBoxColumn;
    }
}