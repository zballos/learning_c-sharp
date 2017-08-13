using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zballos.Exceptions;
using Zballos.Interfaces;

namespace Zballos.Objects
{
    class InvestmentAccount : Account, ITaxable
    {
        public double CalculateTribute()
        {
            return this.Balance * 0.03;
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
                    this.Balance -= (value + 0.15);
                }
                else if (value <= 200)
                {
                    this.Balance -= (value + 0.15);
                }
                else
                {
                    throw new InsufficientBalanceException();
                }
            }
        }
    }
}
