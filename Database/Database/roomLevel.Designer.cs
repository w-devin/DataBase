namespace Database
{
    partial class roomLevel
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
            this.hotelMSDataSet5 = new Database.HotelMSDataSet5();
            this.房间标准BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.房间标准TableAdapter = new Database.HotelMSDataSet5TableAdapters.房间标准TableAdapter();
            this.等级DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.居住人数DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.每日花费DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.房间标准BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.等级DataGridViewTextBoxColumn,
            this.居住人数DataGridViewTextBoxColumn,
            this.每日花费DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.房间标准BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // hotelMSDataSet5
            // 
            this.hotelMSDataSet5.DataSetName = "HotelMSDataSet5";
            this.hotelMSDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 房间标准BindingSource
            // 
            this.房间标准BindingSource.DataMember = "房间标准";
            this.房间标准BindingSource.DataSource = this.hotelMSDataSet5;
            // 
            // 房间标准TableAdapter
            // 
            this.房间标准TableAdapter.ClearBeforeFill = true;
            // 
            // 等级DataGridViewTextBoxColumn
            // 
            this.等级DataGridViewTextBoxColumn.DataPropertyName = "等级";
            this.等级DataGridViewTextBoxColumn.HeaderText = "等级";
            this.等级DataGridViewTextBoxColumn.Name = "等级DataGridViewTextBoxColumn";
            // 
            // 居住人数DataGridViewTextBoxColumn
            // 
            this.居住人数DataGridViewTextBoxColumn.DataPropertyName = "居住人数";
            this.居住人数DataGridViewTextBoxColumn.HeaderText = "居住人数";
            this.居住人数DataGridViewTextBoxColumn.Name = "居住人数DataGridViewTextBoxColumn";
            // 
            // 每日花费DataGridViewTextBoxColumn
            // 
            this.每日花费DataGridViewTextBoxColumn.DataPropertyName = "每日花费";
            this.每日花费DataGridViewTextBoxColumn.HeaderText = "每日花费";
            this.每日花费DataGridViewTextBoxColumn.Name = "每日花费DataGridViewTextBoxColumn";
            // 
            // roomLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 386);
            this.Controls.Add(this.dataGridView1);
            this.Name = "roomLevel";
            this.Text = "房间标准";
            this.Load += new System.EventHandler(this.roomLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.房间标准BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelMSDataSet5 hotelMSDataSet5;
        private System.Windows.Forms.BindingSource 房间标准BindingSource;
        private HotelMSDataSet5TableAdapters.房间标准TableAdapter 房间标准TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 等级DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 居住人数DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 每日花费DataGridViewTextBoxColumn;
    }
}