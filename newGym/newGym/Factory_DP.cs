using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace newGym
{
    class Factory_DP
    {
        public static Person PersonFactory(string type = "no_type", int privilege = 0 )
        {
            if (type == "Secretary"|| privilege==1) {
                return new Secretary();
            }
            else if (type == "Guide" || privilege == 1)
            {
                return new Guide();
            }
            else if (type == "Manager" || privilege == 1)
            {
                return new Manager();
            }
            else if (type == "Student" || privilege == 1)
            {
                return new Student();
            }
            else if (type == "Trainer" || privilege == 1)
            {
                return new Trainer();
            }
           
            

            return null;
        }


    }
}
