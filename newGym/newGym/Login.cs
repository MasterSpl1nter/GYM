using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace newGym
{
    public partial class Login : Form
    {

       

        public Login()
        {
            InitializeComponent();
            textBox1.Select();
            textBox1.MaxLength = 20;
            textBox2.MaxLength = 20;
            textBox2.PasswordChar = '*';
            comboBox2.SelectedIndex = 0;
            MessageBox.Show("Working Menus: \n1. Guide with password\n2. Trainer with password");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int retval = 1;

            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    var tool2 = Factory_DP.PersonFactory("Trainer");
                    if (tool2.Template(dt, textBox1.Text, textBox2.Text))
                    {   retval = 0;  }

                    break;
                case 3:
                    var tool3 = Factory_DP.PersonFactory("Guide");
                     if ( tool3.Template(dt, textBox1.Text, textBox2.Text ))

                     { retval = 0;}
                      
                    break;
                    
                case 4:     // not working look at Factory_DP RETURN
                    var tool4 = Factory_DP.PersonFactory("Manager");
                    if ( tool4.Template(dt, textBox1.Text, textBox2.Text) )
                        retval = 0;
                    
                 //------------------------------------------------------//    

                        //checking if the singelton works
                        /*
                        Manager m = Manager.Instance();
                        Manager s = Manager.Instance();
                        m.setManager(Convert.ToInt32(dt.Rows[0]["id"]), dt.Rows[0]["firstname"].ToString(), dt.Rows[0]["lastname"].ToString(), dt.Rows[0]["email"].ToString(), Convert.ToInt32(dt.Rows[0]["permission"]), dt.Rows[0]["username"].ToString(), dt.Rows[0]["password"].ToString(), Convert.ToInt32(dt.Rows[0]["salaryperhour"]));
                        s.setManager(Convert.ToInt32(dt.Rows[0]["id"]), dt.Rows[0]["firstname"].ToString(), dt.Rows[0]["lastname"].ToString(), dt.Rows[0]["email"].ToString(), Convert.ToInt32(dt.Rows[0]["permission"]), dt.Rows[0]["username"].ToString(), dt.Rows[0]["password"].ToString(), Convert.ToInt32(dt.Rows[0]["salaryperhour"]));
                        MessageBox.Show("m=" + m.GetHashCode() + " s=" + s.GetHashCode());
                        */
                        /*
                       // Manager manager = new Manager(Convert.ToInt32(dt.Rows[0]["id"]), dt.Rows[0]["firstname"].ToString(), dt.Rows[0]["lastname"].ToString(), dt.Rows[0]["email"].ToString(), Convert.ToInt32(dt.Rows[0]["permission"]), dt.Rows[0]["username"].ToString(), dt.Rows[0]["password"].ToString(), Convert.ToInt32(dt.Rows[0]["salaryperhour"]));
                        Manager.Instance().setManager(Convert.ToInt32(dt.Rows[0]["id"]), dt.Rows[0]["firstname"].ToString(), dt.Rows[0]["lastname"].ToString(), dt.Rows[0]["email"].ToString(), Convert.ToInt32(dt.Rows[0]["permission"]), dt.Rows[0]["username"].ToString(), dt.Rows[0]["password"].ToString(), Convert.ToInt32(dt.Rows[0]["salaryperhour"]));
                        ManagerMenu ma = new ManagerMenu();
                        ma.ShowDialog(); 
                    
          
                    /*ManagerMenu ma = new ManagerMenu();
                    ma.ShowDialog();*/

                    //------------------------------------------------------//


                   break;
                    
            }
            if (retval == 0)
            {
            }
            else if (retval == 1)
            {
                textBox1.ResetText();
                textBox2.ResetText();
                textBox1.Focus();
                label3.Text = "ERROR: Incorrect password";
                //MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                textBox1.ResetText();
                textBox2.ResetText();
                textBox1.Focus();
                if (retval == 1042 || retval == 2003)
                {
                    label3.Text = "ERROR: Connecting to the database.";
                }
                else label3.Text = "ERROR: #" + retval;
            }
        }
        public static void ThreadProc1()
        {
            Application.Run(new ManagerMenu());
            //Application.Run(new Menu(1));
            //Application.Run(new Form2());


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
