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
        public GuideSearch(DataTable dt)
        {
            InitializeComponent();
            dataGridView1.DataSource = dt;
        }
    }
}