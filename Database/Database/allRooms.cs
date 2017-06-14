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
    public partial class allRooms : Form
    {
        public allRooms()
        {
            InitializeComponent();
        }

        private void allRooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelMSDataSet1.所有房间' table. You can move, or remove it, as needed.
            this.所有房间TableAdapter.Fill(this.hotelMSDataSet1.所有房间);

        }
    }
}
