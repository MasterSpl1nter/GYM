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
        string[] arr = { "manager", "guide", "trainer", "student", "worker" };
        ManagerResult m;
        public editManager(String id, ManagerResult m, string perm)
        {
            InitializeComponent();
            //connection to the previous form
            this.m = m;
            this.perm = perm;
            MessageBox.Show(perm);
            int retval = -1;
            DataTable dt = new DataTable();
            for (int i = 0; i < arr.Length; i++)
            {
                retval = MySQL.Query(dt, "SELECT * FROM " + arr[i] + " where id=" + id);
                if (dt.Rows.Count == 1)
                {
                    this.table = arr[i];
                    break;
                }
            }

            this.userId.Text = dt.Rows[0]["id"].ToString();
            this.managerFirstName.Text = dt.Rows[0]["firstname"].ToString();
            this.managerLastName.Text = dt.Rows[0]["lastname"].ToString();
            this.managerEmail.Text = dt.Rows[0]["email"].ToString();
            this.MangerSalaryPerHour.Text = dt.Rows[0]["salaryperhour"].ToString();
            this.userName.Text = dt.Rows[0]["username"].ToString();
            this.password.Text = dt.Rows[0]["password"].ToString();
            this.perm = dt.Rows[0]["permission"].ToString();


        }

        private void update_manger_button_Click(object sender, EventArgs e)
        {
            List<TextBox> err = new List<TextBox>();
            resetLabelColor(this.Controls);

            checkFields(err);
            if (err.Count > 0)
            {
                //MessageBox.Show("there are some problems in the details\nfix the details in the red fields!");
                foreach (TextBox t in err)
                {
                    t.Text = "";
                }
            }
            else
            {
                ((Manager)SingleUser.Instance.get_user()).updateUser(Convert.ToInt32(userId.Text), managerFirstName.Text, managerLastName.Text, managerEmail.Text, userName.Text, password.Text, Convert.ToInt32(this.perm), Convert.ToInt32(MangerSalaryPerHour.Text), this.table);
                MessageBox.Show("Update " + this.table + " succeeded!");
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
        public bool checkFields(List<TextBox> err)
        {
            bool error = false;
            foreach (Control c in Controls)
            {
                if (c is TextBox && c.Text.Length == 0)
                {
                    if (c.Visible != false)
                    {
                        err.Add((TextBox)c);
                        error = true;
                    }
                }
            }
            if (error)
            {
                MessageBox.Show("Fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            resetLabelColor(this.Controls);
            if (!(Regex.IsMatch(managerFirstName.Text, "^[a-zA-Z]{1,}$")))
            {

                this.firstNameLabel.ForeColor = System.Drawing.Color.Red;
                err.Add(managerFirstName);
                MessageBox.Show("First name should contain letters only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!(Regex.IsMatch(managerLastName.Text, "^[a-zA-Z]{1,}$")))
            {
                this.lastNameLabel.ForeColor = System.Drawing.Color.Red;
                err.Add(managerLastName);
                MessageBox.Show("Last name should contain letters only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(managerEmail.Text, "^[_a-z0-9-]+(\\.[_a-z0-9-]+)*@[a-z0-9-]+(\\.[a-z0-9-]+)*(\\.[a-z]{2,4})$"))
            {
                this.EmailLabel.ForeColor = System.Drawing.Color.Red;
                err.Add(managerEmail);
                MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!(Regex.IsMatch(MangerSalaryPerHour.Text, "^(([1-9]?)[0-9]{1,})$")))
            {
                this.salaryPerHourLabel.ForeColor = System.Drawing.Color.Red;
                err.Add(MangerSalaryPerHour);
                MessageBox.Show("Salary should contain numbers only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!(Regex.IsMatch(userName.Text, "^[a-z0-9_-]{3,15}$")))
            {

                this.userNameLabel.ForeColor = System.Drawing.Color.Red;
                err.Add(userName);
                MessageBox.Show("Username length must be 3-15.\nUsername must only contain letters, numbers, underscores, hyphens.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
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

        private void managerFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void removeUser_Click(object sender, EventArgs e)
        {


            // user clicked yes


            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ((Manager)SingleUser.Instance.get_user()).deleteUser(Convert.ToInt32(this.userId.Text), getPerm());
                this.Close();
                m.Close();
            }
            else
            {

            }
        }
        /*
        for (int i = 0; i < arr.Length; i++)
        {
          DataTable dt = new DataTable();
           int retval = MySQL.Query(dt, "SELECT * FROM " + arr[i] + " where id=" + this.userId.Text);
           if (dt.Rows.Count == 1)
            {
               ((Manager)SingleUser.Instance.get_user()).deleteUser(Convert.ToInt32(this.userId.Text), arr[i]);
                break;
            }  
        }*/


        public string getPerm()
        {
            if (this.perm.Equals("0")) return "student";
            else if (this.perm.Equals("1")) return "worker";
            else if (this.perm.Equals("2")) return "trainer";
            else if (this.perm.Equals("3")) return "guide";
            else if (this.perm.Equals("4")) return "manager";

            else return "student";
        }

    }


}


