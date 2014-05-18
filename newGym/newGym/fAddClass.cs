using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newGym
{
    public partial class fAddClass : Form
    {
        private TimeSpan starttime;
        private TimeSpan endtime;
        private DateTime startClass,endClass;
        private Boolean timeSelected = false;
        private Boolean dateSelected = false;
        private Boolean allowNewSchedule = false;
        DateTime classDate;
        private int count = 0;
        DataTable dtmp;
        DataTable dt;
        List<DateTime> arr;
        private int id = -1;
        private DateTimePicker tp;
        public fAddClass()
        {
            InitializeComponent();
            LoadRoomId();
            LoadGuideId();
            dt = new DataTable();
            monthCalendar1.MaxSelectionCount = 1;
            button5.Visible = false;
            UpdateCalendar();
            InitTimePicker();
        }
        public fAddClass(int id)
        {
            this.id = id;
            InitializeComponent();
            dt = new DataTable();
            gidLabel.Visible = true;
            comboBox2.Visible = true;
            monthCalendar1.MaxSelectionCount = 1;
            UpdateCalendar();
            button5.Visible = false;
            LoadRoomId();
            LoadGuideId();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num;
                bool result = Int32.TryParse(textBox1.Text, out num);

                if (dateSelected && timeSelected)
                {
                    startClass = new DateTime(classDate.Year, classDate.Month, classDate.Day, starttime.Hours, starttime.Minutes, 0);
                    endClass = new DateTime(classDate.Year, classDate.Month, classDate.Day, endtime.Hours, endtime.Minutes, 0);

                    if (result)
                    {
                        if (textBox1.Text == "" || textBox2.Text == "")
                        {
                            MessageBox.Show("Not all details field.");
                            return;
                        }
                        if ((endClass.DayOfWeek == DayOfWeek.Saturday) ||
                             ((endClass.DayOfWeek < DayOfWeek.Friday && endClass.DayOfWeek >= DayOfWeek.Sunday) && !(endClass.Hour < 23 && endClass.Hour > 7)) ||
                                  (endClass.DayOfWeek == DayOfWeek.Friday && !(endClass.Hour < 14 && endClass.Hour > 7)))
                        {
                            MessageBox.Show("Gym Opening Hours. Sunday to Thursday: 07:00am - 23:00pm. Friday: 07:00am - 14:00pm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        var sub = startClass.Subtract(endClass);

                        if (sub.TotalHours > 0)
                        {
                            MessageBox.Show("Invalid Start/End date.");
                            return;
                        }
                        else
                        {

                            fClass myclass = new fClass(int.Parse(textBox1.Text), textBox2.Text, int.Parse(comboBox1.Text), int.Parse(comboBox2.Text), 0, int.Parse(textBox3.Text),
                                startClass.ToString("yyyy-MM-dd HH:mm:ss"), endClass.ToString("yyyy-MM-dd HH:mm:ss"));

                            if (myclass.SaveData() && myclass.SaveDate())       //TO-CODE via timeBetween() , func saveDATA() will add himself before is really allowed
                            {
                                MessageBox.Show("The class was add successfully, Now you can add another Schedule(NOT WORKING YET)");
                                allowNewSchedule = true;
                                button5.Visible = true;
                                button1.Visible = false;
                                dateSelected = false;
                                timeSelected = false;
                                //this.Close();
                            }
                            else
                                MessageBox.Show("הפרט לא נוסף");
                        }
                    }
                    else
                        MessageBox.Show("חזור על הפעולה שנית");
                }///if(a&b)

                else
                    if (!dateSelected)
                        MessageBox.Show("Date for class was not selected");
                    if (!timeSelected)
                        MessageBox.Show("Time for class was not selected");
            }//#try

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(comboBox1.Text);
            // LoadInfoById(customerId);
            LoadCapicity(customerId);
        }


        //Load room ID to a combobox
        private void LoadRoomId()
        {
            var connectionString = @"server=localhost;userid=root;password=csharp;database=gym";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT Id FROM room";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        //Iterate through the rows and add it to the combobox's items
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader.GetString("Id"));

                        }
                    }
                }
            }
        }

        private void LoadCapicity(int id)
        //max inside room
        {
            //var tempid =0;
            var connectionString = @"server=localhost;userid=root;password=csharp;database=gym";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT id, capacity FROM room WHERE id=" + id;
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // if ( int.Parse(reader.GetString("id")) == id)
                            textBox3.Text = (String)reader.GetString("capacity");
                        }
                    }
                }
            }


        }





        //Load GuideID to a combobox
        private void LoadGuideId()
        {
            var connectionString = @"server=localhost;userid=root;password=csharp;database=gym";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT Id FROM guide";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        //Iterate through the rows and add it to the combobox's items
                        while (reader.Read())
                        {
                            comboBox2.Items.Add(reader.GetString("Id"));
                        }
                    }
                }
            }
        }


     


        private void UpdateCalendar()
        {
            MySQL.Query(dt, "SELECT class.id,class.name,class.room,classtime.starttime,classtime.endtime FROM class INNER JOIN classtime ON class.id=classtime.classid");
            arr = new List<DateTime>();
            for (int i = 0, j = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToDateTime(dt.Rows[i]["starttime"].ToString()).Month == DateTime.Now.Month)
                {
                    arr.Add(Convert.ToDateTime(dt.Rows[i]["starttime"]));
                }
            }
            this.monthCalendar1.MonthlyBoldedDates = (DateTime[])arr.ToArray();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
            dtmp = new DataTable();
            dtmp.Clear();
            dtmp.Columns.Add("id", typeof(int));
            dtmp.Columns.Add("name", typeof(string));
            dtmp.Columns.Add("room", typeof(string));
            dtmp.Columns.Add("starttime", typeof(DateTime));
            dtmp.Columns.Add("endtime", typeof(DateTime));
            foreach (DataRow dr in dt.Rows)
            {

                if (dr["starttime"].ToString().Contains(monthCalendar1.SelectionStart.ToShortDateString()))
                {
                    dtmp.Rows.Add(dr.ItemArray);
                }
            }
            if (dtmp.Rows.Count == 1)
            {
                Updateitems(0);
                hScrollBar1.Visible = false;
            }
            if (dtmp.Rows.Count > 1)
            {
                Updateitems(0);
                hScrollBar1.Visible = true;
            }
            else if (dtmp.Rows.Count == 0)
            {
                idLabel.Text = "";
                nameLabel.Text = "";
                ParticiLabel.Text = "";
                roomNumLabel.Text = "";
                starttimeLabel.Text = "";
                endtimeLabel.Text = "";
                tothourLabel.Text = "";
               // paymentLabel.Text = "";
                hScrollBar1.Visible = false;
            }

         //  DateTime cal = monthCalendar1.g;
             

        }

           private void Updateitems(int i)
        {
            idLabel.Text = dtmp.Rows[i]["id"].ToString();
            int studentsnum = MySQL.count("SELECT COUNT(studentid) FROM studentclass where classid=" + idLabel.Text);
            nameLabel.Text = dtmp.Rows[i]["name"].ToString();
            ParticiLabel.Text = studentsnum.ToString();
            roomNumLabel.Text = dtmp.Rows[i]["room"].ToString();
            starttimeLabel.Text = dtmp.Rows[i]["starttime"].ToString().Split(' ')[1];
            endtimeLabel.Text = dtmp.Rows[i]["endtime"].ToString().Split(' ')[1];
            tothourLabel.Text = DateTime.Parse(((Convert.ToDateTime(dtmp.Rows[i]["endtime"]) - Convert.ToDateTime(dtmp.Rows[i]["starttime"]))).ToString()).ToString("HH:mm");
            //paymentLabel.Text = (guide.salary * (Convert.ToDouble(TimeSpan.Parse(tothourLabel.Text).TotalHours) + ((TimeSpan.Parse(tothourLabel.Text).TotalMinutes) > 0 ? (TimeSpan.Parse(tothourLabel.Text).TotalMinutes - TimeSpan.Parse(tothourLabel.Text).TotalHours * 60) / 60 : 0))).ToString("#.00$");
        }

         


        private void InitTimePicker()
        {
            tp = new DateTimePicker();
            tp.Format = DateTimePickerFormat.Time;
            tp.ShowUpDown = true;
            tp.Location = new Point(200, 350);
            tp.Width = 100;
            Controls.Add(tp);


            //tp.
        }



        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            
             DateTime classDateTemp = monthCalendar1.SelectionStart;
             if (classDate != null)
             {
                 if (classDateTemp.CompareTo(DateTime.Now) == 1)
                 {
                     dr = MessageBox.Show("You have selected:" + classDateTemp.ToLongDateString(), "Vaildation", MessageBoxButtons.OKCancel);
                     if (dr == DialogResult.OK)
                     {
                         classDate = classDateTemp;
                         dateSelected = true;
                     }

                     if (dr == DialogResult.Cancel)
                     {
                         dateSelected = false;
                     }

                     // TO CODE
                     // handle the TIME CHooser BEFORE
                 }
                 else
                 MessageBox.Show("Invaild Date selected");
             }
        }


        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
            int i = count % dtmp.Rows.Count;
            Updateitems(i);
            count++;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dateSelected)
            {
                faddclassexp exp = new faddclassexp();
                exp.ShowDialog();           //Time Chooser
                if (exp.getEndTime().TotalMinutes != 0)
                    endtime = exp.getEndTime();
                if (exp.getStartTime().TotalMinutes != 0)
                    starttime = exp.getStartTime();
                timeSelected = true;
            }
            else
            {
                MessageBox.Show("Please first pick a date");
                timeSelected = false;
            }
        }

        private void button5_Click(object sender, EventArgs e) //        addNewSchedule
        {
            /* TOCODE
            if (allowNewSchedule)
            {

                if (dateSelected && timeSelected)
                {
                    startClass = new DateTime(classDate.Year, classDate.Month, classDate.Day, starttime.Hours, starttime.Minutes, 0);
                    endClass = new DateTime(classDate.Year, classDate.Month, classDate.Day, endtime.Hours, endtime.Minutes, 0);


                }


                else
                    if (!dateSelected)
                        MessageBox.Show("Date for class was not selected");
                if (!timeSelected)
                    MessageBox.Show("Time for class was not selected");

            }
             */
        }










        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void fAddClass_Load(object sender, EventArgs e)
        {

        }

      
    }

}
