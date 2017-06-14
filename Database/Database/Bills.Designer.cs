namespace Database
{
    partial class Bills
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
            this.顾客姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.身份证号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系方式DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房间号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入住时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.退房时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.居住花费DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.损坏赔偿DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总共支付DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.账目查询BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelMSDataSet7 = new Database.HotelMSDataSet7();
            this.账目查询TableAdapter = new Database.HotelMSDataSet7TableAdapters.账目查询TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.账目查询BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.顾客姓名DataGridViewTextBoxColumn,
            this.身份证号DataGridViewTextBoxColumn,
            this.性别DataGridViewTextBoxColumn,
            this.联系方式DataGridViewTextBoxColumn,
            this.房间号DataGridViewTextBoxColumn,
            this.入住时间DataGridViewTextBoxColumn,
            this.退房时间DataGridViewTextBoxColumn,
            this.居住花费DataGridViewTextBoxColumn,
            this.损坏赔偿DataGridViewTextBoxColumn,
            this.总共支付DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.账目查询BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1045, 400);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 顾客姓名DataGridViewTextBoxColumn
            // 
            this.顾客姓名DataGridViewTextBoxColumn.DataPropertyName = "顾客姓名";
            this.顾客姓名DataGridViewTextBoxColumn.HeaderText = "顾客姓名";
            this.顾客姓名DataGridViewTextBoxColumn.Name = "顾客姓名DataGridViewTextBoxColumn";
            // 
            // 身份证号DataGridViewTextBoxColumn
            // 
            this.身份证号DataGridViewTextBoxColumn.DataPropertyName = "身份证号";
            this.身份证号DataGridViewTextBoxColumn.HeaderText = "身份证号";
            this.身份证号DataGridViewTextBoxColumn.Name = "身份证号DataGridViewTextBoxColumn";
            // 
            // 性别DataGridViewTextBoxColumn
            // 
            this.性别DataGridViewTextBoxColumn.DataPropertyName = "性别";
            this.性别DataGridViewTextBoxColumn.HeaderText = "性别";
            this.性别DataGridViewTextBoxColumn.Name = "性别DataGridViewTextBoxColumn";
            // 
            // 联系方式DataGridViewTextBoxColumn
            // 
            this.联系方式DataGridViewTextBoxColumn.DataPropertyName = "联系方式";
            this.联系方式DataGridViewTextBoxColumn.HeaderText = "联系方式";
            this.联系方式DataGridViewTextBoxColumn.Name = "联系方式DataGridViewTextBoxColumn";
            // 
            // 房间号DataGridViewTextBoxColumn
            // 
            this.房间号DataGridViewTextBoxColumn.DataPropertyName = "房间号";
            this.房间号DataGridViewTextBoxColumn.HeaderText = "房间号";
            this.房间号DataGridViewTextBoxColumn.Name = "房间号DataGridViewTextBoxColumn";
            // 
            // 入住时间DataGridViewTextBoxColumn
            // 
            this.入住时间DataGridViewTextBoxColumn.DataPropertyName = "入住时间";
            this.入住时间DataGridViewTextBoxColumn.HeaderText = "入住时间";
            this.入住时间DataGridViewTextBoxColumn.Name = "入住时间DataGridViewTextBoxColumn";
            // 
            // 退房时间DataGridViewTextBoxColumn
            // 
            this.退房时间DataGridViewTextBoxColumn.DataPropertyName = "退房时间";
            this.退房时间DataGridViewTextBoxColumn.HeaderText = "退房时间";
            this.退房时间DataGridViewTextBoxColumn.Name = "退房时间DataGridViewTextBoxColumn";
            // 
            // 居住花费DataGridViewTextBoxColumn
            // 
            this.居住花费DataGridViewTextBoxColumn.DataPropertyName = "居住花费";
            this.居住花费DataGridViewTextBoxColumn.HeaderText = "居住花费";
            this.居住花费DataGridViewTextBoxColumn.Name = "居住花费DataGridViewTextBoxColumn";
            // 
            // 损坏赔偿DataGridViewTextBoxColumn
            // 
            this.损坏赔偿DataGridViewTextBoxColumn.DataPropertyName = "损坏赔偿";
            this.损坏赔偿DataGridViewTextBoxColumn.HeaderText = "损坏赔偿";
            this.损坏赔偿DataGridViewTextBoxColumn.Name = "损坏赔偿DataGridViewTextBoxColumn";
            // 
            // 总共支付DataGridViewTextBoxColumn
            // 
            this.总共支付DataGridViewTextBoxColumn.DataPropertyName = "总共支付";
            this.总共支付DataGridViewTextBoxColumn.HeaderText = "总共支付";
            this.总共支付DataGridViewTextBoxColumn.Name = "总共支付DataGridViewTextBoxColumn";
            // 
            // 账目查询BindingSource
            // 
            this.账目查询BindingSource.DataMember = "账目查询";
            this.账目查询BindingSource.DataSource = this.hotelMSDataSet7;
            // 
            // hotelMSDataSet7
            // 
            this.hotelMSDataSet7.DataSetName = "HotelMSDataSet7";
            this.hotelMSDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 账目查询TableAdapter
            // 
            this.账目查询TableAdapter.ClearBeforeFill = true;
            // 
            // Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 400);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Bills";
            this.Text = "账目查询";
            this.Load += new System.EventHandler(this.Bills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.账目查询BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelMSDataSet7 hotelMSDataSet7;
        private System.Windows.Forms.BindingSource 账目查询BindingSource;
        private HotelMSDataSet7TableAdapters.账目查询TableAdapter 账目查询TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 顾客姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 身份证号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系方式DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房间号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入住时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 退房时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 居住花费DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 损坏赔偿DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总共支付DataGridViewTextBoxColumn;
    }
}