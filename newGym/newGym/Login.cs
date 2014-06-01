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
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            label3.Text = "";
            int retval = 1;
            Person p;
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    //to pop the singelton user - ((Manager)SingleUser.Instance.get_user())
                    p = Factory_DP.PersonFactory("Student");//new for specific user
                    //func template -check login and update data for Person

                    if (p.Template(dt, textBox1.Text, textBox2.Text))
                    {
                        retval = 0;
                        SingleUser.Instance.set_user(p); //add user to singelton 
                        ((Student)SingleUser.Instance.get_user()).popMenu();

                    }

                    break;

                case 1:
                    //to pop the singelton user - ((Manager)SingleUser.Instance.get_user())
                    p = Factory_DP.PersonFactory("Secretary");//new for specific user
                    //func template -check login and update data for Person

                    if (p.Template(dt, textBox1.Text, textBox2.Text))
                    {
                        retval = 0;
                        SingleUser.Instance.set_user(p); //add user to singelton 
                        ((Secretary)SingleUser.Instance.get_user()).popMenu();

                    }

                    break;
                case 2:
                    //to pop the singelton user - ((Trainer)SingleUser.Instance.get_user())
                    p = Factory_DP.PersonFactory("Trainer");
                    if (p.Template(dt, textBox1.Text, textBox2.Text))
                    {
                        retval = 0;
                        SingleUser.Instance.set_user(p);
                        ((Trainer)SingleUser.Instance.get_user()).popMenu();


                    }

                    break;
                case 3:
                    //to pop the singelton user - ((Guide)SingleUser.Instance.get_user())
                    p = Factory_DP.PersonFactory("Guide");
                    if (p.Template(dt, textBox1.Text, textBox2.Text))
                    {
                        retval = 0;
                        SingleUser.Instance.set_user(p);
                        ((Guide)SingleUser.Instance.get_user()).popMenu();

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
                        ((Manager)SingleUser.Instance.get_user()).popMenu();
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }


    }
}
