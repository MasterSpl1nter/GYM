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
    public partial class editManager : Form
    {
        string perm;
        string table;
        public editManager(String id)
        {
            InitializeComponent();
            
            string []arr= {"manager","guide","trainer","student","worker"};
            
            int retval=-1;
            DataTable dt = new DataTable();
            for (int i = 0; i < arr.Length; i++)
            {
                retval = MySQL.Query(dt, "SELECT * FROM " + arr[i] + " where id=" + id);
                if (dt.Rows.Count == 1) {
                    this.table = arr[i];
                    break;
                }
            }

           // if (retval==0)
            //{
                this.userId.Text = dt.Rows[0]["id"].ToString();
                this.managerFirstName.Text = dt.Rows[0]["firstname"].ToString();
                this.managerLastName.Text = dt.Rows[0]["lastname"].ToString();
                this.managerEmail.Text = dt.Rows[0]["email"].ToString();
                this.MangerSalaryPerHour.Text = dt.Rows[0]["salaryperhour"].ToString();
                this.userName.Text = dt.Rows[0]["username"].ToString();
                this.password.Text = dt.Rows[0]["password"].ToString();
                this.perm = dt.Rows[0]["permission"].ToString();
            //}
        }

        private void update_manger_button_Click(object sender, EventArgs e)
        {
            List<TextBox> err = new List<TextBox>();
            resetLabelColor(this.Controls);

            checkFields(err);
            if (err.Count > 0)
            {
                MessageBox.Show("there are some problems in the details\nfix the details in the red fields!");
                foreach (TextBox t in err)
                {
                    t.Text = "";
                }
            }
            else
            {
                ((Manager)SingleUser.Instance.get_user()).updateUser(Convert.ToInt32(userId.Text), managerFirstName.Text, managerLastName.Text, managerEmail.Text, userName.Text, password.Text, Convert.ToInt32(this.perm), Convert.ToInt32(MangerSalaryPerHour.Text), this.table);
                MessageBox.Show(" update "+this.table +" success!");
            }
        }

        private void exit_update_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);

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
        public void checkFields(List<TextBox> err)
        {

            resetLabelColor(this.Controls);
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
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
