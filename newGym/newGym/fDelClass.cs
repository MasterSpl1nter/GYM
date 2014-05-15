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
    public partial class fDelClass : Form
    {
        private int id = -1;
        public fDelClass()
        {
            InitializeComponent();
            LoadActivityId();
        }
        public fDelClass(int id)
        {
            this.id = id;
            InitializeComponent();
            LoadActivityId();
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
                else if (id == -2)
                    query = "SELECT Id , Name,guideid FROM class";
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
                            if (id == -2)
                                comboBox1.Items.Add(new TableItem(reader.GetString("Id") + " - " + reader.GetString("Name"),"GuideID " + reader.GetString("guideid")));
                            else
                                comboBox1.Items.Add(new TableItem(reader.GetString("Id"), reader.GetString("Name")));

                        }
                    }
                    connection.Close();
                }
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
            this.Close();
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