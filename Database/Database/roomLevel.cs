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
    public partial class roomLevel : Form
    {
        public roomLevel()
        {
            InitializeComponent();
        }

        private void roomLevel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelMSDataSet5.房间标准' table. You can move, or remove it, as needed.
            this.房间标准TableAdapter.Fill(this.hotelMSDataSet5.房间标准);

        }
    }
}
