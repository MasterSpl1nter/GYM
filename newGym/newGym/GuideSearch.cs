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
    public partial class GuideSearch : Form
    {
        DataTable dt;
        int classid;
        public GuideSearch(DataTable dt)
        {
            this.dt = dt;
            InitializeComponent();
            searchResult.DataSource = dt;
            searchResult.CellClick+=dataGridView1_CellClick;
        }
        public GuideSearch(int classid)
        {
            dt = new DataTable();
            this.classid = classid;
            MySQL.Query(dt, "SELECT student.id,student.firstname,student.lastname,student.email,student.birthday,student.startdate,student.enddate,student.medcert FROM student INNER JOIN studentclass ON student.id=studentclass.studentid WHERE studentclass.classid=" + classid);
            InitializeComponent();
            searchResult.DataSource = dt;
            searchResult.CellClick += dataGridView1_CellClick;
        }

        private void dataGridView1_CellClick(object sender,DataGridViewCellEventArgs e)
        {
                MessageBox.Show(dt.Rows[e.RowIndex]["id"].ToString());

        }
    }
}
