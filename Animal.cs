using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions_SCM
{
    class Animal
    {
        public string Type { get; set; }







        public Animal(string type)
        {
            this.Type = type;
        }

        public string Describe()
        {
            return "This animal is a " + this.Type;
        }
    }
}
