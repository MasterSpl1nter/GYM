﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace newGym
{
    public partial class ManagerMenu : Form
    {
         private int count = 0;
        DateTime[] arr;
        DataTable dtmp;
        DataTable dt;

        public ManagerMenu(Manager m)
        {
            
            dt = new DataTable();
            InitializeComponent();
            //UpdateCalendar();
            MySQL.Query(dt, "SELECT class.id,class.name,class.room,classtime.starttime,classtime.endtime FROM class INNER JOIN classtime ON class.id=classtime.classid ");
            arr = new DateTime[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                arr[i] = Convert.ToDateTime(dt.Rows[i]["starttime"]);
            }
            this.monthCalendar1.MonthlyBoldedDates = arr;
            /*      Dictionary<Tuple<DateTime, int>, int> dic = new Dictionary<Tuple<DateTime, int>, int>();
                  for (int i = 0; i < dt.Rows.Count; i++)
                  {
                      for(int j=0;j<dt.Rows[
                      Tuple<DateTime, int> key = new Tuple<DateTime, int>(Convert.ToDateTime(dt.Rows[i]["starttime"]),Convert.ToInt32(dt.Rows[i]["id"]));
                      int index = i;
                      dic.Add(key, index);
                  }*/
            helloLabel.Text = "Hello," + m.FirstName + " " + m.LastName;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            /*
            dtmp = new DataTable();
            dtmp.Clear();
            dtmp.Columns.Add("id",typeof(int));
            dtmp.Columns.Add("name",typeof(string));
            dtmp.Columns.Add("room", typeof(string));
            dtmp.Columns.Add("starttime", typeof(DateTime));
            dtmp.Columns.Add("endttime", typeof(DateTime));
            foreach (DataRow dr in dt.Rows)
            {

                if (dr["starttime"].ToString().Contains(monthCalendar1.SelectionStart.ToShortDateString()))
                {
                    dtmp.Rows.Add(dr.ItemArray);
                }
            }
            if (dtmp.Rows.Count==1){
            Updateitems(0);
            hScrollBar1.Visible = false;
            }
            if (dtmp.Rows.Count > 1)
            {
                Updateitems(0);
                hScrollBar1.Visible = true;
            }
            else if(dtmp.Rows.Count == 0)
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
                
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "id";
            //idLabel.Text = dt.Rows[i]["id"].ToString();
            nameLabel.Text = dt.Rows[i]["name"].ToString();
            //ParticiLabel.Text = dt.Rows[i][].ToString();
            roomNumLabel.Text = dt.Rows[i]["room"].ToString();
            starttimeLabel.Text = dt.Rows[i]["starttime"].ToString().Split(' ')[1];
            endtimeLabel.Text = dt.Rows[i]["endtime"].ToString().Split(' ')[1];
            tothourLabel.Text = DateTime.Parse(((Convert.ToDateTime(dt.Rows[i]["endtime"]) - Convert.ToDateTime(dt.Rows[i]["starttime"]))).ToString()).ToString("HH:mm");
   //   */  }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
               // MessageBox.Show(count.ToString());
            hScrollBar1.LargeChange = 99;
                int i = count % dtmp.Rows.Count;
                Updateitems(i);
                count++;
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
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addManager addM = new addManager(0);
            addM.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Application.Run(new GuideForm(0));
            GuideForm g = new GuideForm(0);
            g.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GuideForm g = new GuideForm(1);
            g.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GuideForm g = new GuideForm(2);
            g.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddSecretary s = new AddSecretary();
            s.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AddStudent asa = new AddStudent();
            asa.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Room.addRoom();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addManager editM = new addManager(1);
            editM.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormAddTrainer addT = new FormAddTrainer();
            addT.ShowDialog();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormEditTrainer editT = new FormEditTrainer();
            editT.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormRemoveTrainer removeT = new FormRemoveTrainer();
            removeT.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //Application.Run(new ManuApplince());
            ManuApplince MP = new ManuApplince();
            MP.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            fAddClass AddClass = new fAddClass();
            AddClass.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            /// Class EDIT ...///
            fEditClass editClass = new fEditClass();
            editClass.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //delete//
            fDelClass DelClass = new fDelClass();
            DelClass.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleteManager d = new deleteManager();
            d.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            EditSecretary es = new EditSecretary();
            es.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DelSecretary ds = new DelSecretary();
            ds.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            EditStudentBySecrtary es = new EditStudentBySecrtary();
            es.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DeleteStudent ds = new DeleteStudent();
            ds.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void button23_Click(object sender, EventArgs e)
        {
            AddStudent asa = new AddStudent();
            asa.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            addManager addM = new addManager(0);
            addM.ShowDialog();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void ManagerMenu_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox4_Enter_1(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            if (this.searchTextBox.Text.Equals("")) return;
            new ManagerResult(this.searchTextBox.Text).ShowDialog();
        }


        private void button24_Click(object sender, EventArgs e)
        {
            fDelClass fd = new fDelClass(-2);
            fd.ShowDialog();
        }

        private void classHandleBtn_Click(object sender, EventArgs e)
        {
            new ClassHandele().ShowDialog();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Room.addRoom();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            new ShiftHandle().ShowDialog();
        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
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
                paymentLabel.Text = "";
                hScrollBar1.Visible = false;
            }
        }
        /*
        private void UpdateCalendar()
        {
            DataTable dt = new DataTable();
            MySQL.Query(dt, "SELECT class.id,class.name,class.room,classtime.starttime,classtime.endtime FROM class INNER JOIN classtime ON class.id=classtime.classid ");
            arr = new List<DateTime>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToDateTime(dt.Rows[i]["starttime"].ToString()).Month == DateTime.Now.Month)
                {
                    arr.Add(Convert.ToDateTime(dt.Rows[i]["starttime"]));
                }
            }
            this.monthCalendar1.MonthlyBoldedDates = (DateTime[])arr.ToArray();
        }
        */


    }
    }
