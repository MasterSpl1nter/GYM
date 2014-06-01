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
    public partial class faddclassexp : Form
    {
        private TimeSpan starttime;
        private TimeSpan endtime;
        private Boolean windowClosed, thisClose;
        public faddclassexp()
        {
            InitializeComponent();
            InitTimePicker();
        }

        private void InitTimePicker()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Width = 80;
            dateTimePicker1.CustomFormat = "HH:mm tt";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Width = 80;
            dateTimePicker2.CustomFormat = "HH:mm tt";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;



        }

        private void faddclassexp_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            TimeSpan maxTime = new TimeSpan(3,0,0);             // Max 3 hour class

           DateTime starttimeTemp = dateTimePicker1.Value;
           DateTime endtimeTemp = dateTimePicker2.Value;
           TimeSpan ts = endtimeTemp.Subtract(starttimeTemp);
            if (starttimeTemp.Equals(endtimeTemp))
                MessageBox.Show("Start Time can't be same as the End Time ");
            else

                if (starttimeTemp.CompareTo(endtimeTemp) == 1)
                    MessageBox.Show("End Time can't be before the Start Time ");
                else

                    if (ts.CompareTo(maxTime) == 1)
                        MessageBox.Show("Maximum 3 hours allowed, You selected " + ts.Hours.ToString() + " Hours and " + ts.Minutes.ToString() + " Minutes");
                    else
                    {
                        try
                        {
                            this.starttime = DateTimeToTimeSpan(starttimeTemp);
                            this.endtime = DateTimeToTimeSpan(endtimeTemp);
                        }
                        catch (Exception f)
                        {
                            MessageBox.Show("Error has accrued:" + f.Message, "Error", MessageBoxButtons.OK);
                        }
                        finally
                        {
                            this.thisClose = true;
                            this.Close();
                        }
                    }
            

        }

        private TimeSpan DateTimeToTimeSpan(DateTime? ts)
        {
            if (!ts.HasValue) return TimeSpan.Zero;
            else return new TimeSpan(0, ts.Value.Hour, ts.Value.Minute,0);
        }

        public TimeSpan getStartTime()
        {
            return this.starttime;
        }
        public TimeSpan getEndTime()
        {
            return this.endtime;
        }

        public Boolean windowExited()
        {
            return this.windowClosed;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            DialogResult dr;
            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;
            if (e.CloseReason == CloseReason.UserClosing && !this.thisClose)
            {
                dr = MessageBox.Show("Time will be lost", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    windowClosed = true;
                    return;
                }
                windowClosed = false;
                e.Cancel = true;
            }
        }
    }
}
