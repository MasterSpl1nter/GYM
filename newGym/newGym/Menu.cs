using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace newGym
{
    public partial class ManagerMenu : GForm
    {
        private int count = 0;
        DateTime[] arr;
        DataTable dtmp;
        DataTable dt;

        public ManagerMenu()
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

            Manager m = (Manager)SingleUser.Instance.get_user();
            helloLabel.Text = "Hello," + m.FirstName + " " + m.LastName;
        }
        /*
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
                paymentLabel.Text = "";
                hScrollBar1.Visible = false;
            }
        }

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
        */

        
        private void button23_Click(object sender, EventArgs e)
        {
            AddStudent asa = new AddStudent();
            asa.ShowDialog();
        }

        private void addWorkerBtn_Click(object sender, EventArgs e)
        {
            addManager addM = new addManager();
            addM.ShowDialog();
        }


        private void search_Click(object sender, EventArgs e)
        {
            if (this.searchTextBox.Text.Equals("")) return;
            else
            {
                ManagerResult m = new ManagerResult(this.searchTextBox.Text);
                m.ShowDialog();
            }
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
        /*
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
