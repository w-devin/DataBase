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
    public partial class checkin : Form
    {
        public checkin()
        {
            InitializeComponent();
        }

        private void checkin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelMSDataSet1.所有房间' table. You can move, or remove it, as needed.
            this.所有房间TableAdapter.Fill(this.hotelMSDataSet1.所有房间);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = textBox1.Text;
            string roomNo = textBox2.Text;

            string connectString = "Data Source = iDevin.cn; Initial Catalog = HotelMS; Persist Security Info = True; User ID = sa; Password = wyw.19961019";

            SqlConnection sqlCnt = new SqlConnection(connectString);
            sqlCnt.Open();

            SqlCommand cmd = sqlCnt.CreateCommand();

            string strcmd = "select name, ID from Customers where ID='" + ID + "';";

            cmd.CommandText = strcmd;
            SqlDataReader require = cmd.ExecuteReader();

            if (!require.Read())
            {
                MessageBox.Show("顾客不存在, 请先注册");
                new register().Visible = true;
            }
            else
            {
                require.Close();

                strcmd = "select * from Rooms where roomNo = '" + roomNo + "' and lived = 'N';";
                cmd.CommandText = strcmd;
                require = cmd.ExecuteReader();

                if(!require.Read())
                {
                    MessageBox.Show("房间不可用, 请重新选择");
                }
                else
                {
                    require.Close();
                    strcmd = "insert into Bill(ID, roomNO, checkinTime) values('" + ID + "', '" + roomNo + "', getdate());";
                    cmd.CommandText = strcmd;
                    int succNum = cmd.ExecuteNonQuery();

                    if(succNum == 0)
                    {
                        MessageBox.Show("开房失败, 请重新尝试");
                    }
                    else
                    {
                        MessageBox.Show("开房成功");
                    }
                }
            }
            require.Close();
            sqlCnt.Close();
        }
    }
}
