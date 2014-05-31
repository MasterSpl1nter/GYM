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


        //initalization
        public StudentMenu()
        {
            InitializeComponent();
            helloLabel.Text = "" + SingleUser.Instance.get_user().FirstName + " " + SingleUser.Instance.get_user().LastName;
            makeAllInvisible();
            InitializeCalendar();
        }

        private void InitializeCalendar()
        {
            DataTable dt = new DataTable();
            DateTime[] arr;
            int i = 0;
            try
            {
                //well this is a tought querry , pull from the student class all the classes that trhe student is singed up for and from those grab the name room guideid and id of the class
                int ret = MySQL.Query(dt, "SELECT classid, starttime , endtime FROM classtime WHERE (classid) IN (SELECT classid FROM studentclass WHERE studentid = " + SingleUser.Instance.get_user().Id.ToString() + ");");
                if (ret != 0)
                {
                    MessageBox.Show("the mysql query failed");
                    return;
                }

                arr = new DateTime[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {

                    arr[i] = Convert.ToDateTime(row["starttime"].ToString());
                    i++;
                }
                StudnetClassesCalendar.MonthlyBoldedDates = arr;
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void makeAllInvisible()
        {
            EditDetail_panel.Visible = false;
            addCourse_panel.Visible = false;
            cancelCourse_panel.Visible = false;
            ExercisePannel.Visible = false;
        }


        //edit data
        private void edit_button_Click(object sender, EventArgs e)
        {
            makeAllInvisible();

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


            if ((firstname_box.Text != "") && (lastname_box.Text != "") && (email_box.Text != "") && (username_box.Text != "") && (password_box.Text != ""))
            {

                Student a = (Student)SingleUser.Instance.get_user();

                string insert = String.Format("{0},'{1}','{2}','{3}','{4}','{5}',{6},'{7}','{8}','{9}','{10}'",
                    a.getid(), firstname_box.Text, lastname_box.Text, email_box.Text, username_box.Text, password_box.Text, 1, a.getbday().Date.ToString("yyyy-MM-dd"),
                    a.getStartDate().Date.ToString("yyyy-MM-dd"), a.getEndDate().Date.ToString("yyyy-MM-dd"), a.getMedCert().Date.ToString("yyyy-MM-dd"));
                ((Student)SingleUser.Instance.get_user()).Delete(a.getid());
                int ret = MySQL.Insert("student", "id,firstname,lastname,email,username,password,permission,birthday,startdate,enddate,medcert", insert);
                if (ret != 0)
                {
                    MessageBox.Show("the mysql query failed");
                    return;
                }
                MessageBox.Show("Details have been update succesfully ");
            }
            else
            {
                MessageBox.Show("Incomplete fields Please fill them before pressing the button,");
                return;
            }
            //Update the DataBase
            /*
            string insert = String.Format("{0},'{1}','{2}','{3}','{4}','{5}',{6},'{7}','{8}','{9}','{10}'", a.Id, firstname_box.Text,
                        lastname_box.Text, email_box.Text, username_box.Text, password_box.Text, 1, a.getbday().Date.ToString("yyyy-MM-dd"),
                        a.getStartDate().Date.ToString("yyyy-MM-dd"), a.getEndDate().Date.ToString("yyyy-MM-dd"),
                        a.getbMedCert().Date.ToString("yyyy-MM-dd"));

            */
        }


        //add course
        private void add_course_Click(object sender, EventArgs e)
        {
            makeAllInvisible();
            addCourse_panel.Visible = true;

            DataTable dt = new DataTable();
            int ret = MySQL.Select(dt, "class inner join classtime on class.id = classtime.classid");
            if (ret != 0)
            {
                MessageBox.Show("the mysql query failed");
            }
            ClassDataGrid.Columns.Clear();
            ClassDataGrid.DataSource = dt;

            fillcombo2(ClassIDComboBox);

        }

        public void fillcombo2(ComboBox combo)
        {
            combo.Items.Clear();
            DataTable dt = new DataTable();
            try
            {
                MySQL.Select(dt, "select class.id,classtime.starttime,classtime.endtime from student INNER JOIN studentclass on student.id=studentclass.studentid INNER JOIN classtime ON studentclass.classid=classtime.classid");
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

        private void AddStudentToClassButton_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            string classid = ClassIDComboBox.Text;
            string Studentid = SingleUser.Instance.get_user().Id.ToString();
            
            ClassIDComboBox.Text = "";
            
            int ret = MySQL.Query(dt, "select class.id,classtime.starttime,classtime.endtime from student INNER JOIN studentclass on student.id=studentclass.studentid INNER JOIN classtime ON studentclass.classid=classtime.classid WHERE student.id=" + Studentid);
            if (ret != 0)
            {
                MessageBox.Show("the mysql query failed");
                return;
            }
            ret = MySQL.Query(dt1, "select starttime,endtime from classtime WHERE classid=" + classid);
            if (ret != 0)
            {
                MessageBox.Show("the mysql query failed");
                return;
            }
            if (dt.Rows.Count == 0 || dt1.Rows.Count == 0)
            {

            }
            else
            {
                DateTime StartB = Convert.ToDateTime(dt1.Rows[0]["starttime"]);
                DateTime EndB = Convert.ToDateTime(dt1.Rows[0]["endtime"]);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DateTime StartA = Convert.ToDateTime(dt.Rows[i]["starttime"]);
                    DateTime EndA = Convert.ToDateTime(dt.Rows[i]["endtime"]);
                    if (StartA < EndB && StartB < EndA)
                    {

                        MessageBox.Show("You are already joined to a class that takes place at the same time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        add_course_Click(null, null);
                        return;
                    }
                }
                ClassIDComboBox.Text = "";
            }

            ((Student)SingleUser.Instance.get_user()).addStudToClass(classid, ((Student)SingleUser.Instance.get_user()).getid());
            MessageBox.Show("The Course was added successfully");

            add_course_Click(null, null);

        }

        private void Cancel_course_Click(object sender, EventArgs e)
        {
            makeAllInvisible();
            cancelCourse_panel.Visible = true;
            fillCombo_and_dt_remove_student();

        }

        private void RemoveStudentFromClassButton_Click(object sender, EventArgs e)
        {

            int ret = ((Student)( SingleUser.Instance.get_user())).removeStudentFromClass(SingleUser.Instance.get_user().Id.ToString(), relevantClasses.Text);
            if (ret == 0)
                MessageBox.Show("you were removed from the course");

            else
                MessageBox.Show("you weren't removed from the course");

            fillCombo_and_dt_remove_student();


        }


        private void fillCombo_and_dt_remove_student()
        {

            relevantClasses.Items.Clear();
            relevantClasses.Text = "";
            DataTable dt = new DataTable();
            try
            {
                //well this is a tought querry , pull from the student class all the classes that the student is singed up for and from those grab the name room guideid and id of the class
                int ret = MySQL.Query(dt, "SELECT class.id , class.name , class.room,class.guideid , classtime.starttime,classtime.endtime FROM class inner join classtime inner join studentclass on studentclass.classid = class.id = classtime.classid where studentid =" + SingleUser.Instance.get_user().Id.ToString() + ";");
                if (ret != 0)
                {
                    MessageBox.Show("the mysql query failed");
                    return;
                }
                foreach (DataRow row in dt.Rows)
                {
                    relevantClasses.Items.Add(row["id"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            StudnetClassDataGrid.Columns.Clear();
            StudnetClassDataGrid.DataSource = dt;
            relevantClasses.Text = "";

        }

        //Exercise 
        private void ExerciseButton_Click(object sender, EventArgs e)
        {
            makeAllInvisible();
            ExercisePannel.Visible = true;
            ExerciseDataGrid.Columns.Clear();

            DataTable dt = new DataTable();

            int ret = MySQL.Query(dt, "select training.name AS 'Training name',appliance.name AS Appliance,sets AS Sets,repeats AS Repeats from studenttraining join training on studenttraining.trainingid = training.id join appliance on appliance.id=training.appliance where studenttraining.studentid= " + SingleUser.Instance.get_user().Id.ToString() + ";");

            if (ret != 0)
            {
                MessageBox.Show("the mysql query failed");
                return;
            }

            ExerciseDataGrid.DataSource = dt;


        }

        private void ClassIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }






    }
}
