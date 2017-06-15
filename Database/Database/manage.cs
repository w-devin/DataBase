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
    public partial class manage : Form
    {
        public manage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Order().Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new checkin().Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new recordDamage().Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new checkout().Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new calOrder().Visible = true;
        }
    }
}
