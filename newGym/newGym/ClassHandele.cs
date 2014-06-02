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
    public partial class ClassHandele : GForm
    {
        public ClassHandele()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fAddClass AddClass = new fAddClass();
            AddClass.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            fEditClass editClass = new fEditClass();
            editClass.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //delete//
            fDelClass DelClass = new fDelClass();
            DelClass.ShowDialog();
        }
    }
}
