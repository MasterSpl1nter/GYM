using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace newGym
{
    class Student:Person
    {
        //DateTime birthday;
        //DateTime startDate;
        //DateTime endDate;
        //DateTime medcert;

        public static int Delete(string id)
        {
            return MySQL.Delete("student", "id=" + id);
        }

       protected override bool CheckLogin(DataTable dt, string user, string pass)
        { return false; }

       protected override void makeInstance(int id, string firstName, string lastName, string email, int permission, string userName, string password, int salary)
       {
           throw new NotImplementedException();
       }
    }
}