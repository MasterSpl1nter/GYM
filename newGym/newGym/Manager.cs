using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace newGym
{
    class Manager:Person
    {
        private int salaryPerHour;
        public Manager(): base()
        {
            salaryPerHour = 0;
        }
        public Manager(int id, string firstName, string lastName, string email, int permission, string userName, string password, int salaryPerHour=0)
            : base(id, firstName, lastName, email, permission, userName, password)
        {
            this.salaryPerHour = salaryPerHour;
        }

        public int SalaryPerHour { get { return salaryPerHour; } set { salaryPerHour = value; } }

        public  void addUser() 
        {
            DbConnection newConn = new DbConnection("gym", "root", "csharp");
            string query = "INSERT INTO `gym`.`manager` (`id`, `firstname`, `lastname`, `email`, `username`, `password`, `permission`,`salaryperhour`) VALUES ('" + Convert.ToInt32(this.Id) + "', '" + this.FirstName + "', '" + this.LastName + "', '" + this.Email + "', '" + this.UserName + "', '" + this.Password + "', '7' " + ",'" + this.salaryPerHour + "' );";
            newConn.writeToDb(query);

            
        }
        public static void deleteManagerById(int id) 
        {
            DbConnection newConn = new DbConnection("gym", "root", "csharp");
            string query = "DELETE FROM gym.manager WHERE id='" + id + "';";
            MessageBox.Show("--->public override bool deleteUserById(int id)");
            newConn.writeToDb(query);
              
        }
        public  bool updateUserById(int id) 
        {
            return true;
        }

        public static  bool isIdExist(int id)
        {
            DbConnection newConn = new DbConnection("gym", "root", "csharp");
            MessageBox.Show("now checking if id exist--->public override bool isIdExist(int id)");
            try
            {
                if (newConn.OpenConnection() == true)
                {
                    DataTable dt = new DataTable();
                    string query = "SELECT * FROM gym.manager WHERE id='" + id + "';";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, newConn.Connetion);
                    adapter.Fill(dt);
                    newConn.CloseConnection();
                    if (dt.Rows.Count > 0)
                    {
                        return true;
                    } 
                }
                

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false; 
        }
        /*
        public DataTable getRecordById(int id)
        {
 
        }
         */
    }


}
