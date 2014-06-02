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
    public partial class TrainerSearch : GForm
    {
        DataTable dt;
        public TrainerSearch(DataTable dt)
        {
            this.dt = dt;
            InitializeComponent();
            dataGridView1.DataSource = dt;
            dataGridView1.CellClick+=dataGridView1_CellClick;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                MessageBox.Show(dt.Rows[e.RowIndex]["id"].ToString());

        }
    }
}
