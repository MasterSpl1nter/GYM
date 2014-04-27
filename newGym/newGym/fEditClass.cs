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
        public fEditClass()
        {
            InitializeComponent();
            LoadActivityId();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
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
                            comboBox1.Items.Add(new TableItem(reader.GetString("Id"), reader.GetString("Name")));
                        }
                    }
                }
                connection.Close();
            }
        }
    }
}
