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
    public partial class deleteManager : GForm
    {
        public deleteManager()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM gym.manager;";
            DbConnection newConn = new DbConnection("gym", "root", "csharp");
            newConn.Selectdt(query, dt);
            foreach (DataRow r in dt.Rows)
            {
                this.deleteComboBox.Items.Add(r["id"].ToString() + "-" + r["firstname"].ToString() + " " + r["lastName"].ToString());
            }
        }

        private void deleteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void deleteManageById_Click(object sender, EventArgs e)
        {
            string str = deleteComboBox.SelectedItem.ToString();
            str = str.Substring(0, str.IndexOf('-'));
            if (MessageBox.Show("Are you sure want to delete " + deleteComboBox.SelectedItem.ToString().Substring(str.IndexOf('-') + 1) + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Manager.deleteManagerById(Convert.ToInt32(str));
            }
        }
    }
}
