﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zballos.Interfaces;

namespace Zballos.Objects
{
    class TaxManager
    {
        public double Total { get; private set; }

        public void Accumulates(ITaxable t)
        {
            this.Total += t.CalculateTribute();
        }
    }
}
