﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace newGym
{
    class Guide : Person
    {
        private int salary;
        public Guide(int id,string firstName,string lastName,string email,int permission,string userName,string password,int salary) : base(id, firstName, lastName, email, permission, userName, password)
        {
            this.salary = salary;
        }
        public static bool CheckLogin(string user,string pass)
        {
            DataTable dt = new DataTable();
            if (MySQL.Query(dt,"SELECT username,password FROM guide where username='" + user + "'" + " and password='" + pass + "'") == 0)
                if (dt.Rows.Count == 1)
                    return true;
            return false;
        }
        public static int Update(string insert,string where)
        {
            return MySQL.Update("guide", insert, "id=" + where);
        }
        public static int Add(string insert)
        {
            return MySQL.Insert("guide", "id,firstname,lastname,email,username,password,permission,salaryperhour", insert);
        }
        public static int Delete(string id)
        {
            return MySQL.Delete("guide", "id="+id);
        }
        public static int SearchID(DataTable dt,string search)
        {
            int retval = MySQL.Query(dt, "SELECT id,firstname,lastname,email FROM guide where id LIKE " + search);
            if (retval == 0)
                return 0;
            return retval;
        }
        public static int SearchName(DataTable dt, string search)
        {
            int retval = MySQL.Query(dt, "SELECT id,firstname,lastname,email FROM guide where firstname LIKE " + "'%" + search.Split(' ')[0] + "%' and lastname LIKE '%" + search.Split(' ')[1] + "%'" );
            if (retval == 0)
                return 0;
            return retval;
        }
        public static int SearchStudID(DataTable dt, string search)
        {
            int retval = MySQL.Query(dt, "SELECT id,firstname,lastname,email,birthday,startdate,enddate,medcert FROM student where id LIKE " + search);
            if (retval == 0)
                return 0;
            return retval;
        }
        public static int SearchStudName(DataTable dt, string search)
        {
            int retval = MySQL.Query(dt, "SELECT id,firstname,lastname,email,birthday,startdate,enddate,medcert FROM student where firstname LIKE " + "'%" + search.Split(' ')[0] + "%' and lastname LIKE '%" + search.Split(' ')[1] + "%'");
            if (retval == 0)
                return 0;
            return retval;
        }
    }
}
