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
    public partial class TrainingToStudent : Form
    {
        //DataTable dtmp;
        DataTable dt;

        public TrainingToStudent()
        {
            InitializeComponent();
            Fillcombo();
            Fillcombo1();
        }
        public void Fillcombo()
        {
            dt = new DataTable();
            MySQL.Select(dt, "student");
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "id";

            string constring = "datasource=localhost; port=3306; username=root; password=csharp;";
            string Query = "select * from gym.student  ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())     //adding  to combobox
                {

                    string sID = myReader.GetString("id");
                    //  comboBox1.Items.Add(sID);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Fillcombo1()
        {
            dt = new DataTable();
            MySQL.Select(dt, "training");
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "name";

            string constring = "datasource=localhost; port=3306; username=root; password=csharp;";
            string Query = "select * from gym.training  ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())     //adding  to combobox
                {

                    string sName = myReader.GetString("name");
                    // comboBox1.Items.Add(sName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void training2student_betton_Click(object sender, EventArgs e)
        {
            bool err = false;
            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Please chose student id", "ERROR", MessageBoxButtons.OK);

                err = true;
                return;
            }
            else
                if (comboBox2.Text.Length == 0)
                {
                    MessageBox.Show("Please chose training id", "ERROR", MessageBoxButtons.OK);

                    err = true;
                    return;
                }
                else
                    if (err == false)
                    {
                        string constring = "datasource=localhost; port=3306; username=root; password=csharp;";
                        string Query = "insert into gym.studenttraining (studentid,trainingid) values('" + comboBox1.Text + "' , '" + dt.Rows[comboBox2.SelectedIndex]["ID"] + "') ;";
                        MySqlConnection conDataBase = new MySqlConnection(constring);
                        MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                        MySqlDataReader myReader;


                        try
                        {
                            conDataBase.Open();
                            myReader = cmdDataBase.ExecuteReader();
                            MessageBox.Show("Training Added");



                            while (myReader.Read())
                            {

                            }
                        }
                        catch (MySqlException ex)
                        {
                            if (ex.Number == 1062)
                                MessageBox.Show("Student allready has this training.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=csharp;";
            string Query = "select * from gym.student where id='" + comboBox1.Text + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;


            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())     //adding names to textboxes
                {
                    string sName = myReader.GetString("firstname");
                    string sLastname = myReader.GetString("lastname");


                    name_txt.Text = sName;
                    lastname_txt.Text = sLastname;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sets_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=csharp;";
            string Query = "select * from gym.training where id='" + dt.Rows[comboBox2.SelectedIndex]["ID"] + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;


            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())     //adding names to textboxes
                {

                    string sAppliance = myReader.GetString("appliance").ToString();
                    string sSets = myReader.GetString("sets").ToString();
                    string sRepeats = myReader.GetString("repeats").ToString();


                    appliance_txt.Text = sAppliance;
                    sets_txt.Text = sSets;
                    repeats_txt.Text = sRepeats;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
