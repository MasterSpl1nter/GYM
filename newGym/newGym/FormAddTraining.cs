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
        MySqlCommandBuilder cmdb1;
        MySqlDataAdapter sda;
        DataSet dbdataset;
        public FormAddTraining()
        {
            InitializeComponent();
            load_table();
            Fillcombo();
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
                    string sName = myReader.GetString("name");
                    comboBox1.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void update_button_Click(object sender, EventArgs e)
        {
            try
            {
                cmdb1 = new MySqlCommandBuilder(sda);
                sda.Update(dbdataset);
                MessageBox.Show("Information Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost; port=3306; username=root; password=csharp;";
            string Query = "insert into gym.training (id,name,appliance,sets,repeats) values('" + this.id_txt.Text + "' , '" + this.name_txt.Text + "' , '" + this.comboBox1.Text + "' , '" + this.sets_txt.Text + "' , '" + this.repeats_txt.Text + "') ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

          
                try
                {
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    MessageBox.Show("Training Added");

                    this.Close();


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
    }

