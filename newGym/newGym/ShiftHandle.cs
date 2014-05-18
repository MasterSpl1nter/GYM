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
    public partial class ShiftHandle : Form
    {
        public ShiftHandle()
        {
            InitializeComponent();
            this.shiftResults.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panelShowShift.Visible = true;
            this.shiftResults.Visible = false;
            this.addShiftPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panelShowShift.Visible = false;
            this.shiftResults.Visible = false;
            this.addShiftPanel.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.idComboBox.Items.Clear();
            DataTable dt = new DataTable();
            if(this.departmentComboBox.SelectedItem.Equals("Manager") )
            {
                string query = "SELECT id,firstname,lastname FROM manager ;";
                MySQL.Query(dt, query);
            }
            if (this.departmentComboBox.SelectedItem.Equals("Worker"))
            {
                string query = "SELECT id,firstname,lastname FROM worker ;";
                MySQL.Query(dt, query);
            }
            if (this.departmentComboBox.SelectedItem.Equals("Trainer"))
            {
                string query = "SELECT id,firstname,lastname FROM trainer ;";
                MySQL.Query(dt, query);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string str=dt.Rows[i]["id"] +" "+ dt.Rows[i]["firstname"] +" "+ dt.Rows[i]["lastname"];
                this.idComboBox.Items.Add(str);
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddShift_Click(object sender, EventArgs e)
        {
            string Start = AddStartPicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string End = AddEndPicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            MessageBox.Show(Start);
            //AddStartPicker.Value.


            int MonthDiff = AddStartPicker.Value.Month - AddEndPicker.Value.Month;
            int TimeDiff = AddEndPicker.Value.Hour - AddStartPicker.Value.Hour;
            int YearDiff = AddStartPicker.Value.Year - AddEndPicker.Value.Year;
            int DayDiff = AddEndPicker.Value.Day - AddStartPicker.Value.Day;
            MessageBox.Show("MonthDiff-" +MonthDiff+ "/nTimeDiff-" + TimeDiff + "/nYearDiff-"+ YearDiff + "/nDayDiff-" + DayDiff );

            if ((AddEndPicker.Value.DayOfWeek == DayOfWeek.Saturday) ||
                       ((AddEndPicker.Value.DayOfWeek < DayOfWeek.Friday && AddEndPicker.Value.DayOfWeek >= DayOfWeek.Sunday) && !(AddEndPicker.Value.Hour < 23 && AddEndPicker.Value.Hour > 7)) ||
                       (AddEndPicker.Value.DayOfWeek == DayOfWeek.Friday && !(AddEndPicker.Value.Hour < 14 && AddEndPicker.Value.Hour > 7)))
            {
                MessageBox.Show("Gym Opening Hours. Sunday to Thursday: 07:00am - 23:00pm. Friday: 07:00am - 14:00pm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (TimeDiff > 14 || DayDiff != 0 || MonthDiff != 0 || YearDiff != 0)
            {
                MessageBox.Show("max shif about 14 hours.");
                return;
            }
            string id = this.idComboBox.SelectedItem.ToString().Split(' ')[0];
            MessageBox.Show("id -" + id);
            DbConnection newConn = new DbConnection("gym", "root", "csharp");
            string query = "INSERT INTO `gym`.`workingtime` (`id`, `permission`, `starttime`, `endtime`) VALUES ('" + Convert.ToInt32(id) + "', '" + getPerm().ToString() + "', '" + AddStartPicker.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + AddEndPicker.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' );";
            newConn.writeToDb(query);
            //string insert = String.Format("{0},'{1}','{2}','{3}'", id, getPerm().ToString(), AddStartPicker.Value.ToString("yyyy-MM-dd HH:mm:ss"), AddEndPicker.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            //int retval = MySQL.Insert("workingtime", "id,permisson,starttime,endtime", insert);
            //if (retval == 0)
             //   MessageBox.Show("add shift successed");
            //else
             //   MessageBox.Show(retval.ToString());

        }
        private int getPerm()
        {
            if (departmentComboBox.SelectedItem.Equals("Trainer")) return 2;
            if (departmentComboBox.SelectedItem.Equals("Guide")) return 3;
            if (departmentComboBox.SelectedItem.Equals("Worker")) return 1;
            if (departmentComboBox.SelectedItem.Equals("Manager")) return 4;

            return -1;
        }
    }
}
