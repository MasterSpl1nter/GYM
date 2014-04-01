﻿using System;
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
            MessageBox.Show("Working Menus: \n1. Manager without password\n2. Guide with password");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    if (Guide.CheckLogin(dt, textBox1.Text, textBox2.Text))
                    {
                        Guide guide = new Guide(Convert.ToInt32(dt.Rows[0]["id"]), dt.Rows[0]["firstname"].ToString(), dt.Rows[0]["lastname"].ToString(), dt.Rows[0]["email"].ToString(), Convert.ToInt32(dt.Rows[0]["permission"]), dt.Rows[0]["username"].ToString(), dt.Rows[0]["password"].ToString(), Convert.ToInt32(dt.Rows[0]["salaryperhour"]));
                        GuideMenu gm = new GuideMenu(guide);
                        gm.ShowDialog();
                        /*
                        Threads tws = new Threads(guide);

                        Thread t = new Thread(new ThreadStart(tws.ThreadProc));
                        t.Start();
                        this.Close();*/
                    }
                    /*
                        System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                        t.Start();
                        this.Close();
                    }*/
                    break;
                case 4:

                    break;
            }
            int retval = 1;
            if (retval == 1)
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
        public static void ThreadProc()
        {
            Application.Run(new GuideMenu(guide));
            //Application.Run(new Menu(1));
            //Application.Run(new Form2());
          
            
        }
         */
        public static void ThreadProc1()
        {
            Application.Run(new ManagerMenu());
            //Application.Run(new Menu(1));
            //Application.Run(new Form2());


        }
    }
}
