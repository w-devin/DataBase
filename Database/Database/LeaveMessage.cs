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
    public partial class LeaveMessage : Form
    {
        public LeaveMessage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string news = richTextBox1.Text;
            string name = textBox1.Text;
            string ID = null;

            string connectString = "Data Source = iDevin.cn; Initial Catalog = HotelMS; Persist Security Info = True; User ID = sa; Password = wyw.19961019";

            SqlConnection sqlCnt = new SqlConnection(connectString);
            sqlCnt.Open();

            SqlCommand cmd = sqlCnt.CreateCommand();

            string strcmd = "select name, ID from Customers where name='" + name + "';";

            cmd.CommandText = strcmd;
            SqlDataReader require = cmd.ExecuteReader();

            if (!require.Read())
            {
                MessageBox.Show("请以顾客身份留言");
            }
            else
            {
                ID = require[1].ToString();

                strcmd = "insert into Message values('" + ID + "', getdate(), '" + news + "');";
                cmd.CommandText = strcmd;

                require.Close();


                int succCount = cmd.ExecuteNonQuery();
                if (succCount == 0)
                    MessageBox.Show("留言失败");
                else MessageBox.Show("留言成功");

            }

            require.Close();
            sqlCnt.Close();
        }
    }
}
