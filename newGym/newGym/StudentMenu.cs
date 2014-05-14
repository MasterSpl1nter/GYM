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
    public partial class StudentMenu : Form
    {

        //int id = SingleUser.Instance.get_user().Id;
        //int permission = 0;
        //DateTime birthday;
        //DateTime startdate;
        //DateTime enddate;
        //DateTime medcert;

        public StudentMenu()
        {
            InitializeComponent();
            helloLabel.Text = "Hello, " + SingleUser.Instance.get_user().FirstName + " " + SingleUser.Instance.get_user().LastName;
            EditDetail_panel.Visible = false;
            addCourse_panel.Visible = false;
            cancelCourse_panel.Visible = false;


        }


        private void StudentMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            addCourse_panel.Visible = false;
            cancelCourse_panel.Visible = false;
            EditDetail_panel.Visible = true;
            //connect to the DataTable
            string id = SingleUser.Instance.get_user().Id.ToString();
            string constring = "datasource=localhost; port=3306; username=root; password=csharp;";
            string Query = "select * from gym.student where id='" + id + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            //fill all details
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                myReader.Read();
                firstname_box.Text = myReader.GetString("firstname");
                lastname_box.Text = myReader.GetString("lastname");
                email_box.Text = myReader.GetString("email");
                username_box.Text = myReader.GetString("username");
                password_box.Text = myReader.GetString("password");
                //int permission = Convert.ToInt32(myReader.GetString("permission");
                //DateTime birthdate = Convert.ToDateTime(myReader.GetString("birthday"));
                //DateTime startDate = Convert.ToDateTime(myReader.GetString("startdate"));
                //DateTime EndDate = Convert.ToDateTime(myReader.GetString("enddate"));
                //DateTime medCert = Convert.ToDateTime(myReader.GetString("medcert"));
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void firstname_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetColors()
        {
            // zreo all the label's colors
            firstName_label.ForeColor = Color.Black;
            lastName_label.ForeColor = Color.Black;
            mail_label.ForeColor = Color.Black;
            userName_label.ForeColor = Color.Black;
            password_label.ForeColor = Color.Black;
        }

        private void editDetail_button_Click(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Now;
            resetColors();

            //check name of the student
            if (firstname_box.Text == "")
            {
                MessageBox.Show("Please enter First name");
                firstName_label.ForeColor = Color.Red;
                firstname_box.Focus();
                return;
            }

            //check lastname of the student
            if (lastname_box.Text == "")
            {
                MessageBox.Show(" Please enter Last name!");
                lastName_label.ForeColor = Color.Red;
                lastname_box.Focus();
                return;
            }
            //check email valitiy
            if (email_box.Text != "")
            {
                Regex r = new Regex(@"[\w-]+@([\w-]+\.)+[\w-]+");
                if (!r.IsMatch(email_box.Text))
                {
                    MessageBox.Show("Email invalid , Press correct email ");
                    email_box.ResetText();
                    email_box.Focus();
                    mail_label.ForeColor = Color.Red;
                    return;
                }
            }
            // check username
            if (username_box.Text == "")
            {
                MessageBox.Show("Please enter user name ");
                userName_label.ForeColor = Color.Red;
                username_box.Focus();
                return;
            }
            //Update the DataBase

            //string insert = String.Format("{0},'{1}','{2}','{3}','{4}','{5}',{6},'{7}','{8}','{9}','{10}'", id, firstname_box.Text,
            //            lastname_box.Text, email_box.Text, username_box.Text, password_box.Text, permission, birth_date.Value.Date.ToString("yyyy-MM-dd"),
            //            start_date.Value.Date.ToString("yyyy-MM-dd"), end_date.Value.Date.ToString("yyyy-MM-dd"),
            //            med_cart_date.Value.Date.ToString("yyyy-MM-dd"));


        }
    }
}
