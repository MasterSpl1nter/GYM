using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace newGym
{
    public partial class ManagerResult : Form
    {
        
        public ManagerResult(string value)
        {
            InitializeComponent();
            

        }
        public void getDT(string value)
        {
            string []arr= {"manager","guide","trainer","student","worker"};
            DataTable dt=new DataTable();
            for (int i = 0; i < arr.Length; i++)
            {
                int retval = MySQL.Query(dt, "SELECT id,firstname,lastname,email FROM" +arr[i]+ "where id LIKE " + value);
                //this.dataGridResult.DataSource = dt;
                //continue
            }

        }
    }
}
