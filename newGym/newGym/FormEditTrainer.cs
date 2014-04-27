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
using System.Text.RegularExpressions;

namespace newGym
{
    public partial class FormEditTrainer : Form
    {
        public FormEditTrainer()
        {
            InitializeComponent();
            Fillcombo();

            id_txt.MaxLength = 9;
            firstname_txt.MaxLength = 20;
            lastname_txt.MaxLength = 20;
            email_txt.MaxLength = 40;
            username_txt.MaxLength = 15;
            password_txt.MaxLength = 15;
<<<<<<< HEAD

=======
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
        }

        void Fillcombo()
        {
            string constring = "datasource=localhost; port=3306; username=root; password=csharp;";
            string Query = "select * from gym.trainer  ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())     //adding names to combobox
                {
                    string sName = myReader.GetString("firstname");
                    comboBox1.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static bool checkEmail(string email)     //function to check email
        {
            bool isValid = false;
            Regex r = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (r.IsMatch(email))
                isValid = true;
            return isValid;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=csharp;";
            string Query = "select * from gym.trainer where firstname='" + comboBox1.Text + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

<<<<<<< HEAD




=======
            
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())     //adding names to textboxes
                {
                    string sId = myReader.GetInt32("id").ToString();        //convert int to string
                    string sFirstname = myReader.GetString("firstname");
                    string sLastname = myReader.GetString("lastname");
                    string sEmail = myReader.GetString("email");
                    string sUsername = myReader.GetString("username");
                    string sPassword = myReader.GetString("password");
                    string sSalar = myReader.GetInt32("salaryperhour").ToString();

                    id_txt.Text = sId;
                    firstname_txt.Text = sFirstname;
                    lastname_txt.Text = sLastname;
                    email_txt.Text = sEmail;
                    username_txt.Text = sUsername;
                    password_txt.Text = sPassword;
                    salar_txt.Text = sSalar;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=csharp;";
            string Query = "update gym.trainer set id='" + this.id_txt.Text + "' ,firstname='" + this.firstname_txt.Text + "' ,lastname='" + this.lastname_txt.Text + "' ,email='" + this.email_txt.Text + "' ,username='" + this.username_txt.Text + "' ,password='" + this.password_txt.Text + "', salaryperhour='"+ this.salar_txt.Text+"' where id='" + this.id_txt.Text + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            if (!(FormAddTrainer.checkEmail(email_txt.Text.ToString())))
                email_verification.Text = "InValid Email";

            if (FormAddTrainer.checkEmail(email_txt.Text.ToString()))
            {
                try
                {

                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    MessageBox.Show("Trainer Edited");

                    this.Close();
                    

                    while (myReader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        

        private void id_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)       //check if its numbers only and incude backspace key
            {
                MessageBox.Show("Enter Numbers Only");
                e.KeyChar = (char)0;
            }
        }

<<<<<<< HEAD
        private void id_txt_TextChanged(object sender, EventArgs e)
        {

        }
=======
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372

        private void clear_all_button_Click(object sender, EventArgs e)
        {
            id_txt.Text = string.Empty;
            firstname_txt.Text = string.Empty;
            lastname_txt.Text = string.Empty;
            email_txt.Text = string.Empty;
            username_txt.Text = string.Empty;
            password_txt.Text = string.Empty;
            email_verification.Text = string.Empty;
            salar_txt.Text = string.Empty;
        }
<<<<<<< HEAD

        private void salar_txt_TextChanged(object sender, EventArgs e)
        {

        }


=======
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
    }
}
