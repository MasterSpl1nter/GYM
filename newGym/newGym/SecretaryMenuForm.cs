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
        string email; 
        string username; 
        string password; 
        int permission = 0;
        DateTime now = DateTime.Now;
        int ret;
        

        public SecretaryMenu()
        {
            InitializeComponent();
            helloLabel.Text = "" + SingleUser.Instance.get_user().FirstName + " " + SingleUser.Instance.get_user().LastName;
            makeAllInvisible();
        }

        private void makeAllInvisible(){
            AddStudentPannel.Visible = false;
            EditStudentPannel.Visible = false;
            DeleteStudentPanel.Visible = false;
            AddStudentToClassPannel.Visible = false;
            RemoveStudentFromClassPannel.Visible = false;
    
        }


        private void addStudentButton_Click(object sender, EventArgs e)
        {
            makeAllInvisible();
            AddStudentPannel.Visible = true;
        }

        private void editStudentButton_Click(object sender, EventArgs e)
        {
            makeAllInvisible();

            EditStudentPannel.Visible = true;
            fillcombo(EditStudentCombobox);
        }

        private void removeStudentButton_Click(object sender, EventArgs e)
        {
            makeAllInvisible();

            DeleteStudentPanel.Visible = true;
            
            fillcombo(DeleteStudentCombobox);
        }

        private void studentToClassButton_Click(object sender, EventArgs e)
        {
            makeAllInvisible();
            AddStudentToClassPannel.Visible = true;
            
            DataTable dt = new DataTable();
            MySQL.Query(dt, "SELECT class.id,class.name,class.room,classtime.starttime,classtime.endtime FROM class INNER JOIN classtime ON class.id=classtime.classid");
            ClassDataGrid.Columns.Clear();
            ClassDataGrid.DataSource = dt;


            fillcombo(StudentIDComboBox);
            fillcombo2(ClassIDComboBox);
        }

        private void removeStudentFromClassBotton_Click(object sender, EventArgs e)
        {
            makeAllInvisible();
            RemoveStudentFromClassPannel.Visible = true;

            fill_combo_and_dt_remove_Student_from_class();
           

        }

        private void fill_combo_and_dt_remove_Student_from_class()
        {
            fillcombo(StudentCombo);

            DataTable dt = new DataTable();
            MySQL.Query(dt, "select student.id,class.name,classtime.starttime,classtime.endtime from student INNER JOIN studentclass on student.id=studentclass.studentid INNER JOIN classtime ON studentclass.classid=classtime.classid INNER JOIN class ON class.id = studentclass.classid");
            StudentClassDataGrid.Columns.Clear();
            StudentClassDataGrid.DataSource = dt;
        }

        private void shiftsButton_Click(object sender, EventArgs e)
        {

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
                int retval = MySQL.Insert("student", "id,firstname,lastname,email,username,password,permission,birthday,startdate,enddate,medcert", insert);
                if (retval == 0)
                    MessageBox.Show("Details have been added successfully ");
                else if (retval == 1062)
                    MessageBox.Show("Student with this ID or Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("ERROR #" + retval);

            }
            else
            {
                MessageBox.Show("Incomplete fields Please fill them before pressing the button,");
                return;
            }

        }

        //RELEVANT FOR EDIT Student PANNEL 

        private void student_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=csharp;";
            string Query = "select * from gym.student where id='" + EditStudentCombobox.Text + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())     //adding names to textboxes
                {
                    idTextbox.Text = myReader.GetInt32("id").ToString();        //convert int to string
                    firstNameTextbox.Text = myReader.GetString("firstname");
                    lastNameTextBox.Text = myReader.GetString("lastname");
                    emailTextbox.Text = myReader.GetString("email");
                    usernameTextBox.Text = myReader.GetString("username");
                    passwordTextBox.Text = myReader.GetString("password");

                    bDayDatepicker.Value = Convert.ToDateTime(myReader.GetString("birthday"));
                    stratDatepicker.Value = Convert.ToDateTime(myReader.GetString("startdate"));
                    endDatepicker.Value = Convert.ToDateTime(myReader.GetString("enddate"));
                    medDatePicker.Value = Convert.ToDateTime(myReader.GetString("medcert"));
                    
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditStudApply_Click(object sender, EventArgs e)
        {
            
            DateTime startDate = DateTime.Now;
            resetColors1();

            try
            {
                // check id validation
                if (idTextbox.Text == "")
                {
                    MessageBox.Show("Please enter ID");
                    id_label.ForeColor = Color.Red;
                    return;
                }
                if (idTextbox.Text.Length < 9)
                {
                    MessageBox.Show("ID invalid ! Please try again");
                    id_label.ForeColor = Color.Red;
                    return;
                }
                //check name of the student
                if (firstNameTextbox.Text == "")
                {
                    MessageBox.Show("Please enter First name");
                    firstName_label.ForeColor = Color.Red;
                    return;
                }

                //check lastname of the student
                if (lastNameTextBox.Text == "")
                {
                    MessageBox.Show(" Please enter Last name!");
                    lastName_label.ForeColor = Color.Red;
                    return;
                }
                
                
                // check username
                if (usernameTextBox.Text == "")
                {
                    MessageBox.Show("Please enter user name ");
                    return;
                }
                //check validaty of dates
                if (DateTime.Now <= birth_date.Value.Date)
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

                if ( (idTextbox.Text!="" ) && ( firstNameTextbox.Text !="") && (lastNameTextBox.Text!="" )&&( emailTextbox.Text!="") && (usernameTextBox.Text!= "") && (passwordTextBox.Text!="") )
                {

                    string insert = String.Format("{0},'{1}','{2}','{3}','{4}','{5}',{6},'{7}','{8}','{9}','{10}'", idTextbox.Text, firstNameTextbox.Text, lastNameTextBox.Text, emailTextbox.Text, usernameTextBox.Text, passwordTextBox.Text , 1, bDayDatepicker.Value.Date.ToString("yyyy-MM-dd"), stratDatepicker.Value.Date.ToString("yyyy-MM-dd"), endDatepicker.Value.Date.ToString("yyyy-MM-dd"), medDatePicker.Value.Date.ToString("yyyy-MM-dd"));
                    Student.Delete(idTextbox.Text);
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

        private void resetColors1()
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

        private void id_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
        
        //handled
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Student.Delete(DeleteStudentCombobox.Text);
           
            DeleteStudentCombobox.Text = "";
            MessageBox.Show("The student deleted succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            removeStudentButton_Click(null,null);
        }


        public void fillcombo(ComboBox combo)
        {
            combo.Items.Clear();
            DataTable dt = new DataTable();
            try
            {
                MySQL.Select(dt, "student");
                foreach (DataRow row in dt.Rows)
                {
                    combo.Items.Add(row["id"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void fillcombo2(ComboBox combo)
        {
            combo.Items.Clear();
            DataTable dt = new DataTable();
            try
            {
                MySQL.Select(dt, "classtime");
                foreach (DataRow row in dt.Rows)
                {
                    if(Convert.ToDateTime( row["starttime"].ToString() ) > DateTime.Now  )
                        combo.Items.Add(row["classid"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //handled
        private void AddStudentToClassButton_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            string classid = ClassIDComboBox.Text;
            string Studentid = StudentIDComboBox.Text;


            if(ClassIDComboBox.Text == "" ||  StudentIDComboBox.Text == ""){

                MessageBox.Show("not all fields are filled");
                return;
            }

            
            MySQL.Query(dt, "select student.id,classtime.starttime,classtime.endtime from student INNER JOIN studentclass on student.id=studentclass.studentid INNER JOIN classtime ON studentclass.classid=classtime.classid WHERE student.id=" + Studentid);
            MySQL.Query(dt1, "select starttime,endtime from classtime WHERE classid=" + classid);

            if ( dt.Rows.Count == 0 || dt1.Rows.Count == 0)
            {
                ret = Student.addStudToClass(ClassIDComboBox.Text, StudentIDComboBox.Text);
                ClassIDComboBox.Text = StudentIDComboBox.Text = "";
                studentToClassButton_Click(null, null);
                MessageBox.Show("The Course was added successfully");
            }
            else
            {

                DateTime StartB = Convert.ToDateTime(dt.Rows[0]["starttime"]);
                DateTime EndB = Convert.ToDateTime(dt.Rows[0]["endtime"]);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DateTime StartA = Convert.ToDateTime(dt.Rows[i]["starttime"]);
                    DateTime EndA = Convert.ToDateTime(dt.Rows[i]["endtime"]);
                    if (StartA < EndB && StartB < EndA)
                    {

                    MessageBox.Show("You are already joined to a class that takes place at the same time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        studentToClassButton_Click(null, null);
                        return;
                    }
                }

            }

            Student.addStudToClass(ClassIDComboBox.Text, StudentIDComboBox.Text);
            ClassIDComboBox.Text = StudentIDComboBox.Text = "";
            studentToClassButton_Click(null,null);
            MessageBox.Show("The Course was added successfully");

        }

        private void StudentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            relevantClasses.Items.Clear();

            DataTable dt = new DataTable();
            try
            {
                MySQL.Select(dt, "studentclass");
                foreach (DataRow row in dt.Rows)
                {
                    if (row["studentid"].ToString() == StudentCombo.Text)
                    {
                        relevantClasses.Items.Add(row["classid"].ToString());
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //handled
        private void RemoveStudentFromClassButton_Click(object sender, EventArgs e)
        {
            Student.removeStudentFromClass(StudentCombo.Text, relevantClasses.Text);

            StudentCombo.Text = relevantClasses.Text = "";

            fill_combo_and_dt_remove_Student_from_class();
            MessageBox.Show("The student was removed successfully");

        }


    }
}
