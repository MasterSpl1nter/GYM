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



    public partial class View_Applience : Form
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;

        public View_Applience()
        {
            InitializeComponent();

            string constring = "datasource=localhost; port=3306; username=root; password=csharp;";
            //string Query = "insert into gym.appliance (id,firstname,lastname,email,username,password,permission,salaryperhour) values('" + this.id_txt.Text + "' , '" + this.firstname_txt.Text + "' , '" + this.lastname_txt.Text + "' , '" + this.email_txt.Text + "' , '" + this.username_txt.Text + "' , '" + this.password_txt.Text + "','" + 2 + "' , '" + this.salar_txt.Text + "') ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from gym.appliance", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView2.DataSource = bSource;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
