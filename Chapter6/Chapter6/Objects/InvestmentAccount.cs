using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter6.Interfaces;

namespace Chapter6.Objects
{
    class InvestmentAccount : Account, ITaxable
    {
        public double CalculateTribute()
        {
            return this.Balance * 0.03;
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
                    this.Balance -= (value + 0.15);
                    return true;
                }
                else if (value <= 200)
                {
                    this.Balance -= (value + 0.15);
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
