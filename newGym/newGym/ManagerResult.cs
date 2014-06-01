using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;               
namespace newGym
{
    public partial class ManagerResult : Form
    {
        
        public ManagerResult(string value)
        {
            
                
                InitializeComponent();
                getDT(value);
            
        }
        public void getDT(string value)
        {
            string []arr= {"manager","guide","trainer","student","worker","edit"};
            int retval;
            DataTable dt1=new DataTable();
            MySQL.Query(dt1, "SELECT id,firstname,lastname,email,permission FROM gym.guide where id=0");
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            
            btn.HeaderText = "Edit Data";
            btn.Text = "Edit";
            btn.Name = "EditBtn";
            btn.UseColumnTextForButtonValue = true;
            
            for (int i = 0; i < arr.Length; i++)
            {
                //int retval = MySQL.Query(dt, "SELECT id,firstname,lastname,email FROM" +arr[i]+ "where id LIKE " + value);
                DataTable dt = new DataTable();
                if ((Regex.IsMatch(value, "^[0-9]{9}$")))
                {
                    retval = MySQL.Query(dt, "SELECT id,firstname,lastname,email,permission FROM " + arr[i] + " where id=" + value);
                }
                else
                {
                  if(value.Contains(" "))
                      retval = MySQL.Query(dt, "select id,firstname,lastname,email,permission FROM " + arr[i] + " where firstname LIKE '%" + value.Split(' ')[0] + "%' or  lastname LIKE '%" + value.Split(' ')[1] + "%'");
                  else
                      retval = MySQL.Query(dt, "select id,firstname,lastname,email,permission FROM " + arr[i] + " where firstname LIKE '%" + value + "%' or  lastname LIKE '%" + value + "%'");
                }
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    
                    dt1.Rows.Add(dt.Rows[j]["id"], dt.Rows[j]["firstname"], dt.Rows[j]["lastname"], dt.Rows[j]["email"], dt.Rows[j]["permission"]);
                    
                }
                //continue

            }

            if (dt1.Rows.Count > 0)
            {
                this.dataGridResult.DataSource = dt1;
                dataGridResult.Columns.Add(btn);
            }
            else
            {
                MessageBox.Show("No Results");
                
            }
            

        }
        private string GetTypeByPerm(string perm)
        {
            if(perm.Equals("4") ) return "manager";
            if(perm.Equals("2") ) return "Trainer";

            return "NONE";
        }

        private void dataGridResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            editManager m = new editManager(dataGridResult.Rows[e.RowIndex].Cells["id"].Value.ToString(),this);
            m.ShowDialog();
            
        }
        

    }
}
