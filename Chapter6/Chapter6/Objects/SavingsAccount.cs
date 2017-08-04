using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6.Objects
{
    class SavingsAccount : Account
    {
        public override bool Withdraw(double value)
        {
            if (value > this.Balance || value < 0)
            {
                return false;
            }
            else
            {
                if (this.Titular.IsGreaterOfAge)
                {
                    this.Balance -= (value + 0.10);
                    return true;
                }
                else if (value <= 200)
                {
                    this.Balance -= (value + 0.10);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override void Deposit(double value)
        {
            if (value > 0)
            {
                this.Balance += (value + 0.10);
            }
        }

        public override void Update(double tax)
        {
            base.Update(3 * tax);
        }
    }
}
