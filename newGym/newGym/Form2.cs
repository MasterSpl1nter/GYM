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
    public partial class Form2 :Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string id = textBox1.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id,room; 
            string name = textBox2.Text;
            string manufactur = textBox3.Text;
            DateTime dt = DateTime.Now;
            

            try
            {
                bool result = Int32.TryParse(textBox1.Text, out id);
                bool result2 = Int32.TryParse(textBox4.Text, out room);
                if (result && result2)
                {
                    if (textBox2.Text == "" || textBox3.Text == "")
                    {
                        MessageBox.Show("Please fill all fileds","ERROR");
                    }
                    else
                    {
                        Applince Ap = new Applince();
                        Ap.AddApplince(id, name, manufactur, room,dt);
                        if (Ap != null)
                        {
                            
                            MessageBox.Show("The data were successfully received");
                            this.Hide();
                            ManuApplince MP = new ManuApplince();
                            MP.ShowDialog();
                        }
                    }
                } 
                else
                {
                    MessageBox.Show("The data waren't successfully accepted","ERROR");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

