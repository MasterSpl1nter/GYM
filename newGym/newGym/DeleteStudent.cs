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
    public partial class DeleteStudent : Form
    {
        string id;
        public DeleteStudent()
        {
            InitializeComponent();
            fillcombo();

        }
        public void fillcombo()
        {
            DataTable dt = new DataTable();
            try
            {
                MySQL.Select(dt, "student");
                foreach (DataRow row in dt.Rows)
                {
                    this.delete_comb.Items.Add(row["id"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteStudent_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = delete_comb.Text;
            Student.Delete(id.ToString());
            MessageBox.Show("The student deleted succesfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void delete_comb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
