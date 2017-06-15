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

        private void button5_Click(object sender, EventArgs e)
        {
            new Prices().Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new roomLevel().Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new damageHis().Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Bills().Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new cat().Visible = true;
        }
    }
}
