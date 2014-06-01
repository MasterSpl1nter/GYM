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
    public partial class FormAddTraining : Form
    {
        /*
        MySqlCommandBuilder cmdb1;
        MySqlDataAdapter sda;
        DataSet dbdataset;
         */
        private DataTable dt;
        public FormAddTraining()
        {
            InitializeComponent();
            Fillcombo();
            Fillcombo1();
            load_table();

        }
        void Fillcombo1()
        {
            string constring = "datasource=localhost; port=3306; username=root; password=csharp;";
            string Query = "select * from gym.training  ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())     //adding names to combobox
                {
                    string sName = myReader.GetString("id");
                    comboBox2.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void load_table()
        {
            string constring = "datasource=localhost; port=3306; username=root; password=csharp;";
            //string Query = "insert into gym.appliance (id,firstname,lastname,email,username,password,permission,salaryperhour) values('" + this.id_txt.Text + "' , '" + this.firstname_txt.Text + "' , '" + this.lastname_txt.Text + "' , '" + this.email_txt.Text + "' , '" + this.username_txt.Text + "' , '" + this.password_txt.Text + "','" + 2 + "' , '" + this.salar_txt.Text + "') ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from gym.training", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
        void Fillcombo()
        {
            dt = new DataTable();
            MySQL.Select(dt, "appliance");
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name";
            
            string constring = "datasource=localhost; port=3306; username=root; password=csharp;";
            string Query = "select * from gym.appliance  ;";
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
                    comboBox1.Items.Add(sName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        

        private void save_button_Click(object sender, EventArgs e)
        {
            bool err = false;
        //======

            if (id_txt.Text.Length == 0)
            { 
                MessageBox.Show("ID invalid, Pleas try again", "ERROR", MessageBoxButtons.OK);
                
                err = true;
                return;
            }
            if (sets_txt.Text.Length == 0)
            {
                MessageBox.Show("Empty sets, Pleas try again", "ERROR", MessageBoxButtons.OK);

                err = true;
                return;
            }
            if (name_txt.Text.Length == 0)
            {
                MessageBox.Show("Empty name, Pleas try again", "ERROR", MessageBoxButtons.OK);

                err = true;
                return;
            }

            if (repeats_txt.Text.Length == 0)
            {
                MessageBox.Show("Empty repeats, Pleas try again", "ERROR", MessageBoxButtons.OK);

                err = true;
                return;
            }

            if (err == false)
            {
                string constring = "datasource=localhost; port=3306; username=root; password=csharp;";
                string Query = "insert into gym.training (id,name,appliance,sets,repeats) values('" + this.id_txt.Text + "' , '" + this.name_txt.Text + "' ,'" + dt.Rows[comboBox1.SelectedIndex]["ID"] + "' , '" + this.sets_txt.Text + "' , '" + this.repeats_txt.Text + "') ;";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;


                try
                {
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    
                    MessageBox.Show("Training Added");
                    load_table();



                    while (myReader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=csharp;";
            string Query = "delete from gym.training where id='" + this.comboBox2.Text + "' ;";
            
            MySqlConnection conDataBase = new MySqlConnection(constring);
            
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                
                MessageBox.Show("Training Deleted");
                load_table();
                


                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=csharp;";
            string Query = "select * from gym.training where id='" + comboBox2.Text + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;


            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())     //adding names to textboxes
                {
                    string sID = myReader.GetString("id").ToString();
                    string sName = myReader.GetString("name");
                    string sAppliance = myReader.GetString("appliance").ToString();  
                    string sSets = myReader.GetString("sets").ToString();
                    string sRepeats = myReader.GetString("repeats").ToString();
                    
                    delid_txt.Text = sID;
                    delname_txt.Text = sName;
                    delappliance_txt.Text = sAppliance;
                    delsets_txt.Text = sSets;
                    delrepeats_txt.Text = sRepeats;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void id_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)       //check if its numbers only and incude backspace key
            {
                MessageBox.Show("Enter Numbers Only");
                e.KeyChar = (char)0;
            }
        }

        private void sets_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)       //check if its numbers only and incude backspace key
            {
                MessageBox.Show("Enter Numbers Only");
                e.KeyChar = (char)0;
            }
        }

        private void repeats_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)       //check if its numbers only and incude backspace key
            {
                MessageBox.Show("Enter Numbers Only");
                e.KeyChar = (char)0;
            }
        }

        
    }
}

