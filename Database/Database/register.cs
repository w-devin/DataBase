using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Database
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = textBox1.Text;
            string name = textBox2.Text;
            string sex = textBox3.Text;
            string tel = textBox4.Text;

            string connectString = "Data Source = iDevin.cn; Initial Catalog = HotelMS; Persist Security Info = True; User ID = sa; Password = wyw.19961019";

            SqlConnection sqlCnt = new SqlConnection(connectString);
            sqlCnt.Open();

            SqlCommand cmd = sqlCnt.CreateCommand();

            string strcmd = "insert into Customers values('" + ID + "', '" + name + "', '" + sex + "', '" + tel + "');";

            //MessageBox.Show(strcmd);

            cmd.CommandText = strcmd;

            int succNum = cmd.ExecuteNonQuery();

            if(succNum == 0)
            {
                MessageBox.Show("注册失败, 请检查填写信息");
            }
            else
            {
                MessageBox.Show("注册成功");
                this.Close();
            }
        }
    }
}
