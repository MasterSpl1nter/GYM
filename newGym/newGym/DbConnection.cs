using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace newGym
{
    class DbConnection
    {
        private MySqlConnection connection;
        private string server;
        private string port;
        private string database;
        private string userName;
        private string password;

        public DbConnection(string database,string username,string password)
        {
            this.database = database;
            this.userName = username;
            this.password = password;
            this.port = "3306";
            this.server = "localhost";
            string myconn = "datasource="+server+";port=" +port+ ";username=" +userName+ ";password="+password+ ";" ;

            connection = new MySqlConnection(myconn);
        }
        public MySqlConnection Connetion { get { return this.connection; } }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1045)
                    MessageBox.Show("connection failed , please try again");
                else
                    MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public int writeToDb(string query)//for UPDATE,DELETE INSERT
        {
            int retval=0;
            if (this.OpenConnection() == true)
            {
                MySqlCommand myCmd = new MySqlCommand(query, this.connection);
                retval =myCmd.ExecuteNonQuery();
                this.CloseConnection();
            }
            return retval;
        }

        public bool Selectdt(string query, DataTable dt)
        {
            if (this.OpenConnection() == true)
            {

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(dt);
                return true;
            }
            else
                return false;

        }
    }


}
