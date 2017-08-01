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
        public string name;
        public double balance;
        public string cpf;
        public int agency;

        public void toWithdraw(double value)
        {
            if (value <= this.balance && value > 0)
            {
                this.balance -= value;
            }
        }

        public void toDeposit(double value)
        {
            if (value > 0)
            {
                this.balance += value;
            }
        }

        public void toTransfer(double value, Account other)
        {
            this.toWithdraw(value);
            other.toDeposit(value);
        }

        public double getAnnualIncome()
        {
            double balanceThisMonth = this.balance;

            for (int i = 1; i <= 12; i++)
            {
                balanceThisMonth = balanceThisMonth * 1.005;
            }

            double result = balanceThisMonth - this.balance;

            return result;
        }
    }
}
