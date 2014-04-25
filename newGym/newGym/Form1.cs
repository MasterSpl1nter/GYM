using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newGym
{
    public partial class GuideForm : Form
    {
        private int op;
        private DataTable dt;

        public GuideForm(int op)
        {
            this.op = op;
            InitializeComponent();
            idText.Tag = label6;
            fnameText.Tag = label1;
            lnameText.Tag = label2;
            emailText.Tag = label3;
            userText.Tag = label4;
            passText.Tag = label5;
            salaryText.Tag = label7;
            if (op == 1)
            {
                dt = new DataTable();
                MySQL.Select(dt, "guide");
                idText.Visible = false;
                AddGuideButton.Visible = false;
                DeleteGuideButton.Visible = false;
                EditGuideButton.Visible = true;
                comboBox1.Visible = true;
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "id";
            }
            else if (op == 2)
            {
                dt = new DataTable();
                MySQL.Select(dt, "guide");
                idText.Visible = false;
                AddGuideButton.Visible = false;
                EditGuideButton.Visible = false;
                DeleteGuideButton.Visible = true;
                comboBox1.Visible = true;
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "id";
            }
        }

        private void AddGuideButton_Click(object sender, EventArgs e)
        {

            int[] a=Person.ZeroID(Convert.ToInt32(idText.Text));
            idText.Text = "";
            for (int i = 0; i < 9; i++)
            {
                idText.Text += a[i];
            }

            if (ValidateInput())
            {
                string insert = String.Format("{0},'{1}','{2}','{3}','{4}','{5}',{6},{7}", idText.Text, fnameText.Text, lnameText.Text, emailText.Text, userText.Text, passText.Text, 3, salaryText.Text);
                int retval=Guide.Add(insert);
                if (retval == 0)
                {
                    MessageBox.Show("Guide has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (retval == 1062)
                {
                    MessageBox.Show("Guide with this ID or Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("ERROR #" + retval);
                }
            }

        }

        private void EditGuideButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string insert = String.Format("id={0},firstname='{1}',lastname='{2}',email='{3}',username='{4}',password='{5}',permission={6},salaryperhour={7}", dt.Rows[comboBox1.SelectedIndex]["ID"].ToString(), fnameText.Text, lnameText.Text, emailText.Text, userText.Text, passText.Text, 3, salaryText.Text);
                int retval = Guide.Update(insert, dt.Rows[comboBox1.SelectedIndex]["ID"].ToString());
                if (retval == 0)
                {
                    dt = new DataTable();
                    MySQL.Select(dt,"guide");
                    MessageBox.Show("Guide has been edited.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR #" + retval);
                }
            }
        }

        private void DeleteGuideButton_Click(object sender, EventArgs e)
        {
            int retval = Guide.Delete(dt.Rows[comboBox1.SelectedIndex]["ID"].ToString());
            if (retval == 0)
            {
                dt = new DataTable();
                MySQL.Select(dt, "guide");
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "id";
                MessageBox.Show("Guide has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (retval == 1451)
            {
                MessageBox.Show("Cannot delete a guide that is a guide of active class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("ERROR #" + retval);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fnameText.Text = dt.Rows[comboBox1.SelectedIndex]["firstname"].ToString();
            lnameText.Text = dt.Rows[comboBox1.SelectedIndex]["lastname"].ToString();
            emailText.Text = dt.Rows[comboBox1.SelectedIndex]["email"].ToString();
            userText.Text = dt.Rows[comboBox1.SelectedIndex]["username"].ToString();
            passText.Text = dt.Rows[comboBox1.SelectedIndex]["password"].ToString();
            salaryText.Text = dt.Rows[comboBox1.SelectedIndex]["salaryperhour"].ToString();
        }

        private void idText_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the character is not a digit, don't let it show up in the textbox.
            if (!char.IsDigit(e.KeyChar) && e.KeyChar!=(char)Keys.Back)
                e.Handled = true;
        }
        private void salaryText_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the character is not a digit, don't let it show up in the textbox.
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetTexts();
        }

        private void ResetTexts()
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is TextBox)
                {
                    c.ResetText();
                }
            }
        }


        private bool ValidateInput()
        {
            bool err = false;
            foreach (Control c in panel1.Controls)
            {
                if (c is TextBox && c.Text.Length == 0 && c.Tag is Label)
                {
                    if (c.Visible != false)
                    {
                        ((Label)c.Tag).ForeColor = System.Drawing.Color.Red;
                        err = true;
                    }
                }
                else if (c.Tag is Label)
                {
                    ((Label)c.Tag).ForeColor = System.Drawing.Color.Black;
                }
            }
            if (err)
            {
                MessageBox.Show("Fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (idText.Visible == true && !Person.ValidateID(idText.Text))
            {
                ((Label)idText.Tag).ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Invalid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                idText.Focus();
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(emailText.Text,"^[_a-z0-9-]+(\\.[_a-z0-9-]+)*@[a-z0-9-]+(\\.[a-z0-9-]+)*(\\.[a-z]{2,4})$"))
            {
                ((Label)emailText.Tag).ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailText.ResetText();
                emailText.Focus();
                return false;
            }
            return true;
        }

    }
}
