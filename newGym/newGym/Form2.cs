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

<<<<<<< HEAD
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

=======
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
        private void button1_Click(object sender, EventArgs e)
        {
            int id,room; 
            string name = textBox2.Text;
            string manufactur = textBox3.Text;
            DateTime dt = DateTime.Now;
            

            try
            {
<<<<<<< HEAD
               
=======
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
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
<<<<<<< HEAD

=======
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
                } 
                else
                {
                    MessageBox.Show("The data waren't successfully accepted","ERROR");
<<<<<<< HEAD
                
                
                
                }

=======
                }
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
<<<<<<< HEAD


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

=======
        }
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
    }
}

