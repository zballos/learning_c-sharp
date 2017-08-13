using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zballos.Exceptions;

namespace Zballos.Objects
{
    class CurrentAccount : Account
    {
        public override void Update(double tax)
        {
            base.Update(2 * tax);
        }

        public override void Withdraw(double value)
        {
            if (value > this.Balance || value < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                if (this.Titular.IsGreaterOfAge)
                {
                    this.Balance -= value;
                }
                else if (value <= 200)
                {
                    this.Balance -= value;
                }
                else
                {
                    throw new InsufficientBalanceException();
                }
            }
        }
    }
}
