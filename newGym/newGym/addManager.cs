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
    public partial class addManager : Form
    {
        //private int opp;
        public addManager(int opp)
        {
            InitializeComponent();
            if (opp == 0)
            {
                this.IdComboBox.Visible = false;
                this.managerId.Visible = true;
            }
            if (opp == 1)
            {
                this.IdComboBox.Visible = true;
                this.managerId.Visible = false;
                this.exit_update.Visible = true;
                this.update_manger_button.Visible = true;
                this.AddManagerUser.Visible = false;
               DataTable dt = new DataTable();
                string query = "SELECT * FROM gym.manager;";
                DbConnection newConn= new DbConnection("gym","root","csharp");
                newConn.Selectdt(query, dt);
                foreach (DataRow r in dt.Rows)
                {
                    this.IdComboBox.Items.Add(r["id"].ToString());
                }
            }
        }

        private void AddManagerUser_Click_1(object sender, EventArgs e)
        {
            Manager m = new Manager(Convert.ToInt16(managerId.Text), managerFirstName.Text, managerLastName.Text, managerEmail.Text, 4, userName.Text, password.Text, Convert.ToInt16(MangerSalaryPerHour.Text));
            MessageBox.Show(managerFirstName.Text);

            if (Manager.isIdExist(Convert.ToInt16(managerId.Text)) == false)
            {
                m.addUser();
                MessageBox.Show("add a new manager success!");
            }
            else
                MessageBox.Show("the Id already exist!\n please try again!");
            //this.addMangerPanel.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void update_manger_button_Click(object sender, EventArgs e)
        {

        }

        private void exit_update_Click(object sender, EventArgs e)
        {   
            this.managerFirstName.Text = "";
            this.managerLastName.Text = "";
            this.managerEmail.Text = "";
            this.MangerSalaryPerHour.Text = "";
            this.userName.Text = "";
            this.password.Text = "";
        }
    }
}
