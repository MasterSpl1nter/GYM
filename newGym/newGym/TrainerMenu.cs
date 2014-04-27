using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newGym
{
    public partial class TrainerMenu : Form
    {
        private int count = 0;
        DateTime[] arr;
        DataTable dtmp;
        DataTable dt;
        Trainer trainer;
        public TrainerMenu(Trainer trainer)
        {
            this.trainer = trainer;
            dt = new DataTable();
            InitializeComponent();
            timer1.Start();
            loggedLabel.Text = trainer.UserName;
<<<<<<< HEAD
            MySQL.Query(dt, "SELECT class.id,class.name,class.room,classtime.starttime,classtime.endtime FROM class INNER JOIN classtime ON class.id=classtime.classid WHERE class.guideid=22");
=======
            MySQL.Query(dt, "SELECT class.id,class.name,class.room,classtime.starttime,classtime.endtime FROM class INNER JOIN classtime ON class.id=classtime.classid WHERE class.trainerid=22");
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
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
<<<<<<< HEAD
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
=======
            //if (dtmp.Rows.Count==1){
            //Updateitems(0);
            //hScrollBar1.Visible = false;
            //}
            //if (dtmp.Rows.Count > 1)
            //{
            //    Updateitems(0);
            //    hScrollBar1.Visible = true;
            //}
            //else if(dtmp.Rows.Count == 0)
            //{
            //    idLabel.Text = "";
            //    nameLabel.Text = "";
            //    ParticiLabel.Text = "";
            //    roomNumLabel.Text = "";
            //    starttimeLabel.Text = "";
            //    endtimeLabel.Text = "";
            //    tothourLabel.Text = "";
            //    hScrollBar1.Visible = false;
            //}
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
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

<<<<<<< HEAD
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
=======
        //private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        //{
        //       // MessageBox.Show(count.ToString());
        //    hScrollBar1.LargeChange = 99;
        //        int i = count % dtmp.Rows.Count;
        //        Updateitems(i);
        //        count++;
        //}
        //private void Updateitems(int i)
        //{
        //    idLabel.Text = dtmp.Rows[i]["id"].ToString();
        //    int studentsnum = MySQL.count("SELECT COUNT(studentid) FROM studentclass where classid=" + idLabel.Text);
        //    nameLabel.Text = dtmp.Rows[i]["name"].ToString();
        //    ParticiLabel.Text = studentsnum.ToString();
        //    roomNumLabel.Text = dtmp.Rows[i]["room"].ToString();
        //    starttimeLabel.Text = dtmp.Rows[i]["starttime"].ToString().Split(' ')[1];
        //    endtimeLabel.Text = dtmp.Rows[i]["endtime"].ToString().Split(' ')[1];
        //    tothourLabel.Text = DateTime.Parse(((Convert.ToDateTime(dtmp.Rows[i]["endtime"]) - Convert.ToDateTime(dtmp.Rows[i]["starttime"]))).ToString()).ToString("HH:mm");
        //}
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372

        private void button13_Click(object sender, EventArgs e)
        {
            fAddClass ac = new fAddClass();
            ac.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            fDelClass ac = new fDelClass();
            ac.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (StudSearch.Text.Length > 0 && GuideSearch.Text.Length > 0)
=======
            if (StudSearch.Text.Length > 0 && TrainerSearch.Text.Length > 0)
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
            {
                MessageBox.Show("Only one search field can be filled.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
<<<<<<< HEAD
            //fix error spaces in name search
            DataTable dt=new DataTable();
            if (GuideSearch.Text.Length>0){
             if (radioID.Checked)
                {
                 trainer.SearchID(dt, GuideSearch.Text);
                //MessageBox.Show(dt.Rows[0]["id"].ToString());
                GuideSearch gs = new GuideSearch(dt);
                gs.ShowDialog();
            }
            else
            {
                trainer.SearchName(dt, GuideSearch.Text);
                //MessageBox.Show(dt.Rows[0]["id"].ToString());
                GuideSearch gs = new GuideSearch(dt);
                gs.ShowDialog();
=======
            //fix error spaces in name searchgs
            DataTable dt=new DataTable();
            if (TrainerSearch.Text.Length > 0)
            {
             if (radioID.Checked)
                {
                    trainer.SearchID(dt, TrainerSearch.Text);
                //MessageBox.Show(dt.Rows[0]["id"].ToString());
                    TrainerSearch ts = new TrainerSearch(dt);
                ts.ShowDialog();
            }
            else
            {
                trainer.SearchName(dt, TrainerSearch.Text);
                //MessageBox.Show(dt.Rows[0]["id"].ToString());
                TrainerSearch ts = new TrainerSearch(dt);
                ts.ShowDialog();
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
            }
            }
            else if (StudSearch.Text.Length > 0)
            {
                if (radioID.Checked)
                {
                    trainer.SearchStudID(dt, StudSearch.Text);
                    //MessageBox.Show(dt.Rows[0]["id"].ToString());
<<<<<<< HEAD
                    GuideSearch gs = new GuideSearch(dt);
                    gs.ShowDialog();
=======
                    TrainerSearch ts = new TrainerSearch(dt);
                    ts.ShowDialog();
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
                }
                else
                {
                    trainer.SearchStudName(dt, StudSearch.Text);
                    //MessageBox.Show(dt.Rows[0]["id"].ToString());
<<<<<<< HEAD
                    GuideSearch gs = new GuideSearch(dt);
                    gs.ShowDialog();
=======
                    TrainerSearch ts = new TrainerSearch(dt);
                    ts.ShowDialog();
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TrainerMenu_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
=======
        private void viewbutton_Click(object sender, EventArgs e)
        {

        }

>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
    }
}
