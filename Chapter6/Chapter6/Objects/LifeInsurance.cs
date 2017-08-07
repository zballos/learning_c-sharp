using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter6.Interfaces;

namespace Chapter6.Objects
{
    class LifeInsurance : ITaxable
    {
        public double CalculateTribute()
        {
            return 42.0;
        }
    }
}
