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
    public partial class checkout : Form
    {
        public checkout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string roomNo = textBox1.Text;
            float damageCost = 0;
            float normalCost = 0;
            float cost;

            string connectString = "Data Source = iDevin.cn; Initial Catalog = HotelMS; Persist Security Info = True; User ID = sa; Password = wyw.19961019";

            SqlConnection sqlCnt = new SqlConnection(connectString);
            sqlCnt.Open();

            SqlCommand cmd = sqlCnt.CreateCommand();

            string strcmd = "select * from DamagedItems where roomNo='" + roomNo + "';";

            cmd.CommandText = strcmd;
            SqlDataReader require = cmd.ExecuteReader();

            while(require.Read())
            {
                damageCost += float.Parse(require[3].ToString());
            }

            require.Close();

            strcmd = "update Bill set damageCost = " + damageCost + ", checkoutTime = getdate() where roomNo='" + roomNo + "' and checkoutTime is NULL;";
            cmd.CommandText = strcmd;
            int succNum = cmd.ExecuteNonQuery();


     
            strcmd = "select roomNo, cost from Rooms, Standards where Rooms.roomStd = Standards.stdLevel;";
            cmd.CommandText = strcmd;

            require = cmd.ExecuteReader();

            if(! require.Read())
            {
                MessageBox.Show("信息查找失败, 请检查输入信息");
            }
            else
            {
                normalCost = float.Parse(require[1].ToString());

                require.Close();


                strcmd = "select day(checkoutTime - checkinTime) as days from Bill where cost is NULL and roomNo = '" + roomNo + "';";
                cmd.CommandText = strcmd;
                require = cmd.ExecuteReader();

              

                if (!require.Read())
                {
                    MessageBox.Show("信息查找失败, 请检查输入信息");
                }
                else
                {
                    normalCost *= int.Parse(require[0].ToString());

                    cost = normalCost + damageCost;

                    require.Close();

                    strcmd = "update Bill set normalCost = " + normalCost + ", cost = " + cost + " where roomNo='" + roomNo + "' and cost is NULL;";


                    cmd.CommandText = strcmd;

                    succNum += cmd.ExecuteNonQuery();

                   

                    if (succNum == 0)
                    {
                        MessageBox.Show("数据更新失败, 请重新再试");
                    }
                    else
                    {
                        MessageBox.Show("退房成功, 您总共需要支付" + cost + "元");


                        require.Close();
                        strcmd = "update DamagedItems set charged = 'Y' where roomNo = '" + roomNo + "';";
                        cmd.CommandText = strcmd;
                        succNum = cmd.ExecuteNonQuery();

                        strcmd = "update Rooms set checked = 'N', lived = 'N' where roomNo = '" + roomNo + "';";
                        cmd.CommandText = strcmd;
                        succNum = cmd.ExecuteNonQuery();


                    }


                }

            }

            if(succNum == 0)
            {
                MessageBox.Show("数据计算失败");

                require.Close();
            }


            sqlCnt.Close();
        }
    }
}
