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
    public partial class recordDamage : Form
    {
        public recordDamage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itemNo = textBox1.Text;
            int num = int.Parse(textBox2.Text);
            string roomNo = textBox3.Text;

            string connectString = "Data Source = iDevin.cn; Initial Catalog = HotelMS; Persist Security Info = True; User ID = sa; Password = wyw.19961019";

            SqlConnection sqlCnt = new SqlConnection(connectString);
            sqlCnt.Open();

            SqlCommand cmd = sqlCnt.CreateCommand();
            SqlCommand cc = sqlCnt.CreateCommand();

            cc.CommandText = "select * from Items where itemNo='" + itemNo + "';";
            SqlDataReader item = cc.ExecuteReader();

            if(! item.Read())
            {
                MessageBox.Show("物品不存在， 请检查编号");
            }
            else
            {
                int price = int.Parse(item[2].ToString());
                item.Close();

                string strcmd = "insert into DamagedItems values('" + roomNo + "', '" + itemNo + "', " + num + ", " + price * num + ", 'N');";
                cmd.CommandText = strcmd;
                int succNum = cmd.ExecuteNonQuery();

                if(succNum == 0)
                {
                    MessageBox.Show("数据记录失败, 请检查输入信息");
                }
                else
                {
                    MessageBox.Show("数据记录成功");
                    this.Close();
                }

            }
            
             
            

        }
    }
}
