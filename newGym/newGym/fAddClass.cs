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
    public partial class fAddClass : GForm
    {
        private TimeSpan starttime;
        private TimeSpan endtime;
        private DateTime startClass,endClass;
        private Boolean timeSelected = false;
        private Boolean dateSelected = false;
        Boolean idTaken = false;
        DateTime classDate;
        private int count = 0;
        DataTable dtmp;
        DataTable dt,dtt;
        List<DateTime> arr;
        private int id = -1;
        public fAddClass()
        {
            InitializeComponent();
            //this.button1.Location = new System.Drawing.Point(37, 371);
            
            LoadRoomId();
            LoadGuideId();
            dt = new DataTable();
            dtt = new DataTable();
            monthCalendar1.MaxSelectionCount = 1;
            UpdateCalendar();
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
        }
        public fAddClass(int id)
        {
            this.id = id;
            InitializeComponent();
            dt = new DataTable();
            dtt = new DataTable();
            gidLabel.Visible = true;
            gidLabel.Text = this.id.ToString();
            if (id != -1) comboBox2.Visible = false; else LoadGuideId();
            monthCalendar1.MaxSelectionCount = 1;
            UpdateCalendar();
            LoadRoomId();
            if ( comboBox1.Items.Count > 0)
            comboBox1.SelectedIndex = comboBox1.Items.Count -1 ;
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

                    if (result && !idTaken)
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
                            MessageBox.Show("Gym Opening Hours:\n. Sunday to Thursday: 07:00am - 23:00pm.\n Friday: 07:00am - 14:00pm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                            fClass myclass = new fClass(int.Parse(textBox1.Text), textBox2.Text, int.Parse(comboBox1.Text), id == -1 ? int.Parse(comboBox2.Text) : id, 0, int.Parse(textBox3.Text),
                                startClass.ToString("yyyy-MM-dd HH:mm:ss"), endClass.ToString("yyyy-MM-dd HH:mm:ss"));

                            if (myclass.SaveData() && myclass.SaveDate())
                            {
                                MessageBox.Show("The class was add successfully");
                                dateSelected = false;
                                timeSelected = false;
                                /*
                                textBox1.Clear();
                                textBox2.Clear();
                                textBox3.Clear();
                                if (comboBox1.Items.Count > 0)
                                    comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
                                if (comboBox2.Items.Count > 0)
                                    comboBox2.SelectedIndex = comboBox2.Items.Count - 1;
                                */
                                return;
                            }
                            else
                            {
                                //delete the added class
                                fDelClass mydelete = new fDelClass(int.Parse(textBox1.Text));
                                mydelete.deleteAll();
                                MessageBox.Show("Schedule not saved");
                            }
                            return;
                        }
                    }
                    else
                        MessageBox.Show("Error occourd, please try again");
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
            if (comboBox1.Text != "System.Data.DataRowView")
                LoadCapicity(int.Parse(comboBox1.Text));
        }

        //Load room ID to a combobox
        private void LoadRoomId()
        {
            dtt = new DataTable();
            MySQL.Select(dtt, "room");
            comboBox1.DataSource = dtt;
            comboBox1.DisplayMember = "id";
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
                            textBox3.Text = (String)reader.GetString("capacity");
                        }
                    }
                }
            }
        }

        //Load GuideID to a combobox
        private void LoadGuideId()
        {
            dtt = new DataTable();
            MySQL.Select(dtt, "guide");
            comboBox2.DataSource = dtt;
            comboBox2.DisplayMember = "id";
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
                Updateitems();
                hScrollBar1.Visible = false;
            }
            if (dtmp.Rows.Count > 1)
            {
                Updateitems();
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
                hScrollBar1.Visible = false;
            }
        }

           private void Updateitems(int k = 0)
        {
            if (k != 0)
            for (int i=0 ; i < dtmp.Rows.Count; i++)
            {
                    idLabel.Text = dtmp.Rows[i]["id"].ToString();
                    int studentsnum = MySQL.count("SELECT COUNT(studentid) FROM studentclass where classid=" + idLabel.Text);
                    nameLabel.Text = dtmp.Rows[i]["name"].ToString();
                    ParticiLabel.Text = studentsnum.ToString();
                    roomNumLabel.Text = dtmp.Rows[i]["room"].ToString();
                    DateTime obj1 = Convert.ToDateTime(dtmp.Rows[i]["starttime"]);
                    starttimeLabel.Text = obj1.ToString("HH:mm:ss");
                    DateTime obj2 = Convert.ToDateTime(dtmp.Rows[i]["starttime"]);
                    endtimeLabel.Text = obj2.ToString("HH:mm:ss");
                    tothourLabel.Text = DateTime.Parse(((Convert.ToDateTime(dtmp.Rows[i]["endtime"]) - Convert.ToDateTime(dtmp.Rows[i]["starttime"]))).ToString()).ToString("HH:mm");
            }
            else
            {
                int i = k;
                   idLabel.Text = dtmp.Rows[i]["id"].ToString();
                    int studentsnum = MySQL.count("SELECT COUNT(studentid) FROM studentclass where classid=" + idLabel.Text);
                    nameLabel.Text = dtmp.Rows[i]["name"].ToString();
                    ParticiLabel.Text = studentsnum.ToString();
                    roomNumLabel.Text = dtmp.Rows[i]["room"].ToString();
                    DateTime obj1 = Convert.ToDateTime(dtmp.Rows[i]["starttime"]);
                    starttimeLabel.Text = obj1.ToString("HH:mm:ss");
                    DateTime obj2 = Convert.ToDateTime(dtmp.Rows[i]["starttime"]);
                    endtimeLabel.Text = obj2.ToString("HH:mm:ss");
                    tothourLabel.Text = DateTime.Parse(((Convert.ToDateTime(dtmp.Rows[i]["endtime"]) - Convert.ToDateTime(dtmp.Rows[i]["starttime"]))).ToString()).ToString("HH:mm");
            }
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
                         dateSelected = false;
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
                exp.ShowDialog();           //Call to Time Chooser
                if (exp.getEndTime().TotalMinutes != 0)
                    endtime = exp.getEndTime();
                if (exp.getStartTime().TotalMinutes != 0)
                    starttime = exp.getStartTime();
                if (exp.windowExited())
                     timeSelected = false;
                else
                     timeSelected = true;
            }
            else
            {
                MessageBox.Show("Please first pick a date");
                timeSelected = false; 
            }
        }

       


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            try
            {
                int id = int.Parse(textBox1.Text);
                int count = MySQL.count("SELECT COUNT(id) FROM class where id=" + id);
                if (count > 0)
                {
                    label6.Visible = true;
                    idTaken = true;
                }
                else
                {
                    label6.Visible = false;
                    idTaken = false;
                }
                


            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
            else
                label6.Visible = false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gButton1_Click(object sender, EventArgs e)
        {

            try
            {
                int num;
                bool result = Int32.TryParse(textBox1.Text, out num);

                if (dateSelected && timeSelected)
                {
                    startClass = new DateTime(classDate.Year, classDate.Month, classDate.Day, starttime.Hours, starttime.Minutes, 0);
                    endClass = new DateTime(classDate.Year, classDate.Month, classDate.Day, endtime.Hours, endtime.Minutes, 0);

                    if (result && !idTaken)
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
                            MessageBox.Show("Gym Opening Hours:\n. Sunday to Thursday: 07:00am - 23:00pm.\n Friday: 07:00am - 14:00pm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                            fClass myclass = new fClass(int.Parse(textBox1.Text), textBox2.Text, int.Parse(comboBox1.Text), id == -1 ? int.Parse(comboBox2.Text) : id, 0, int.Parse(textBox3.Text),
                                startClass.ToString("yyyy-MM-dd HH:mm:ss"), endClass.ToString("yyyy-MM-dd HH:mm:ss"));

                            if (myclass.SaveData() && myclass.SaveDate())
                            {
                                MessageBox.Show("The class was add successfully");
                                dateSelected = false;
                                timeSelected = false;
                                /*
                                textBox1.Clear();
                                textBox2.Clear();
                                textBox3.Clear();
                                if (comboBox1.Items.Count > 0)
                                    comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
                                if (comboBox2.Items.Count > 0)
                                    comboBox2.SelectedIndex = comboBox2.Items.Count - 1;
                                */
                                return;
                            }
                            else
                            {
                                //delete the added class
                                fDelClass mydelete = new fDelClass(int.Parse(textBox1.Text));
                                mydelete.deleteAll();
                                MessageBox.Show("Schedule not saved");
                            }
                            return;
                        }
                    }
                    else
                        MessageBox.Show("Error occourd, please try again");
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


       

      
    }

}
