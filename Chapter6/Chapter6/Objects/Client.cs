using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Client
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        // The client must have a name and age
        public Client(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public bool IsGreaterOfAge
        {
            get
            {
                return this.Age >= 18;
            }
        }
    }
}
