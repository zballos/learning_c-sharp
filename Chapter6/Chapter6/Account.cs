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
        public double balance;
        public int agency;
        public Client client;

        public bool toWithdraw(double value)
        {
            if (value > this.balance || value < 0)
            {
                return false;
            }
            else
            {
                if (this.client.isGreaterOfAge())
                {
                    this.balance -= value;
                    return true;
                }
                else if (value <= 200)
                {
                    this.balance -= value;
                    return true;
                }
                else
                {
                    return false;
                }
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
