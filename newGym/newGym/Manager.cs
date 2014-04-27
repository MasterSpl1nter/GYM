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
<<<<<<< HEAD
    class Manager:Person
    {
        private int salaryPerHour;
        public Manager(): base()
        {
            salaryPerHour = 0;
        }
        public Manager(int id, string firstName, string lastName, string email, int permission, string userName, string password, int salaryPerHour=0)
=======

    public class Manager : Person
    {
        private int salaryPerHour;
        //con't
        public Manager()
            : base()
        {
            salaryPerHour = 0;
        }

        public Manager(int id, string firstName, string lastName, string email, int permission, string userName, string password, int salaryPerHour = 0)
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
            : base(id, firstName, lastName, email, permission, userName, password)
        {
            this.salaryPerHour = salaryPerHour;
        }
<<<<<<< HEAD

        public int SalaryPerHour { get { return salaryPerHour; } set { salaryPerHour = value; } }

        public  void addUser() 
=======
        public void setManager(int id, string firstName, string lastName, string email, int permission, string userName, string password, int salaryPerHour = 0)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = LastName;
            this.Email = email;
            this.Permission = 7;
            this.UserName = userName;
            this.Password = password;
            this.salaryPerHour = salaryPerHour;
        }
        
        //set and get
        public int SalaryPerHour { get { return salaryPerHour; } set { salaryPerHour = value; } }
        //add user
        public void addUser()
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
        {
            DbConnection newConn = new DbConnection("gym", "root", "csharp");
            string query = "INSERT INTO `gym`.`manager` (`id`, `firstname`, `lastname`, `email`, `username`, `password`, `permission`,`salaryperhour`) VALUES ('" + Convert.ToInt32(this.Id) + "', '" + this.FirstName + "', '" + this.LastName + "', '" + this.Email + "', '" + this.UserName + "', '" + this.Password + "', '7' " + ",'" + this.salaryPerHour + "' );";
            newConn.writeToDb(query);
<<<<<<< HEAD

            
        }
        public static void deleteManagerById(int id) 
=======
        }

        public void updateUser()
        {
            DbConnection newConn = new DbConnection("gym", "root", "csharp");
            string query = "UPDATE `gym`.`manager` SET `firstname`='" + this.FirstName + "', `lastname`='" + this.LastName + "', `email`='" + this.Email + "', `username`='" + this.UserName + "', `password`='" + this.Password + "', `salaryperhour`='" + this.salaryPerHour + "' WHERE `id`='" + Convert.ToInt32(this.Id) + "';";
            newConn.writeToDb(query);
        }
        //delete manager by id    
        public static void deleteManagerById(int id)
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
        {
            DbConnection newConn = new DbConnection("gym", "root", "csharp");
            string query = "DELETE FROM gym.manager WHERE id='" + id + "';";
            MessageBox.Show("--->public override bool deleteUserById(int id)");
            newConn.writeToDb(query);
<<<<<<< HEAD
              
        }
        public  bool updateUserById(int id) 
        {
            return true;
        }

        public static  bool isIdExist(int id)
=======

        }
        //update user by id
        public bool updateUserById(int id)
        {
            return true;
        }
        //check id id exist
        public static bool isIdExist(int id)
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
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
<<<<<<< HEAD
                    } 
                }
                
=======
                    }
                }

>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
<<<<<<< HEAD
            return false; 
        }
        /*
        public DataTable getRecordById(int id)
        {
 
        }
         */
=======
            return false;
        }
        protected override bool CheckLogin(DataTable dt, string user, string pass)
        {
            if (MySQL.Query(dt, "SELECT * FROM manager where username='" + user + "'" + " and password='" + pass + "'") == 0)
                if (dt.Rows.Count == 1)
                    return true;
            return false;
        }

        
        protected override void makeInstance(int id, string firstName, string lastName, string email, int permission, string userName, string password, int salary)
        {
             
            //ManagerMenu ma = new ManagerMenu();
            //ma.ShowDialog();
        }
>>>>>>> a6eb957d5db8d287d68f66cfe03d18c8bba9d372
    }


}
