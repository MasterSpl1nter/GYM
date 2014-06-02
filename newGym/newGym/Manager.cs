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
            : base(id, firstName, lastName, email, permission, userName, password)
        {
            this.salaryPerHour = salaryPerHour;
        }
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

        public override void popMenu()
        {
            Form menu = new ManagerMenu();
            menu.ShowDialog();
        }

        //set and get
        public int SalaryPerHour { get { return salaryPerHour; } set { salaryPerHour = value; } }
        //add user
        /*
        public void addUser()
        {
            DbConnection newConn = new DbConnection("gym", "root", "csharp");
            string query = "INSERT INTO `gym`.`manager` (`id`, `firstname`, `lastname`, `email`, `username`, `password`, `permission`,`salaryperhour`) VALUES ('" + Convert.ToInt32(this.Id) + "', '" + this.FirstName + "', '" + this.LastName + "', '" + this.Email + "', '" + this.UserName + "', '" + this.Password + "', '7' " + ",'" + this.salaryPerHour + "' );";
            newConn.writeToDb(query);
        }*/
        public int Add(string table,string insert)
        {
            return MySQL.Insert(table, "id,firstname,lastname,email,username,password,permission,salaryperhour", insert);
        }
        public int addShift(string table, string insert)
        {
            return MySQL.Insert(table, "id,permission,stattime,endtime", insert);
        }
        public void addUser(int id,string firstname,string lastname,string email,string username,string password,int permission,int salaryperhour)
        {
            DbConnection newConn = new DbConnection("gym", "root", "csharp");
            string query = "INSERT INTO `gym`.`manager` (`id`, `firstname`, `lastname`, `email`, `username`, `password`, `permission`,`salaryperhour`) VALUES ('" + Convert.ToInt32(id) + "', '" + firstname + "', '" + lastname + "', '" + email + "', '" + username + "', '" + Password + "','4'  " + ",'" + salaryPerHour + "' );";
            newConn.writeToDb(query);
        }
        /*
        public void updateUser()
        {
            DbConnection newConn = new DbConnection("gym", "root", "csharp");
            string query = "UPDATE `gym`.`manager` SET `firstname`='" + this.FirstName + "', `lastname`='" + this.LastName + "', `email`='" + this.Email + "', `username`='" + this.UserName + "', `password`='" + this.Password + "', `salaryperhour`='" + this.salaryPerHour + "' WHERE `id`='" + Convert.ToInt32(this.Id) + "';";
            newConn.writeToDb(query);
        }*/
        public void updateUser(int id, string firstname, string lastname, string email, string username, string password, int permission, int salaryperhour)
        {
            DbConnection newConn = new DbConnection("gym", "root", "csharp");
            string query = "UPDATE `gym`.`manager` SET `firstname`='" + firstname + "', `lastname`='" + lastname + "', `email`='" + email + "', `username`='" + username + "', `password`='" + password + "', `salaryperhour`='" + salaryperhour + "' WHERE `id`='" + Convert.ToInt32(id) + "';";
            newConn.writeToDb(query);
        }
        public void updateUser(int id, string firstname, string lastname, string email, string username, string password, int permission, int salaryperhour,string table)
        {
            DbConnection newConn = new DbConnection("gym", "root", "csharp");
            string query = "UPDATE gym."+table+ " SET firstname='" + firstname + "', lastname='" + lastname + "', email='" + email + "', username='" + username + "', password='" + password + "', salaryperhour='" + salaryperhour + "' WHERE id='" + Convert.ToInt32(id) + "';";
            newConn.writeToDb(query);
        }
        //delete manager by id    
        public static void deleteManagerById(int id)
        {
            DbConnection newConn = new DbConnection("gym", "root", "csharp");
            string query = "DELETE FROM gym.manager WHERE id='" + id + "';";
           // MessageBox.Show("--->public override bool deleteUserById(int id)");
            newConn.writeToDb(query);

        }
        public void deleteUser(int id, string table)
        {
            int ret=1;
            if (table == "guide")
            {
                if (MessageBox.Show("Warining:delete will remove all data that refer to this" + "id", "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataTable dt = new DataTable();
                    ret = MySQL.Query(dt, "set SQL_SAFE_UPDATES = 0;  delete from studentclass where classid in ( select class.id from class where class.guideid = " + id.ToString() + ");                                            delete from classtime where classid in ( select class.id from class where class.guideid = " + id.ToString() + ");                                            delete from class where guideid = " + id.ToString() + ";                                            delete from guide where id = " + id.ToString() + ";                ");
                }
                else
                    ret = 1;
            }
            else
            {
                DataTable dt = new DataTable();
                string query = "DELETE FROM gym." + table + " WHERE id='" + id + "';";
                ret= MySQL.Query(dt, query);
            }
            /*
            DbConnection newConn = new DbConnection("gym", "root", "csharp");
            string query = "DELETE FROM gym." + table + " WHERE id='" + id + "';";
            int retval=newConn.writeToDb(query);
            */
            if (ret != 1)
                MessageBox.Show("delete Failed Error:" + ret);
            else
                MessageBox.Show("delete success!");
            
           

            
        }
        
        //update user by id
        public bool updateUserById(int id)
        {
            return true;
        }
        //check id id exist
        public static bool isIdExist(int id)
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
        
        protected override bool CheckLogin(DataTable dt, string user, string pass)
        {
            //MessageBox.Show("manager Chek login");
            //if the id exist? yes-pop the datatable of this user
            if (MySQL.Query(dt, "SELECT * FROM manager where username='" + user + "'" + " and password='" + pass + "'") == 0)
                if (dt.Rows.Count == 1)
                    return true;
            return false;
        }

        
       
        protected override void setSalary(int salary)
        {
            this.salaryPerHour = salary;
           
        }
    }


}
