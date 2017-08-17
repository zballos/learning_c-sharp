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

        public Account(double balance)
        {
            this.Balance = balance;
        }
    }
}
