﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newGym
{
    public partial class fDelClass : Form
    {
        public fDelClass()
        {
            InitializeComponent();
            LoadActivityId();
        }

<<<<<<< HEAD
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
=======
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372

        //Load Activity ID to a combobox
        private void LoadActivityId()
        {
            var connectionString = @"server=localhost;userid=root;password=csharp;database=gym";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT Id , Name FROM class";

                using (var command = new MySqlCommand(query, connection))
                {

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {    
                            comboBox1.Items.Add( new TableItem(reader.GetString("Id"),reader.GetString("Name")));
                        }
                    }
                }
                connection.Close();
            }
        }

        private Boolean DelbyID(int Id)
        {

            try
            {

                var connectionString = @"server=localhost;userid=root;password=csharp;database=gym";
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    var query = "DELETE FROM `gym`.`class` WHERE `id`=?Id";

                    var cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("?id", Id);
                        
                        cmd.ExecuteNonQuery();
                    
                    connection.Close();

                }
            }

            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + "has accurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }


        private void button1_Click(object sender, EventArgs e)
        {
         
            int num;
            string mycombotxt = comboBox1.Text;
            string[] Id = mycombotxt.Split(' ');    //take id from combobox
            bool result = Int32.TryParse(Id[0], out num);
            try
            {
                if (result)
                {
                    if (DelbyID(num))
                    {
                        MessageBox.Show("הפעולה בוצעה");
                        comboBox1.Items.Clear();
                        LoadActivityId();
                    }
                    else
                        MessageBox.Show("הפעולה לא בוצעה");
                }
            }

             catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

class TableItem     // make combobox show 2 colums
{
    private string str1;
    private string str2;

    public TableItem(string str1, string str2)
    {
        this.str1 = str1;
        this.str2 = str2;
    }
    public override string ToString()
    {
        return str1 + " - " + str2;
    }

}