using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter6.Interfaces;

namespace Chapter6.Objects
{
    class TotalOfTaxes
    {
        public double Total { get; private set; }

        public void Accumulates(ITaxable t)
        {
            this.Total += t.CalculateTribute();
        }
    }
}
