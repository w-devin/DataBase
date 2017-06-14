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
    public partial class damageHis : Form
    {
        public damageHis()
        {
            InitializeComponent();
        }

        private void 物件损坏记录_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelMSDataSet6.物件损坏记录' table. You can move, or remove it, as needed.
            this.物件损坏记录TableAdapter.Fill(this.hotelMSDataSet6.物件损坏记录);

        }
    }
}
