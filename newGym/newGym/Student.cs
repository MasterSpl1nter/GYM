using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}