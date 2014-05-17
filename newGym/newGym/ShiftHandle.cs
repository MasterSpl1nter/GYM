using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace newGym
{
    public partial class ShiftHandle : Form
    {
        public ShiftHandle()
        {
            InitializeComponent();
            this.shiftResults.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panelShowShift.Visible = true;
            this.shiftResults.Visible = false;
            this.addShiftPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panelShowShift.Visible = false;
            this.shiftResults.Visible = false;
            this.addShiftPanel.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
