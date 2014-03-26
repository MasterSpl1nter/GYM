using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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
    }
}
