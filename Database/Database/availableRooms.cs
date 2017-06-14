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
    public partial class availableRooms : Form
    {
        public availableRooms()
        {
            InitializeComponent();
        }

        private void availableRooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelMSDataSet.空闲房间' table. You can move, or remove it, as needed.
            this.空闲房间TableAdapter.Fill(this.hotelMSDataSet.空闲房间);

        }
    }
}
