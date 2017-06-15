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
    public partial class calOrder : Form
    {
        public calOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string roomNo = textBox1.Text;

            string connectString = "Data Source = iDevin.cn; Initial Catalog = HotelMS; Persist Security Info = True; User ID = sa; Password = wyw.19961019";

            SqlConnection sqlCnt = new SqlConnection(connectString);
            sqlCnt.Open();

            SqlCommand cmd = sqlCnt.CreateCommand();

            string strcmd = "delete from OrderFroms where roomNo = '" + roomNo + "';";

            cmd.CommandText = strcmd;
            int succNum = cmd.ExecuteNonQuery();

            if(succNum == 0)
            {
                MessageBox.Show("取消预约失败");
            }
            else
            {
                MessageBox.Show("取消预约成功");
                this.Close();

                strcmd = "update Rooms set checked = 'N' where roomNo = '" + roomNo + "';";
                cmd.CommandText = strcmd;
                succNum = cmd.ExecuteNonQuery();
            }
        }
    }
}
