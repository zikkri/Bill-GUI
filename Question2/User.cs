using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class User
    {
        public string UserName { get; }
        public string Password { get; }

        public User(string name, string pass)
        {
            this.UserName = name;
            this.Password = pass;   
        }


        public override string ToString()
        {
            return $"{this.UserName}";
        }
    }
}
