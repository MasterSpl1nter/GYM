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
    public partial class GuideSearch : Form
    {
<<<<<<< HEAD
        public GuideSearch(DataTable dt)
        {
            InitializeComponent();
            dataGridView1.DataSource = dt;
=======
        DataTable dt;
        public GuideSearch(DataTable dt)
        {
            this.dt = dt;
            InitializeComponent();
            dataGridView1.DataSource = dt;
            dataGridView1.CellClick+=dataGridView1_CellClick;
        }
        private void dataGridView1_CellClick(object sender,
    DataGridViewCellEventArgs e)
        {
                MessageBox.Show(dt.Rows[e.RowIndex]["id"].ToString());

>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
        }
    }
}
