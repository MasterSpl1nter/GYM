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
    public partial class SecretaryMenu : Form
    {


        int id;
        string firstName;
        string LastName;
        string email; // add
        string username; // get from this form
        string password; // get from this form
        int permission = 0;
        DateTime now = DateTime.Now;



        public SecretaryMenu()
        {
            InitializeComponent();
            AddStudentPannel.Visible = false;
            EditStudentPannel.Visible = false;;
        }



        private void addStudentButton_Click(object sender, EventArgs e)
        {
            AddStudentPannel.Visible = true;
        }

        private void editStudentButton_Click(object sender, EventArgs e)
        {
            EditStudentPannel.Visible = true;
            fillcombo();
        }



        //relevant for ADD STUDENT PANNEL 
        private void resetColors()
        {
            // zreo all the label's colors
            firstName_label.ForeColor = Color.Black;
            lastName_label.ForeColor = Color.Black;
            id_label.ForeColor = Color.Black;
            mail_label.ForeColor = Color.Black;
            userName_label.ForeColor = Color.Black;
            passWord_label.ForeColor = Color.Black;
            verPassWorod_label.ForeColor = Color.Black;
            birth_label.ForeColor = Color.Black;
            start_date_label.ForeColor = Color.Black;
            end_date_label.ForeColor = Color.Black;
            medcart_lable.ForeColor = Color.Black;

        }

        private void enter_button_Click(object sender, EventArgs e)
        {


            DateTime startDate = DateTime.Now;
            resetColors();

            DateTime now = DateTime.Now;
            try
            {
                // check id validation
                if (id_box.Text == "")
                {
                    MessageBox.Show("Please enter ID");
                    id_label.ForeColor = Color.Red;
                    return;
                }
                if (id_box.Text.Length < 9)
                {
                    MessageBox.Show("ID invalid ! Please try again");
                    id_label.ForeColor = Color.Red;
                    return;
                }
                //check name of the student
                if (firstname_box.Text == "")
                {
                    MessageBox.Show("Please enter First name");
                    firstName_label.ForeColor = Color.Red;
                    return;
                }

                //check lastname of the student
                if (lastname_box.Text == "")
                {
                    MessageBox.Show(" Please enter Last name!");
                    lastName_label.ForeColor = Color.Red;
                    return;
                }
                //check email valitiy
                if (email_box.Text != "")
                {
                    Regex r = new Regex(@"[\w-]+@([\w-]+\.)+[\w-]+");
                    if (!r.IsMatch(email_box.Text))
                    {
                        MessageBox.Show("Email invalid , Press correct email ", "ERROR", MessageBoxButtons.OK);
                        email_box.ResetText();
                        email_box.Focus();
                        mail_label.ForeColor = Color.Red;
                        return;
                    }
                }
                // check username
                if (tb_username.Text == "")
                {
                    MessageBox.Show("Please enter user name ");
                    return;
                }
                //check validaty of dates
                if (now.Date <= birth_date.Value.Date)
                {
                    MessageBox.Show("Birth date invalid , please try again!");
                    birth_label.ForeColor = Color.Red;
                    birth_date.Focus();
                    return;
                }

                if (startDate.Date > start_date.Value.Date)
                {
                    MessageBox.Show("Start date is invalid , please try again!");
                    start_date_label.ForeColor = Color.Red;
                    start_date.Focus();
                    return;
                }
                if (start_date.Value.Date >= end_date.Value.Date)
                {
                    MessageBox.Show("End date is invalid , please try again");
                    end_date_label.ForeColor = Color.Red;
                    end_date.Focus();
                    return;
                }
                if (med_cart_date.Value.Date > start_date.Value.Date && med_cart_date.Value.Date < end_date.Value.Date)
                {
                    MessageBox.Show(" Medical certificate is valid but has to update the certificate for the duration of the subscription ");
                }
                if (med_cart_date.Value.Date < start_date.Value.Date)
                {
                    MessageBox.Show(" Medical certificate is not valid medical certificate must be brought immediately");
                }


                //check valid of password
                if (tb_pass.Text.Length < 6 && tb_repeatPass.Text.Length < 6)
                {
                    MessageBox.Show(" Password is too short! At least 6 characters password");
                    tb_repeatPass.ResetText();
                    tb_pass.ResetText();
                    passWord_label.ForeColor = Color.Red;
                    verPassWorod_label.ForeColor = Color.Red;
                    return;
                }
                if (tb_pass.Text != tb_repeatPass.Text)
                {
                    MessageBox.Show("Verification password is wrong try again ");
                    tb_pass.ResetText();
                    tb_repeatPass.ResetText();
                    passWord_label.ForeColor = Color.Red;
                    verPassWorod_label.ForeColor = Color.Red;
                    return;

                }

                if (id_box.Text != "" && firstname_box.Text != "" && lastname_box.Text != "" && birth_date.Value.Date.ToString("yyyy-MM-dd") != ""
                    && start_date.Value.Date.ToString("yyyy-MM-dd") != "" && end_date.Value.Date.ToString("yyyy-MM-dd") != ""
                    && med_cart_date.Value.Date.ToString("yyyy-MM-dd") != "" && email_box.Text != "")
                {
                    this.id = Convert.ToInt32(id_box.Text);
                    this.firstName = firstname_box.Text;
                    this.LastName = lastname_box.Text;
                    this.email = email_box.Text;
                    this.username = tb_username.Text;
                    this.password = tb_pass.Text;
                    string insert = String.Format("{0},'{1}','{2}','{3}','{4}','{5}',{6},'{7}','{8}','{9}','{10}'", id, firstName,
                        LastName, email, username, password, permission, birth_date.Value.Date.ToString("yyyy-MM-dd"),
                        start_date.Value.Date.ToString("yyyy-MM-dd"), end_date.Value.Date.ToString("yyyy-MM-dd"),
                        med_cart_date.Value.Date.ToString("yyyy-MM-dd"));
                    MySQL.Insert("student", "id,firstname,lastname,email,username,password,permission,birthday,startdate,enddate,medcert", insert);
                    MessageBox.Show("Details have been added successfully ");
                }
                else
                {
                    MessageBox.Show("Incomplete fields Please fill them before pressing the button,");
                    return;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error no: " + ex.Message);
            }

        }

        //RELEVANT FOR EDIT STUDNET PANNEL 
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void student_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=csharp;";
            string Query = "select * from gym.student where id='" + student_search.Text + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

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
                    password = sPassword;
                    DateTime birthdate = Convert.ToDateTime(myReader.GetString("birthday"));
                    DateTime startDate = Convert.ToDateTime(myReader.GetString("startdate"));
                    DateTime EndDate = Convert.ToDateTime(myReader.GetString("enddate"));
                    DateTime medCert = Convert.ToDateTime(myReader.GetString("medcert"));
                    id = Convert.ToInt32(sId);
                    id_box.Text = sId;
                    firstname_box.Text = sFirstname;
                    lastname_box.Text = sLastname;
                    email_box.Text = sEmail;
                    tb_username.Text = sUsername;
                    birth_date.Value = birthdate;
                    start_date.Value = startDate;
                    end_date.Value = EndDate;
                    med_cart_date.Value = medCert;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

         
       
       public void fillcombo()
       {
            DataTable dt = new DataTable();
            try
            {
                MySQL.Select(dt, "student");
                foreach (DataRow row in dt.Rows)
                {
                    this.student_search.Items.Add(row["id"].ToString());
                }
            }
        
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
       }

       private void gButton6_Click(object sender, EventArgs e)
       {

       }

       private void EditStudentPannel_Paint(object sender, PaintEventArgs e)
       {

       }


        /*
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=csharp;";
            string Query = "select * from gym.student where id='" + student_search.Text + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

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
                    password = sPassword;
                    DateTime birthdate = Convert.ToDateTime(myReader.GetString("birthday"));
                    DateTime startDate = Convert.ToDateTime(myReader.GetString("startdate"));
                    DateTime EndDate = Convert.ToDateTime(myReader.GetString("enddate"));
                    DateTime medCert = Convert.ToDateTime(myReader.GetString("medcert"));
                    id = Convert.ToInt32(sId);
                    id_box.Text = sId;
                    firstname_box.Text = sFirstname;
                    lastname_box.Text = sLastname;
                    email_box.Text = sEmail;
                    tb_username.Text = sUsername;
                    birth_date.Value = birthdate;
                    start_date.Value = startDate;
                    end_date.Value = EndDate;
                    med_cart_date.Value = medCert;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void edit_by_id_Click(object sender, EventArgs e)
        {

        }
        private void resetColors()
        {
            // zreo all the label's colors
            firstName_label.ForeColor = Color.Black;
            lastName_label.ForeColor = Color.Black;
            id_label.ForeColor = Color.Black;
            mail_label.ForeColor = Color.Black;
            userName_label.ForeColor = Color.Black;
            birth_label.ForeColor = Color.Black;
            start_date_label.ForeColor = Color.Black;
            end_date_label.ForeColor = Color.Black;
            medcart_lable.ForeColor = Color.Black;

        }
        private void enter_button_Click(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Now;
            resetColors();

            try
            {
                // check id validation
                if (id_box.Text == "")
                {
                    MessageBox.Show("Please enter ID");
                    id_label.ForeColor = Color.Red;
                    return;
                }
                if (id_box.Text.Length < 9)
                {
                    MessageBox.Show("ID invalid ! Please try again");
                    id_label.ForeColor = Color.Red;
                    return;
                }
                //check name of the student
                if (firstname_box.Text == "")
                {
                    MessageBox.Show("Please enter First name");
                    firstName_label.ForeColor = Color.Red;
                    return;
                }

                //check lastname of the student
                if (lastname_box.Text == "")
                {
                    MessageBox.Show(" Please enter Last name!");
                    lastName_label.ForeColor = Color.Red;
                    return;
                }
                //check email valitiy
                if (email_box.Text != "")
                {
                    Regex r = new Regex(@"[\w-]+@([\w-]+\.)+[\w-]+");
                    if (!r.IsMatch(email_box.Text))
                    {
                        MessageBox.Show("Email invalid , Press correct email ", "ERROR", MessageBoxButtons.OK);
                        email_box.ResetText();
                        email_box.Focus();
                        mail_label.ForeColor = Color.Red;
                        return;
                    }
                }
                // check username
                if (tb_username.Text == "")
                {
                    MessageBox.Show("Please enter user name ");
                    return;
                }
                //check validaty of dates
                if (now.Date <= birth_date.Value.Date)
                {
                    MessageBox.Show("Birth date invalid , please try again!");
                    birth_label.ForeColor = Color.Red;
                    birth_date.Focus();
                    return;
                }

               
                if (med_cart_date.Value.Date > start_date.Value.Date && med_cart_date.Value.Date < end_date.Value.Date)
                {
                    MessageBox.Show(" Medical certificate is valid but has to update the certificate for the duration of the subscription ");
                }
                if (med_cart_date.Value.Date < start_date.Value.Date)
                {
                    MessageBox.Show(" Medical certificate is not valid medical certificate must be brought immediate");
                }


              

                if (id_box.Text != "" && firstname_box.Text != "" && lastname_box.Text != "" && birth_date.Value.Date.ToString("yyyy-MM-dd") != ""
                    && start_date.Value.Date.ToString("yyyy-MM-dd") != "" && end_date.Value.Date.ToString("yyyy-MM-dd") != ""
                    && med_cart_date.Value.Date.ToString("yyyy-MM-dd") != "" && email_box.Text != "")
                {
                    this.id = Convert.ToInt32(id_box.Text);
                    this.firstName = firstname_box.Text;
                    this.LastName = lastname_box.Text;
                    this.email = email_box.Text;
                    this.username = tb_username.Text;
                    string insert = String.Format("{0},'{1}','{2}','{3}','{4}','{5}',{6},'{7}','{8}','{9}','{10}'", id, firstName,
                        LastName, email, username,password, permission, birth_date.Value.Date.ToString("yyyy-MM-dd"),
                        start_date.Value.Date.ToString("yyyy-MM-dd"), end_date.Value.Date.ToString("yyyy-MM-dd"),
                        med_cart_date.Value.Date.ToString("yyyy-MM-dd"));
                    Student.Delete(id.ToString());
                    MySQL.Insert("student", "id,firstname,lastname,email,username,password,permission,birthday,startdate,enddate,medcert", insert);
                    MessageBox.Show("Details have been update succesfully ");
                }
                else
                {
                    MessageBox.Show("Incomplete fields Please fill them before pressing the button,");
                    return;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error no: " + ex.Message);
            }

        }

        private void id_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
         
         
         
         */



    }
}
