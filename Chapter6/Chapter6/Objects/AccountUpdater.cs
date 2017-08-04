using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6.Objects
{
    class AccountUpdater
    {
        public double Tax { get; private set; }

        public AccountUpdater(double tax)
        {
            this.Tax = tax;
        }

        public void Run(Account acc)
        {
            acc.Update(this.Tax);
        }
    }
}
