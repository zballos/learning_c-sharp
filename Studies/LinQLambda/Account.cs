using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQLambda
{
    class Account
    {
        public double Balance { get; private set; }
        public string Titular { get; set; }
        public int Number { get; private set; }
        
        public Account(string titular, int number, double balance)
        {
            this.Titular = titular;
            this.Number = number;
            this.Balance = balance;
        }
    }
}
