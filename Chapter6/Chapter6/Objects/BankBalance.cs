﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zballos.Objects
{
    class BankBalance
    {
        public double Total { get; private set; }

        public void SumAccount(Account account)
        {
            this.Total += account.Balance;
        }
    }
}
