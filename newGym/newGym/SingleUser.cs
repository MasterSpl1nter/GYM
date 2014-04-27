using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace newGym
{
    class SingleUser
    {
        private static Lazy<SingleUser> instance = new Lazy<SingleUser>(() => new SingleUser());

        private SingleUser() { }

        private Person person;

        public static SingleUser Instance
        {
            get
            {
                if (instance.IsValueCreated == false)
                {
                    instance = new Lazy<SingleUser>(() => new SingleUser());
                }
                return instance.Value;
            }
        }

        public void set_user(Person person)
        {
            this.person = person;
        }


        public Person get_user()
        {
            return this.person;
        }
    }
}
