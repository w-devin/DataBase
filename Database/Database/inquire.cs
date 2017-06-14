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
    public partial class inquire : Form
    {
        public inquire()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new availableRooms().Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new allRooms().Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new checkedRoom().Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new livedRoom().Visible = true;
        }
    }
}
