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
    public partial class ManagerMenu : Form
    {
        public ManagerMenu()
        {
            InitializeComponent();
        }
/// <summary>

/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
/// //////////////////////////////////////////Manager MENU - MAIN///////////////////////////////////////
        private void deleteManager_mainPanel_Click(object sender, EventArgs e)
        {
            this.DeleteManagerPanel.Visible = true;
        }

        private void updateManager_mainPanel_Click(object sender, EventArgs e)
        {

            this.updateId_panel.Visible = true;
        }

        private void AddManager_Click(object sender, EventArgs e)
        {
            this.addMangerPanel.Visible = true;
        }

        private void AddManagerUser_Click(object sender, EventArgs e)
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
            this.addMangerPanel.Visible = false;
        }
        private void deleteManageById_Click(object sender, EventArgs e)//the button inside the the delete-panel.
        {
            //define the delete 
           // string query = "DELETE FROM gym.manager WHERE id=" + Convert.ToInt32(this.deleteId.Text) + ";";
            if (Manager.isIdExist(Convert.ToInt32(deleteId.Text)) == true)
            {
                Manager.deleteManagerById(Convert.ToInt32(this.deleteId.Text));
                MessageBox.Show("delete manager by Id success!");
            }
            else
            {
                MessageBox.Show("the doesn't exist!\n please try again!");
            }
            this.DeleteManagerPanel.Visible = false;
            
        }

        private void ManagerMenu_Load(object sender, EventArgs e)
        {

        }

        private void addMangerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void update_manger_button_Click(object sender, EventArgs e)
        {
            Manager.deleteManagerById(Convert.ToInt32(managerId.Text));
            AddManagerUser_Click(sender, e);
            this.updateId_panel.Visible = false;
            this.update_manger_button.Visible = false;
            this.exit_update.Visible = false;
        }

        private void editbyId_button_Click(object sender, EventArgs e)
        {   
            if (Manager.isIdExist(Convert.ToInt32(updateId_textBox.Text)) == true)
            {
                this.addMangerPanel.Visible = true;
                this.update_manger_button.Visible = true;
                this.AddManagerUser.Visible = false;//turn on in the end
                this.exit_update.Visible = true;
                DbConnection newConn = new DbConnection("gym", "root", "csharp");

                DataTable dt = new DataTable();
                string query = "SELECT * FROM gym.manager where id ='" + Convert.ToInt32(updateId_textBox.Text)+"';" ;
                newConn.Selectdt(query, dt);
                //DataRow row = dt.Rows[0];
                MessageBox.Show(dt.Rows[0]["firstname"].ToString() );
                this.managerId.Text = dt.Rows[0]["id"].ToString();
                this.managerFirstName.Text = dt.Rows[0]["firstname"].ToString();
                this.managerLastName.Text = dt.Rows[0]["lastname"].ToString();
                this.managerEmail.Text = dt.Rows[0]["email"].ToString();
                this.MangerSalaryPerHour.Text = dt.Rows[0]["salaryperhour"].ToString();
                this.userName.Text = dt.Rows[0]["username"].ToString();
                this.password.Text = dt.Rows[0]["password"].ToString();
                this.update_manger_button.Visible = true;
                
                //here i need to get data table
            }
        }

        private void exit_update_Click(object sender, EventArgs e)
        {
            this.addMangerPanel.Visible = false;
            this.update_manger_button.Visible = false;
            this.exit_update.Visible = false;
            this.updateId_panel.Visible = false;
        }

        

        
    }
}
