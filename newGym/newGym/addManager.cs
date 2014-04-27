using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
                this.exit_update.Visible = true;
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
            List<TextBox> err = new List<TextBox>();
            resetLabelColor(this.Controls);
            if(!(Regex.IsMatch(managerId.Text,"^[0-9]{9}$"))|| Manager.isIdExist(Convert.ToInt32(managerId.Text)) == false)/*&& managerId.Text.Length==9 */
            {
                    MessageBox.Show("the id invalid");
                    this.idLabel.ForeColor = System.Drawing.Color.Red;
                    err.Add(managerId);
            }
            if (!(Regex.IsMatch(managerFirstName.Text, "^[a-zA-Z]{1,}$")))
            {
                
                this.firstNameLabel.ForeColor = System.Drawing.Color.Red;
                err.Add(managerFirstName);
            }
            if (!(Regex.IsMatch(managerLastName.Text, "^[a-zA-Z]{1,}$")))
            {
                this.lastNameLabel.ForeColor = System.Drawing.Color.Red;
                err.Add(managerLastName);
            }

            if (!Regex.IsMatch(managerEmail.Text, "^[_a-z0-9-]+(\\.[_a-z0-9-]+)*@[a-z0-9-]+(\\.[a-z0-9-]+)*(\\.[a-z]{2,4})$"))
            {
                this.EmailLabel.ForeColor = System.Drawing.Color.Red;
                err.Add(managerEmail);
            }
            if (!(Regex.IsMatch(MangerSalaryPerHour.Text, "^(([1-9]?)[0-9]{1,})$")))
            {
                this.salaryPerHourLabel.ForeColor = System.Drawing.Color.Red;
                err.Add(MangerSalaryPerHour);
            }
            if (!(Regex.IsMatch(userName.Text, "^[a-z0-9_-]{3,15}$")))
            {
                
                this.userNameLabel.ForeColor = System.Drawing.Color.Red;
                err.Add(userName);
            }
            if (!(Regex.IsMatch(password.Text, "^((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})")))
            {

                this.passwordLabel.ForeColor = System.Drawing.Color.Red;
                err.Add(password);
            }
            if (err.Count > 0)
            {
                MessageBox.Show("Phere are some problems in the details\nfix the details in the red fields!");
                foreach (TextBox t in err)
                {
                    t.Text = "";
                }
            }
            else
            {
                    Manager m = new Manager(Convert.ToInt32(managerId.Text), managerFirstName.Text, managerLastName.Text, managerEmail.Text, 4, userName.Text, password.Text, Convert.ToInt32(MangerSalaryPerHour.Text));
                    m.addUser();
                    MessageBox.Show("add a new manager success!");      
            }
        }
        static void ClearTextBoxes(Control.ControlCollection controls)
        {
            // Cycle through the controls.
            foreach (Control control in controls)
            {
                // The textbox.
                TextBoxBase textBox = (control as TextBoxBase);

                // If there is a textbox, then clear it.
                if (textBox != null)
                {
                    // Set the text to an empty string.
                    textBox.Text = "";
                }
            }
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void update_manger_button_Click(object sender, EventArgs e)
        {

        }

        private void exit_update_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
            /*
            this.managerFirstName.Text = "";
            this.managerLastName.Text = "";
            this.managerEmail.Text = "";
            this.MangerSalaryPerHour.Text = "";
            this.userName.Text = "";
            this.password.Text = "";
             */
        }
        static void resetLabelColor(Control.ControlCollection controls)
        {
            // Cycle through the controls.
            foreach (Control control in controls)
            {
                Label l = (control as Label);
                if (l != null)
                    l.ForeColor = SystemColors.ControlText; ;
            }
        }
    }
}
