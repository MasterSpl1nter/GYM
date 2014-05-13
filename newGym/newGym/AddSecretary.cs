using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newGym
{
    public partial class AddSecretary : Form
    {
        int id;
        string firstname;
        string lastname;
        string email;
        string username;
        string password;
        int perm = 1;
        int salary = 200;

        public AddSecretary()
        {
            InitializeComponent();
        }
        //reset all label to the default color
        private void ResetColors()
        {
            name_label.ForeColor = Color.Black;
            lastname_label.ForeColor = Color.Black;
            email_label.ForeColor = Color.Black;
            username_label.ForeColor = Color.Black;
            password_label.ForeColor = Color.Black;
            verify_label.ForeColor = Color.Black;
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            bool err = false;

            foreach (Control c in this.Controls)
            {
                if (c is TextBox && c.Text.Length == 0)
                {
                    MessageBox.Show("Please fill all fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
     
            //checking the ID
            if (id_textBox.Text.Length < 9)
            {
                MessageBox.Show("ID invalid, Pleas try again", "ERROR", MessageBoxButtons.OK);
                id_textBox.ResetText();
                id_textBox.Focus();
                id_label.ForeColor = Color.Red;
                err = true;
                return;
            }
            else
            {
                id_label.ForeColor = Color.Black;
                err = false;
            }
          
            //checking Email textBox
            Regex reg = new Regex(@"[\w-]+@([\w-]+\.)+[\w-]+");
            if (!reg.IsMatch(email_textBox.Text))
            {
                MessageBox.Show("Please fill a valid Email", "ERROR", MessageBoxButtons.OK);
                email_textBox.ResetText();
                email_textBox.Focus();
                email_label.ForeColor = Color.Red;
                err = true;
                return;
            }
            else
            {
                email_label.ForeColor = Color.Black;
                err = false;
            }

            //checking userName and password
            if (password_textBox.Text.Length < 6)
            {
                MessageBox.Show("You must choose a valid password, at least 6 characters", "ERROR", MessageBoxButtons.OK);
                password_label.ForeColor = Color.Red;
                password_textBox.ResetText();
                verify_textBox.ResetText();
                password_textBox.Focus();
                err = true;
                return;
            }
            else
            {
                err = false;
                password_label.ForeColor = Color.Black;
            }
            //if password is equal like the verify password
            if (password_textBox.Text != verify_textBox.Text)
            {
                MessageBox.Show("Password not much, Please try again!", "ERROR", MessageBoxButtons.OK);
                password_label.ForeColor = Color.Red;
                verify_label.ForeColor = Color.Red;
                password_textBox.ResetText();
                verify_textBox.ResetText();
                password_textBox.Focus();
                err = true;
                return;
            }
            else
            {
                err = false;
                password_label.ForeColor = Color.Black;
                verify_label.ForeColor = Color.Black;
            }

            if (err == false)
            {
                //insert data to the sql
                id = Convert.ToInt32(id_textBox.Text);
                firstname = firstname_textBox.Text;
                lastname = lastname_textBox.Text;
                email = email_textBox.Text;
                username = username_textBox.Text;
                password = password_textBox.Text;

                try
                {
                    string insert = String.Format("{0},'{1}','{2}','{3}','{4}','{5}',{6},{7}", id, firstname, lastname, email,
                        username, password, perm, salary);
                    int retval = Secretary.Add(insert);

                    if (retval == 0)
                    {
                        MessageBox.Show("GDetails have been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (retval == 1062)
                    {
                        MessageBox.Show("Secretary with this ID or Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("ERROR #" + retval);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }      
        }
        //Verifies typing numbers only
        private void id_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void AddSecretary_Load(object sender, EventArgs e)
        {

        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
