using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    abstract class Account
    {
        public int Number { get; set; }
        public double Balance { get; protected set; }
        public int Agency { get; set; }
        public Client Titular { get; set; }

        public abstract void Withdraw(double value);

        public virtual void Deposit(double value)
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

        public virtual void Update(double tax)
        {
            this.Balance += this.Balance * tax;
        }
    }
}
