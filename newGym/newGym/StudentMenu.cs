using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newGym
{
    public partial class StudentMenu : Form
    {

        public StudentMenu()
        {
            InitializeComponent();
        }
   
        private void StudentMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            EditStudentBySecrtary ed = new EditStudentBySecrtary();
            
        }
    }
}
