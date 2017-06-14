using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class livedRoom : Form
    {
        public livedRoom()
        {
            InitializeComponent();
        }

        private void livedRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelMSDataSet3.已居住房间' table. You can move, or remove it, as needed.
            this.已居住房间TableAdapter.Fill(this.hotelMSDataSet3.已居住房间);

        }
    }
}
