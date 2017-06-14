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
    public partial class Prices : Form
    {
        public Prices()
        {
            InitializeComponent();
        }

        private void Prices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelMSDataSet4.物件价格' table. You can move, or remove it, as needed.
            this.物件价格TableAdapter.Fill(this.hotelMSDataSet4.物件价格);

        }
    }
}
