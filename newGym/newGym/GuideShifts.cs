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
    public partial class GuideShifts : GForm
    { 
        DataTable dt;
        public GuideShifts()
        {
            dt = new DataTable();
            double sum = 0;
            MySQL.Query(dt, "SELECT class.id,class.name,class.room,classtime.starttime,classtime.endtime FROM class INNER JOIN classtime ON class.id=classtime.classid WHERE class.guideid=" + ((Guide)SingleUser.Instance.get_user()).Id + " AND Month(classtime.starttime)=" + DateTime.Now.Month);
            InitializeComponent();
            dataGridView1.DataSource = dt;
            dataGridView1.CellClick+=dataGridView1_CellClick;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //if(Convert.ToDateTime(dt.Rows[i]["starttime"]).Month==DateTime.Now.Month){
                    String time = DateTime.Parse(((Convert.ToDateTime(dt.Rows[i]["endtime"]) - Convert.ToDateTime(dt.Rows[i]["starttime"]))).ToString()).ToString("HH:mm");
                    sum += Convert.ToDouble(TimeSpan.Parse(time).TotalHours + ((TimeSpan.Parse(time).TotalMinutes) > 0 ? (TimeSpan.Parse(time).TotalMinutes - TimeSpan.Parse(time).TotalHours*60 )/ 60 : 0));
                //}
            }
            label1.Text = "Monthly salary: " + (sum*((Guide)SingleUser.Instance.get_user()).salary).ToString("#.00$");
            label2.Text = "Total monthly hours: " + sum.ToString("#.00");
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                MessageBox.Show(dt.Rows[e.RowIndex]["id"].ToString());

        }



    }
}
