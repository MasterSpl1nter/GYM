using MySql.Data.MySqlClient;
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
    public partial class FormAddTrainer : Form
    {
        public FormAddTrainer()
        {
            InitializeComponent();

            id_txt.MaxLength = 9;
            firstname_txt.MaxLength = 30;
            lastname_txt.MaxLength = 30;
            email_txt.MaxLength = 40;
            username_txt.MaxLength = 30;
            password_txt.MaxLength = 30;
            salar_txt.MaxLength = 10;
            
        }

        public static bool checkEmail(string email)     //function to check email
        {
            bool isValid = false;
            Regex r = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (r.IsMatch(email))
                isValid = true;
            return isValid;
        }


        private void button1_Click(object sender, EventArgs e)      //add button
        {
            string constring = "datasource=localhost; port=3306; username=root; password=csharp;";
            string Query = "insert into gym.trainer (id,firstname,lastname,email,username,password,permission,salaryperhour) values('" + this.id_txt.Text + "' , '" + this.firstname_txt.Text + "' , '" + this.lastname_txt.Text + "' , '" + this.email_txt.Text + "' , '" + this.username_txt.Text + "' , '" + this.password_txt.Text + "','"+ 2 +"' , '"+ this.salar_txt.Text +"') ;";
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
                    MessageBox.Show("Trainer Added");

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

        private void id_txt_TextChanged(object sender, EventArgs e)
        {

        }

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
