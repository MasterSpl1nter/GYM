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
<<<<<<< HEAD
=======

       

>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
        public Login()
        {
            InitializeComponent();
            textBox1.Select();
            textBox1.MaxLength = 20;
            textBox2.MaxLength = 20;
            textBox2.PasswordChar = '*';
            comboBox2.SelectedIndex = 0;
<<<<<<< HEAD
            MessageBox.Show("Working Menus: \n1. Manager without password\n2. Guide with password\n3. Trainer with password");
=======
            MessageBox.Show("Working Menus: \n1. Guide with password\n2. Trainer with password\n3. Manager with password");
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int retval = 1;
<<<<<<< HEAD
=======

>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
<<<<<<< HEAD
                    if (Trainer.CheckLogin(dt, textBox1.Text, textBox2.Text))
                    {
                        retval = 0;
                        Trainer trainer = new Trainer(Convert.ToInt32(dt.Rows[0]["id"]), dt.Rows[0]["firstname"].ToString(), dt.Rows[0]["lastname"].ToString(), dt.Rows[0]["email"].ToString(), Convert.ToInt32(dt.Rows[0]["permission"]), dt.Rows[0]["username"].ToString(), dt.Rows[0]["password"].ToString(), Convert.ToInt32(dt.Rows[0]["salaryperhour"]));
                        TrainerMenu gm = new TrainerMenu(trainer);
                        gm.ShowDialog();
                    }
                    break;
                case 3:
                    if (Guide.CheckLogin(dt, textBox1.Text, textBox2.Text))
                    {
                        retval = 0;
                        Guide guide = new Guide(Convert.ToInt32(dt.Rows[0]["id"]), dt.Rows[0]["firstname"].ToString(), dt.Rows[0]["lastname"].ToString(), dt.Rows[0]["email"].ToString(), Convert.ToInt32(dt.Rows[0]["permission"]), dt.Rows[0]["username"].ToString(), dt.Rows[0]["password"].ToString(), Convert.ToInt32(dt.Rows[0]["salaryperhour"]));
                        GuideMenu gm = new GuideMenu(guide);
                        gm.ShowDialog();
                    }
                    break;
                case 4:
                    ManagerMenu ma = new ManagerMenu();
                    ma.ShowDialog();
                    break;
            }
            if (retval == 1)
=======
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
                    Person p = Factory_DP.PersonFactory("Manager");
                    //p.Template(dt, textBox1.Text, textBox2.Text);
                    if (p.Template(dt, textBox1.Text, textBox2.Text))
                    {
                        
                       ((Manager)p).setManager(Convert.ToInt32(dt.Rows[0]["id"]), dt.Rows[0]["firstname"].ToString(), dt.Rows[0]["lastname"].ToString(), dt.Rows[0]["email"].ToString(), Convert.ToInt32(dt.Rows[0]["permission"]), dt.Rows[0]["username"].ToString(), dt.Rows[0]["password"].ToString(), Convert.ToInt32(dt.Rows[0]["salaryperhour"]));
                        SingleUser.Instance.set_user(p);
                        ManagerMenu ma = new ManagerMenu(((Manager)p));
                        ma.ShowDialog();
                        retval = 0;
                    }

                   break;
                    
            }
            if (retval == 0)
            {
            }
            else if (retval == 1)
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
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
<<<<<<< HEAD
=======
        /*
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
        public static void ThreadProc1()
        {
            Application.Run(new ManagerMenu());
            //Application.Run(new Menu(1));
            //Application.Run(new Form2());


        }
<<<<<<< HEAD

=======
        */
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
