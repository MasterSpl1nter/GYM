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
    public partial class Login : GForm
    {

       

        public Login()
        {
            InitializeComponent();
            textBox1.Select();
            textBox1.MaxLength = 20;
            textBox2.MaxLength = 20;
            textBox2.PasswordChar = '*';
            comboBox2.SelectedIndex = 0;
            MessageBox.Show("Working Menus: \n1. Guide with password\n2. Trainer with password\n3. Manager with password");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int retval = 1;
            Person p;
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    //to pop the singelton user - ((Trainer)SingleUser.Instance.get_user())
                    p = Factory_DP.PersonFactory("Trainer");
                    if (p.Template(dt, textBox1.Text, textBox2.Text))
                    {
                        SingleUser.Instance.set_user(p);
                        TrainerMenu tm = new TrainerMenu((Trainer)p);
                        tm.ShowDialog();
                        retval = 0;
                    }

                    break;
                case 3:
                    //to pop the singelton user - ((Guide)SingleUser.Instance.get_user())
                     p = Factory_DP.PersonFactory("Guide");
                     if ( p.Template(dt, textBox1.Text, textBox2.Text ))
                     {
                         retval = 0;
                         SingleUser.Instance.set_user(p);
                         GuideMenu gm = new GuideMenu((Guide)p);
                         gm.ShowDialog();
                     }
                      
                    break;
                    
                case 4:
                    //to pop the singelton user - ((Manager)SingleUser.Instance.get_user())
                    p = Factory_DP.PersonFactory("Manager");//new for specific user
                    //func template -check login and update data for Person
                    if (p.Template(dt, textBox1.Text, textBox2.Text))
                    {
                        retval = 0;
                        SingleUser.Instance.set_user(p); //add user to singelton 
                        ManagerMenu ma = new ManagerMenu(((Manager)p));
                        ma.ShowDialog();
                       
                    }

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
        /*
        public static void ThreadProc1()
        {
            Application.Run(new ManagerMenu());
            //Application.Run(new Menu(1));
            //Application.Run(new Form2());


        }
        */
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
