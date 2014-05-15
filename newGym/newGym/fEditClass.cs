using System;
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
    public partial class fEditClass : Form
    {
        private int id = -1;
        public fEditClass()
        {
            InitializeComponent();
            LoadActivityId();
        }
        public fEditClass(int id)
        {
            this.id = id;
            InitializeComponent();
            LoadActivityId();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Load Activity ID to a combobox
        private void LoadActivityId()
        {
            var query = "";
            var connectionString = @"server=localhost;userid=root;password=csharp;database=gym";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                if (id == -1)
                    query = "SELECT Id , Name FROM class";
                else
                    query = "SELECT Id , Name FROM class WHERE `guideid`=?Id";


                using (var command = new MySqlCommand(query, connection))
                {
                    if (id != -1)
                        command.Parameters.AddWithValue("?id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(new TableItem(reader.GetString("Id"), reader.GetString("Name")));
                        }
                    }
                }
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
