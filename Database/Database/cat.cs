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
    public partial class cat : Form
    {
        public cat()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = textBox1.Text;

            string connectString = "Data Source = iDevin.cn; Initial Catalog = HotelMS; Persist Security Info = True; User ID = sa; Password = wyw.19961019";

            SqlConnection sqlCnt = new SqlConnection(connectString);
            sqlCnt.Open();

            SqlCommand cmd = sqlCnt.CreateCommand();

            string strcmd = " select Customers.name, Customers.sex, Customers.tel, Bill.roomNo, Standards.stdLevel, Bill.checkinTime, Bill.checkoutTime, Bill.cost from Bill, Customers, Rooms, Standards where Bill.ID = Customers.ID and Rooms.roomStd = Standards.stdLevel and Bill.roomNo = Rooms.roomNo and Customers.ID = '" + ID + "';";

            /*
            select Customers.ID, Customers.name, Customers.sex, Customers.tel, Bill.roomNo, Standards.stdLevel, Bill.checkinTime
            from Bill, Customers, Rooms, Standards
            where Bill.ID = Customers.ID
              and Rooms.roomStd = Standards.stdLevel
              and Bill.roomNo = Rooms.roomNo;
            */
            cmd.CommandText = strcmd;
            SqlDataReader require = cmd.ExecuteReader();

            if(!require.Read())
            {
                MessageBox.Show("没有此人信息");
            }
            else
            {
                textBox2.Text = require[0].ToString();
                textBox3.Text = require[1].ToString();
                textBox4.Text = require[2].ToString();
                textBox5.Text = require[3].ToString();
                textBox6.Text = require[4].ToString();
                textBox7.Text = require[5].ToString();
                textBox8.Text = require[6].ToString();
                textBox9.Text = require[7].ToString();
                
            }



        }
    }
}
