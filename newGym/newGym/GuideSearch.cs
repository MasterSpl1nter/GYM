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
        public GuideSearch(DataTable dt)
        {
            this.dt = dt;
            InitializeComponent();
            searchResult.DataSource = dt;
            searchResult.CellClick+=dataGridView1_CellClick;
        }
        private void dataGridView1_CellClick(object sender,DataGridViewCellEventArgs e)
        {
                MessageBox.Show(dt.Rows[e.RowIndex]["id"].ToString());

        }
    }
}
