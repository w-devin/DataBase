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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelMSDataSet9.空闲房间' table. You can move, or remove it, as needed.
            this.空闲房间TableAdapter2.Fill(this.hotelMSDataSet9.空闲房间);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker2.ShowUpDown = true;

            string ID = textBox1.Text;
            string roomNo = textBox2.Text;
            string liveinTime = dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString() + " " + dateTimePicker1.Value.Hour.ToString() + ":" + dateTimePicker1.Value.Minute.ToString() + ":" + dateTimePicker1.Value.Second.ToString();
            string leaveTime = dateTimePicker2.Value.Year.ToString() + "-" + dateTimePicker2.Value.Month.ToString() + "-" + dateTimePicker2.Value.Day.ToString() + " " + dateTimePicker2.Value.Hour.ToString() + ":" + dateTimePicker2.Value.Minute.ToString() + ":" + dateTimePicker2.Value.Second.ToString();

            string connectString = "Data Source = iDevin.cn; Initial Catalog = HotelMS; Persist Security Info = True; User ID = sa; Password = wyw.19961019";

            SqlConnection sqlCnt = new SqlConnection(connectString);
            sqlCnt.Open();
            SqlCommand cmd = sqlCnt.CreateCommand();

            string strcmd = "select name, ID from Customers where ID='" + ID + "';";

            cmd.CommandText = strcmd;
            SqlDataReader require = cmd.ExecuteReader();

            if(!require.Read())
            {
                MessageBox.Show("此顾客不存在, 注册为新顾客");
                new register().Visible = true;
            }
            else
            {
                require.Close();

                strcmd = "insert into OrderFroms values('" + ID + "', '" + roomNo + "', getdate(), '" + liveinTime + "', '" + leaveTime + "');";

                //MessageBox.Show(strcmd);
                cmd.CommandText = strcmd;

                int succNum = cmd.ExecuteNonQuery();
                
                if(succNum == 0)
                {
                    MessageBox.Show("预定失败，请检查预定信息");
                }
                else
                {
                    MessageBox.Show("预定成功");
                    require.Close();

                    strcmd = "update Rooms set checked = 'Y' from Rooms, OrderFroms where Rooms.roomNo = OrderFroms.roomNo and Rooms.roomNo = '" + roomNo + "';";
                    cmd.CommandText = strcmd;

                    succNum = cmd.ExecuteNonQuery();
                    if (succNum == 0) MessageBox.Show("房间状态更新失败");
                    else MessageBox.Show("房间状态更新成功");

                    this.Close();
                }
            }
        }
    }
}
