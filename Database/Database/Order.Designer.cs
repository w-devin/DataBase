namespace Database
{
    partial class Order
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.空闲房间TableAdapter1 = new Database.HotelMSDataSetTableAdapters.空闲房间TableAdapter();
            this.hotelMSDataSet = new Database.HotelMSDataSet();
            this.hotelMSDataSet1 = new Database.HotelMSDataSet1();
            this.hotelMSDataSet4 = new Database.HotelMSDataSet4();
            this.hotelMSDataSet2 = new Database.HotelMSDataSet2();
            this.hotelMSDataSet8 = new Database.HotelMSDataSet8();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.空闲房间BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.所有房间BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.所有房间TableAdapter = new Database.HotelMSDataSet1TableAdapters.所有房间TableAdapter();
            this.hotelMSDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.已预定房间BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.已预定房间TableAdapter = new Database.HotelMSDataSet2TableAdapters.已预定房间TableAdapter();
            this.房间号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房间标准DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.空闲房间BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.空闲房间TableAdapter = new Database.HotelMSDataSet8TableAdapters.空闲房间TableAdapter();
            this.hotelMSDataSet9 = new Database.HotelMSDataSet9();
            this.空闲房间BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.空闲房间TableAdapter2 = new Database.HotelMSDataSet9TableAdapters.空闲房间TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.空闲房间BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.所有房间BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.已预定房间BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.空闲房间BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.空闲房间BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "身份证号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "房间号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "入住时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "离开时间";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(346, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(346, 144);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(347, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(346, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "预定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 空闲房间TableAdapter1
            // 
            this.空闲房间TableAdapter1.ClearBeforeFill = true;
            // 
            // hotelMSDataSet
            // 
            this.hotelMSDataSet.DataSetName = "HotelMSDataSet";
            this.hotelMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelMSDataSet1
            // 
            this.hotelMSDataSet1.DataSetName = "HotelMSDataSet1";
            this.hotelMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelMSDataSet4
            // 
            this.hotelMSDataSet4.DataSetName = "HotelMSDataSet4";
            this.hotelMSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelMSDataSet2
            // 
            this.hotelMSDataSet2.DataSetName = "HotelMSDataSet2";
            this.hotelMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelMSDataSet8
            // 
            this.hotelMSDataSet8.DataSetName = "HotelMSDataSet8";
            this.hotelMSDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.房间号DataGridViewTextBoxColumn,
            this.房间标准DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.空闲房间BindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(243, 229);
            this.dataGridView1.TabIndex = 9;
            // 
            // 空闲房间BindingSource
            // 
            this.空闲房间BindingSource.DataMember = "空闲房间";
            this.空闲房间BindingSource.DataSource = this.hotelMSDataSet;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "可选房间";
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
            // hotelMSDataSet4BindingSource
            // 
            this.hotelMSDataSet4BindingSource.DataSource = this.hotelMSDataSet4;
            this.hotelMSDataSet4BindingSource.Position = 0;
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
            this.房间号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 房间标准DataGridViewTextBoxColumn
            // 
            this.房间标准DataGridViewTextBoxColumn.DataPropertyName = "房间标准";
            this.房间标准DataGridViewTextBoxColumn.HeaderText = "房间标准";
            this.房间标准DataGridViewTextBoxColumn.Name = "房间标准DataGridViewTextBoxColumn";
            this.房间标准DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 空闲房间BindingSource1
            // 
            this.空闲房间BindingSource1.DataMember = "空闲房间";
            this.空闲房间BindingSource1.DataSource = this.hotelMSDataSet8;
            // 
            // 空闲房间TableAdapter
            // 
            this.空闲房间TableAdapter.ClearBeforeFill = true;
            // 
            // hotelMSDataSet9
            // 
            this.hotelMSDataSet9.DataSetName = "HotelMSDataSet9";
            this.hotelMSDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 空闲房间BindingSource2
            // 
            this.空闲房间BindingSource2.DataMember = "空闲房间";
            this.空闲房间BindingSource2.DataSource = this.hotelMSDataSet9;
            // 
            // 空闲房间TableAdapter2
            // 
            this.空闲房间TableAdapter2.ClearBeforeFill = true;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 286);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Order";
            this.Text = "预定";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.空闲房间BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.所有房间BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.已预定房间BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.空闲房间BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelMSDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.空闲房间BindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private HotelMSDataSetTableAdapters.空闲房间TableAdapter 空闲房间TableAdapter1;
        private HotelMSDataSet hotelMSDataSet;
        private HotelMSDataSet1 hotelMSDataSet1;
        private HotelMSDataSet4 hotelMSDataSet4;
        private HotelMSDataSet2 hotelMSDataSet2;
        private HotelMSDataSet8 hotelMSDataSet8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房间号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房间标准DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 空闲房间BindingSource1;
        private System.Windows.Forms.BindingSource 空闲房间BindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource 所有房间BindingSource;
        private HotelMSDataSet1TableAdapters.所有房间TableAdapter 所有房间TableAdapter;
        private System.Windows.Forms.BindingSource hotelMSDataSet4BindingSource;
        private System.Windows.Forms.BindingSource 已预定房间BindingSource;
        private HotelMSDataSet2TableAdapters.已预定房间TableAdapter 已预定房间TableAdapter;
        private HotelMSDataSet8TableAdapters.空闲房间TableAdapter 空闲房间TableAdapter;
        private HotelMSDataSet9 hotelMSDataSet9;
        private System.Windows.Forms.BindingSource 空闲房间BindingSource2;
        private HotelMSDataSet9TableAdapters.空闲房间TableAdapter 空闲房间TableAdapter2;
    }
}