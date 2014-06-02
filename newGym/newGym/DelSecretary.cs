using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace newGym
{
    public partial class DelSecretary : GForm
    {
        string id;
        public DelSecretary()
        {
            InitializeComponent();
            try
            {
                fillBox(); //fill the combobox by id
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void fillBox()
        {
            DataTable dt = new DataTable();
            MySQL.Select(dt, "worker");
            //fill combobox by id
            foreach (DataRow row in dt.Rows)
            {
                this.id_comboBox1.Items.Add(row["id"].ToString());
            }
        }
    
        private void enter_button_Click(object sender, EventArgs e)
        {
            id = id_comboBox1.SelectedItem.ToString();
            Secretary.Delete(id);
            MessageBox.Show("Secretary have been deleted succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
