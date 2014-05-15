using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace newGym
{
    public partial class GuideMenu : Form
    {
        private int count = 0;
        List<DateTime> arr;
        DataTable dtmp;
        DataTable dt;
        Guide guide;
        DateTime endtime;
        Timer t;
        public GuideMenu()
        {
            this.guide=(Guide)SingleUser.Instance.get_user();
            //this.guide = guide;
            dt = new DataTable();
            InitializeComponent();
            loggedLabel.Text = guide.UserName;
            UpdateCalendar();
            if (dt.Rows.Count > 0)
            {
                nextClass(dt);
                timer1.Start();
                t = new Timer();
                t.Interval = 1000;
                t.Tick += new EventHandler(t_Tick);
                TimeSpan ts = endtime.Subtract(DateTime.Now);
                nextClassTimer.Text = ts.ToString("d'd 'h'h 'm'm 's's to the next class.'");
                t.Start();
            }
            /*      Dictionary<Tuple<DateTime, int>, int> dic = new Dictionary<Tuple<DateTime, int>, int>();
                  for (int i = 0; i < dt.Rows.Count; i++)
                  {
                      for(int j=0;j<dt.Rows[
                      Tuple<DateTime, int> key = new Tuple<DateTime, int>(Convert.ToDateTime(dt.Rows[i]["starttime"]),Convert.ToInt32(dt.Rows[i]["id"]));
                      int index = i;
                      dic.Add(key, index);
                  }*/
        }
        private void UpdateCalendar()
        {
            MySQL.Query(dt, "SELECT class.id,class.name,class.room,classtime.starttime,classtime.endtime FROM class INNER JOIN classtime ON class.id=classtime.classid WHERE class.guideid=" + guide.Id);
            arr = new List<DateTime>();
            for (int i = 0,j = 0; i < dt.Rows.Count;i++)
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
            dtmp.Columns.Add("id",typeof(int));
            dtmp.Columns.Add("name",typeof(string));
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
                paymentLabel.Text = "";
                hScrollBar1.Visible = false;
            }
                /*
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
            paymentLabel.Text = (guide.salary * (Convert.ToDouble(TimeSpan.Parse(tothourLabel.Text).TotalHours) + ((TimeSpan.Parse(tothourLabel.Text).TotalMinutes) > 0 ? (TimeSpan.Parse(tothourLabel.Text).TotalMinutes - TimeSpan.Parse(tothourLabel.Text).TotalHours * 60) / 60 : 0))).ToString("#.00$");
        }
        private void button13_Click(object sender, EventArgs e)
        {
            fAddClass ac = new fAddClass(guide.Id);
            ac.ShowDialog();
            UpdateCalendar();            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            fDelClass ac = new fDelClass(guide.Id);
            ac.ShowDialog();
            UpdateCalendar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (StudSearch.Text.Length > 0 && GuideSearch.Text.Length > 0)
            {
                MessageBox.Show("Only one search field can be filled.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            //fix error spaces in name search
            DataTable dt=new DataTable();
            if (GuideSearch.Text.Length>0){
             if (radioID.Checked)
                {
                guide.SearchID(dt, GuideSearch.Text);
                //MessageBox.Show(dt.Rows[0]["id"].ToString());
                GuideSearch gs = new GuideSearch(dt);
                gs.ShowDialog();
            }
            else
            {
                guide.SearchName(dt, GuideSearch.Text);
                //MessageBox.Show(dt.Rows[0]["id"].ToString());
                GuideSearch gs = new GuideSearch(dt);
                gs.ShowDialog();
            }
            }
            else if (StudSearch.Text.Length > 0)
            {
                if (radioID.Checked)
                {
                    guide.SearchStudID(dt, StudSearch.Text);
                    //MessageBox.Show(dt.Rows[0]["id"].ToString());
                    GuideSearch gs = new GuideSearch(dt);
                    gs.ShowDialog();
                }
                else
                {
                    guide.SearchStudName(dt, StudSearch.Text);
                    //MessageBox.Show(dt.Rows[0]["id"].ToString());
                    GuideSearch gs = new GuideSearch(dt);
                    gs.ShowDialog();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            fEditClass ec = new fEditClass(guide.Id);
            ec.ShowDialog();
            UpdateCalendar();
        }

        private void gButton1_Click(object sender, EventArgs e)
        {
            int classid;
            int participants;
            try{
            Int32.TryParse(idLabel.Text,out classid);
            if (classid==0)
                throw new FormatException();
            }
            catch(FormatException){
                MessageBox.Show("Please choose class from Calendar.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            try
            {
                Int32.TryParse(ParticiLabel.Text, out participants);
                if (participants == 0)
                    throw new FormatException();
            }
            catch (FormatException)
            {
                MessageBox.Show("There are no participats registered to that class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GuideSearch gs = new GuideSearch(classid);
            gs.ShowDialog();
        }

        private void gButton2_Click(object sender, EventArgs e)
        {
            GuideShifts gsi = new GuideShifts();
            gsi.ShowDialog();
        }
        private void nextClass(DataTable dt)
        {
            endtime = new DateTime();
            int j=0;
            DateTime time = new DateTime();
            TimeSpan min = new TimeSpan(long.MaxValue);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                time=Convert.ToDateTime(dt.Rows[i]["starttime"]);
                if ( time > DateTime.Now)
                {
                    TimeSpan tmp = time - DateTime.Now;
                    if(tmp<min){
                        min = tmp;
                        j = i;
                    }
                }
            }
            endtime = Convert.ToDateTime(dt.Rows[j]["starttime"]);
        }
        private void t_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = endtime.Subtract(DateTime.Now);
            nextClassTimer.Text = ts.ToString("d'd 'h'h 'm'm 's's to the next class.'");
            if (ts<new TimeSpan(0))
            {
                //MessageBox.Show("Done.");
                t.Stop();
                nextClass(dt);
                t.Start();
            }
            
            
        }



    }
}
