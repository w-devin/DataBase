﻿namespace Database
{
    partial class inquire
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 96);
            this.button1.TabIndex = 0;
            this.button1.Text = "空闲房间";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 96);
            this.button2.TabIndex = 1;
            this.button2.Text = "已预定房间";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(541, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 96);
            this.button3.TabIndex = 2;
            this.button3.Text = "已居住房间";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(33, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 96);
            this.button4.TabIndex = 4;
            this.button4.Text = "所有房间";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(33, 182);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 96);
            this.button5.TabIndex = 5;
            this.button5.Text = "物件价格";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(205, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(146, 96);
            this.button6.TabIndex = 6;
            this.button6.Text = " 房间标准";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(375, 182);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(146, 96);
            this.button7.TabIndex = 7;
            this.button7.Text = "物件损坏记录";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(541, 182);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(146, 96);
            this.button8.TabIndex = 8;
            this.button8.Text = "账目查询";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // inquire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 386);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "inquire";
            this.Text = "房间查询";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}