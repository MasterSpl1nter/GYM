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
    public partial class fDelClass : GForm
    {
        private DataTable dt;
        private int classId = -1;
        public fDelClass()
        {
            InitializeComponent();
            LoadActivityId();
        }
        public fDelClass(int id)
        {
            this.classId = id;
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
                query = "SELECT Id , Name FROM class";


                using (var command = new MySqlCommand(query, connection))
                {
                    if (classId != -1)
                        command.Parameters.AddWithValue("?id", classId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(new TableItem(reader.GetString("Id"), reader.GetString("Name")));
                        }
                    }
                    connection.Close();
                }
            }
        }

        public void deleteAll()     // removes added class id without schedules
        {
            if (classId == -1)
                MessageBox.Show("Wrong id");

            DelbyID();
            delScedules();
            delStudentsFromClass();
        }

        private Boolean DelbyID()
        {
            if (this.classId != -1)
            {
                try
                {

                    var connectionString = @"server=localhost;userid=root;password=csharp;database=gym";
                    using (var connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        var query = "DELETE FROM `gym`.`class` WHERE `id`=?classId";

                        var cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("?classId", classId);

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
            MessageBox.Show("Not id was sent", "Error");
            return false;
        }
        private Boolean delStudentsFromClass()
        {
            if (this.classId != -1)
            {
                dt = new DataTable();
                try
                {
                    MySQL.Delete("studentclass", "classid=" + classId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error has accurred: " + ex.Message,
                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            MessageBox.Show("Not id was sent", "Error");
            return false;
        }

        private Boolean delScedules()
        {
            if (this.classId != -1)
            {
                dt = new DataTable();
                try
                {
                    MySQL.Delete("classtime", "classid=" + classId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error has accurred: " + ex.Message,
                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            MessageBox.Show("Not id was sent", "Error");
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mycombotxt = comboBox1.Text;
            string[] Id = mycombotxt.Split(' ');    //take id from combobox
            bool result = Int32.TryParse(Id[0], out this.classId);      // give THIS.classId a value
            try
            {
                if (result)
                {
                    if (DelbyID())
                    {
                        if (delScedules())
                        {
                            if (delStudentsFromClass())
                            {
                                MessageBox.Show("The item was removed", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                comboBox1.Items.Clear();
                                LoadActivityId();
                            }
                        }
                    }
                    else
                        MessageBox.Show("The item was not removed");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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