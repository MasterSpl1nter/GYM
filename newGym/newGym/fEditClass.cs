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
    public partial class fEditClass : GForm
    {
        private int guideid = -1,count=0;
        private int roomid, classid,capacity;
        private string name;
        DateTime newDate,oldDate,oldStart,oldEnd;
        TimeSpan newStarttime,newEndtime,oldStarttime,oldEndtime;
        List<DateTime> arr;
        DataTable dt,dt2,dtt,dtmp;
        Boolean calendarClick = false, dateChanged = false,  timeChanged = false, itemSelected = false, roomChanged = false;
        faddclassexp timer;
        public fEditClass()
        {
            this.Controls.Add(textBox5);
            InitializeComponent();
            LoadActivityId();
            textBox5.Click += new EventHandler(textBox5_Click);
            monthCalendar1.MaxSelectionCount = 1;
        }
        public fEditClass(int guide)
        {
            this.guideid = guide;
            this.Controls.Add(textBox5);
            InitializeComponent();
            comboBox3.Visible = false;
         //   gidLabel.Visible = true;
         //   gidLabel.Text = id.ToString();

            LoadActivityId();
            monthCalendar1.MaxSelectionCount = 1;
            textBox5.Click += new EventHandler(textBox5_Click);
        }

        //Load room ID to a combobox
        private void LoadRoomId()
        {
            dtt = new DataTable();
            MySQL.Select(dtt, "room");
            comboBox2.DataSource = dtt;
            comboBox2.DisplayMember = "id";
        }
        //Load GuideID to a combobox
        private void LoadGuideId()
        {
            dtt = new DataTable();
            MySQL.Select(dtt, "guide");
            comboBox3.DataSource = dtt;
            comboBox3.DisplayMember = "id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBox1.Text.ToString();
            string[] arr = str.Split('-');
            int i = 0;
            dt = new DataTable();
            dt2 = new DataTable();

            try
            {
                classid = int.Parse(arr[i]);
                if(guideid==-1) LoadGuideId();
                LoadRoomId();
                MySQL.Query(dt, "SELECT name, room, guideid, capacity FROM class WHERE id=" + classid);
                int c = dt.Rows.Count;
                name = dt.Rows[0]["name"].ToString();
                textBox1.Text = name;
                capacity = int.Parse(dt.Rows[0]["capacity"].ToString());
                textBox2.Text = capacity.ToString();               
                MySQL.Query(dt2, "SELECT studentclass.studentid FROM studentclass WHERE classid=" + classid);
                textBox4.Text = dt2.Rows.Count.ToString();     // fill participants
                guideid = int.Parse(dt.Rows[0]["guideid"].ToString());
                if (guideid == -1)
                    comboBox3.SelectedIndex = comboBox3.FindString(guideid.ToString());
                roomid = int.Parse(dt.Rows[0]["room"].ToString());
                comboBox2.SelectedIndex = comboBox2.FindString(roomid.ToString());
                UpdateCalendar(classid);
                calendarClick = true;
                itemSelected = true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Error", er.ToString());
            }
        }
        //Load Activity ID to a combobox
        private void LoadActivityId()
        {
            var query = "";
            var connectionString = @"server=localhost;userid=root;password=csharp;database=gym";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                if (guideid == -1)
                    query = "SELECT Id , Name FROM class";
                else
                    query = "SELECT Id , Name FROM class WHERE `guideid`=?Id";


                using (var command = new MySqlCommand(query, connection))
                {
                    if (guideid != -1)
                        command.Parameters.AddWithValue("?id", guideid);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(new TableItem(reader.GetString("Id"), reader.GetString("Name")));
                        }
                    }
                }
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int i = count % dtmp.Rows.Count;
            Updateitems(i);
            count++;  
        }


        private void UpdateCalendar(int id)
        {
            dt = new DataTable();
            MySQL.Query(dt, "SELECT class.id,class.name,class.room,classtime.starttime,classtime.endtime FROM class INNER JOIN classtime ON class.id=classtime.classid WHERE class.id="+id);
            arr = new List<DateTime>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToDateTime(dt.Rows[i]["starttime"].ToString()).Month >= DateTime.Now.Month)
                {
                    arr.Add(Convert.ToDateTime(dt.Rows[i]["starttime"]));
                }
            }
            this.monthCalendar1.MonthlyBoldedDates = (DateTime[])arr.ToArray();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (calendarClick)
            {
                this.oldDate = monthCalendar1.SelectionStart;
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
                    hScrollBar1.Visible = false;
                }
            }
        }

        private void Updateitems(int i)
        {
            idLabel.Text = dtmp.Rows[i]["id"].ToString();
            int studentsnum = MySQL.count("SELECT COUNT(studentid) FROM studentclass where classid=" + idLabel.Text);
            nameLabel.Text = dtmp.Rows[i]["name"].ToString();
            ParticiLabel.Text = studentsnum.ToString();
            roomNumLabel.Text = dtmp.Rows[i]["room"].ToString();
            DateTime obj1 = Convert.ToDateTime(dtmp.Rows[i]["starttime"]);
            starttimeLabel.Text = obj1.ToString("HH:mm:ss");
            DateTime obj2 = Convert.ToDateTime(dtmp.Rows[i]["endtime"]);
            endtimeLabel.Text = obj2.ToString("HH:mm:ss");
            tothourLabel.Text = DateTime.Parse(((Convert.ToDateTime(dtmp.Rows[i]["endtime"]) - Convert.ToDateTime(dtmp.Rows[i]["starttime"]))).ToString()).ToString("HH:mm");
            this.oldStart = Convert.ToDateTime(dtmp.Rows[i]["starttime"].ToString());
            this.oldEnd = Convert.ToDateTime(dtmp.Rows[i]["endtime"].ToString());
            this.oldStarttime = new TimeSpan(oldStart.Hour, oldStart.Minute, 0);
            this.oldEndtime = new TimeSpan(oldEnd.Hour, oldEnd.Minute, 0);
            this.oldDate = new DateTime(oldStart.Year, oldStart.Month, oldStart.Day, oldStart.Hour, oldStart.Minute, 0);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (textBox2.Text != "")
            {
                dt = new DataTable();
                int roomid = int.Parse(comboBox2.Text);

                try
                {
                    var connectionString = @"server=localhost;userid=root;password=csharp;database=gym";
                    using (var connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        var query = "SELECT capacity FROM room WHERE id=" + roomid;
                        using (var command = new MySqlCommand(query, connection))
                        {
                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    textBox2.Text = reader.GetString("capacity").ToString();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex) { throw new Exception(ex.Message); }  
            }         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int new_roomid,new_guideid,new_capacity;
            string new_name;
            dt = new DataTable();
            if (itemSelected && dateChanged && timeChanged || checkBox1.Checked)
            {
                new_name = textBox1.Text;
                new_roomid = int.Parse(comboBox2.Text);
                new_guideid = guideid == -1 ? int.Parse(comboBox3.Text) : guideid;
                new_capacity = int.Parse(textBox2.Text);

                DateTime tempStart = new DateTime(newDate.Year, newDate.Month, newDate.Day, newStarttime.Hours, newStarttime.Minutes, 0);
                DateTime tempEnd = new DateTime(newDate.Year, newDate.Month, newDate.Day, newEndtime.Hours, newEndtime.Hours, newEndtime.Minutes, 0);
                fClass myclass = new fClass(classid, new_name, new_roomid, new_guideid, 0, new_capacity, tempStart.ToString("yyyy-MM-dd HH:mm:ss"), tempEnd.ToString("yyyy-MM-dd HH:mm:ss"));

                if (new_roomid != roomid)       // add keep old schedule
                    if (myclass.isRoomOccupied())
                    {
                        this.roomChanged = true;
                        if (checkBox1.Checked)
                        {
                            updateRoom(new_roomid);
                            MessageBox.Show("Opertation completed", "Done");
                            UpdateCalendar(classid);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("The room is already in use, Select other room");
                        return;
                    }
                     
                // allowed to chenge room number to a new room that never was used
                if (tempStart > DateTime.Now && (new_roomid == roomid || roomChanged))     // if user selected new schedule with the same room
                {
                    try
                    {
                        var connectionString = @"server=localhost;userid=root;password=csharp;database=gym";
                        using (var connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();
                            var query = "UPDATE `gym`.`class` SET name = ?new_name, guideid = ?new_guideid, room = ?new_roomid";
                            query += " WHERE id = " + classid;

                            using (var cmd = new MySqlCommand(query, connection))
                            {
                                cmd.Parameters.AddWithValue("?new_name", new_name);
                                cmd.Parameters.AddWithValue("?new_guideid", new_guideid);
                                cmd.Parameters.AddWithValue("?new_roomid", new_roomid);
                                cmd.ExecuteNonQuery();
                            }
                            connection.Close();
                        }


                        // change classTime table
                        MySQL.Delete("classtime", "classid=" + classid);
                        myclass.SaveDate();
                    }

                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show("Error " + ex.Number + "has accurred: " + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MessageBox.Show("Opertation completed", "Done");
                    UpdateCalendar(classid);
                    return;
                }
                else
                {
                    //func
                    if (myclass.isRoomOccupied()) // true if  not occupied
                        updateRoom(new_roomid);
                    else
                    {
                        MessageBox.Show("The room is already in use, Select other room");
                        return;
                    }
                }
            }
            else
                MessageBox.Show("Please fill all fields: " + ((!dateChanged) ? "Date was not selected" : "Time was not selected"), "Error", MessageBoxButtons.OK);
        }

        private void updateRoom(int new_roomid)
        {

            // $$ change the class room for all schedules $$

            DialogResult dr;

                //copy all exicting schedules to the new room
                dr = MessageBox.Show("Do you want to move all schedules to the specific room: " + new_roomid + " ?", "Are You Sure?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    try { MySQL.Query(dt, "UPDATE `gym`.`class` SET room = '" + new_roomid + "'" + " WHERE id=" + classid); }
                    catch (Exception ex)
                    { throw new Exception(ex.Message); }
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime new_date = dateTimePicker1.Value;
            if (new_date.CompareTo(DateTime.Now) == 1)
            {
                this.newDate = new_date;
                dateChanged = true;
            }
            else
                MessageBox.Show("Wrong Date Selected", "Date Error", MessageBoxButtons.OK);                  
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_Click(object sender, System.EventArgs e)
        {
            timer = new faddclassexp();
            timer.ShowDialog();
            this.newStarttime = timer.getStartTime();
            this.newEndtime = timer.getEndTime();
            textBox5.Text = newStarttime.ToString();
            textBox6.Text = newEndtime.ToString();
            if (timer.windowExited()) timeChanged = false; else timeChanged = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                gGroupBox1.Visible = false;
            else
                gGroupBox1.Visible = true;
        }



    }
}
