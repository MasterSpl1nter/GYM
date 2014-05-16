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

        //initalization
        public StudentMenu()
        {
            InitializeComponent();
            helloLabel.Text = "Hello, " + SingleUser.Instance.get_user().FirstName + " " + SingleUser.Instance.get_user().LastName;
            makeAllInvisible();
            InitializeCalendar();
        }

        private void InitializeCalendar()
        {
            DataTable dt = new DataTable();
            DateTime[] arr;
            int i = 0 ;
            try
            {
                //well this is a tought querry , pull from the student class all the classes that trhe student is singed up for and from those grab the name room guideid and id of the class
                MySQL.Query(dt, "SELECT classid, starttime , endtime FROM classtime WHERE (classid) IN (SELECT classid FROM studentclass WHERE studentid = " + SingleUser.Instance.get_user().Id.ToString() + ");");
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
            //Update the DataBase

            //string insert = String.Format("{0},'{1}','{2}','{3}','{4}','{5}',{6},'{7}','{8}','{9}','{10}'", id, firstname_box.Text,
            //            lastname_box.Text, email_box.Text, username_box.Text, password_box.Text, permission, birth_date.Value.Date.ToString("yyyy-MM-dd"),
            //            start_date.Value.Date.ToString("yyyy-MM-dd"), end_date.Value.Date.ToString("yyyy-MM-dd"),
            //            med_cart_date.Value.Date.ToString("yyyy-MM-dd"));


        }

       
        //add course
        private void add_course_Click(object sender, EventArgs e)
        {
            makeAllInvisible();
            addCourse_panel.Visible = true;


            DataTable dt = new DataTable();
            MySQL.Select(dt, "class");
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
                MySQL.Select(dt, "class");
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

            Student.addStudToClass( ClassIDComboBox.Text, SingleUser.Instance.get_user().Id.ToString());
            add_course_Click(null,null);
        }

        private void Cancel_course_Click(object sender, EventArgs e)
        {
            makeAllInvisible();

            cancelCourse_panel.Visible = true;

            relevantClasses.Items.Clear();
            DataTable dt = new DataTable();
            try
            {
                //well this is a tought querry , pull from the student class all the classes that trhe student is singed up for and from those grab the name room guideid and id of the class
                MySQL.Query(dt, "SELECT id, name , room , guideid FROM class WHERE (id) IN (SELECT classid FROM studentclass WHERE studentid = " + SingleUser.Instance.get_user().Id.ToString() + ");");
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
        }

        private void RemoveStudentFromClassButton_Click(object sender, EventArgs e)
        {
            Student.removeStudentFromClass( SingleUser.Instance.get_user().Id.ToString() , relevantClasses.Text);
            Cancel_course_Click(null, null);


        }

        private void StudnetClassesCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        /* Nick add to Add class in Secretary and student, this checks if two classes are overlapping with each other.

        MySQL.Query(dt,"select student.id,classtime.starttime,classtime.endtime from student INNER JOIN studentclass on student.id=studentclass.studentid INNER JOIN classtime ON studentclass.classid=classtime.classid WHERE student.id=" + Studentid);
        MySQL.Query(dt1,"select starttime,endtime from classtime WHERE classid=" + classid);
        DateTime StartB=Convert.ToDateTime(dt.Rows[0]["starttime"])
	    DateTime EndB=Convert.ToDateTime(dt.Rows[0]["endtime"])
	    for(int i=0;i<dt.Rows.Count;i++){
        	DateTime StartA=Convert.ToDateTime(dt.Rows[i]["starttime"])
		    DateTime EndA=Convert.ToDateTime(dt.Rows[i]["endttime"])
		    if(StartA<EndB && StartB<EndA){
			    //BAD: OVERLAP DATES
		    }
    	}
        */

    }
}
