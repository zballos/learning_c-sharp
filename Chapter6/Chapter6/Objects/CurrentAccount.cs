using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6.Objects
{
    class CurrentAccount : Account
    {
        public override void Update(double tax)
        {
            base.Update(2 * tax);
        }

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
                    this.Balance -= value;
                    return true;
                }
                else if (value <= 200)
                {
                    this.Balance -= value;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
