using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Account
    {
        public int number;
        public double Balance { get; private set; }
        public int agency;
        public Client Titular { get; set; }

        public bool Withdraw(double value)
        {
            if (value > this.Balance || value < 0)
            {
                return false;
            }
            else
            {
                if (this.Titular.isGreaterOfAge())
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

        public void Deposit(double value)
        {
            if (value > 0)
            {
                this.Balance += value;
            }
        }

        public void Transfer(double value, Account other)
        {
            this.Withdraw(value);
            other.Deposit(value);
        }

        public double AnnualIncome()
        {
            double balanceThisMonth = this.Balance;

            for (int i = 1; i <= 12; i++)
            {
                balanceThisMonth = balanceThisMonth * 1.005;
            }

            double result = balanceThisMonth - this.Balance;

            return result;
        }
    }
}
