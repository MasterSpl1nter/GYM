using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace newGym
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            bool result = Int32.TryParse(textBox1.Text, out id);
            if (result)
            {
                Applince Ap = new Applince();

                Ap.deleteApplinceById(id);
                MessageBox.Show("The appliance has been deleted");
                this.Hide();
                ManuApplince MP = new ManuApplince();
                MP.ShowDialog();
 
          
            }
            else
                MessageBox.Show("Please fill all fileds","ERROR");

        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
