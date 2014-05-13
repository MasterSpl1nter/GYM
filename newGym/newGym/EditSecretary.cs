using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;



namespace newGym
{
    public partial class EditSecretary : Form
    {
        //string password;
        int perm = 1;
        int salary = 200;
        string idOld;
        

        public EditSecretary()
        {
            InitializeComponent();

            try
            {
                fillBox(); //fill the combobox by id
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void fillBox()
        {
            DataTable dt = new DataTable();
            MySQL.Select(dt, "worker");
            //fill combobox by id
            foreach (DataRow row in dt.Rows)
            {
                this.id_comboBox1.Items.Add(row["id"].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = this.id_comboBox1.SelectedItem.ToString();

            string constring = "datasource=localhost; port=3306; username=root; password=csharp;";
            string Query = "select * from gym.worker where id='" + id + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                myReader.Read();

                this.idOld = myReader.GetInt32("id").ToString();        //convert int to string
                string sFirstname = myReader.GetString("firstname");
                string sLastname = myReader.GetString("lastname");
                string sEmail = myReader.GetString("email");
                string sUsername = myReader.GetString("username");
                string sPassword = myReader.GetString("password");

                id_textBox.Text = idOld;
                firstname_textBox.Text = sFirstname;
                lastname_textBox.Text = sLastname;
                email_textBox.Text = sEmail;
                username_textBox.Text = sUsername;
                password_textBox.Text = sPassword;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
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
            if (password_textBox.Text.Length < 6)
            {
                MessageBox.Show("You must choose a valid password, at least 6 characters", "ERROR", MessageBoxButtons.OK);
                password_label.ForeColor = Color.Red;
                password_textBox.ResetText();
                password_textBox.Focus();
                err = true;
                return;
            }
            else
            {
                err = false;
                password_label.ForeColor = Color.Black;
            }
            //if all data is valid
            if (err == false)
            {
                try
                {
                    string insert = String.Format("id={0},firstname='{1}',lastname='{2}',email='{3}',username='{4}',password='{5}',permission='{6}',salaryperhour={7}"
                    , id_textBox.Text, this.firstname_textBox.Text, this.lastname_textBox.Text, this.email_textBox.Text,
                    this.username_textBox.Text, this.password_textBox.Text
                    , this.perm, this.salary);
                    int retval = Secretary.Update(insert, this.idOld);
                    if (retval == 0)
                    {
                        MessageBox.Show("Secretary has been updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void id_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
    }
}
