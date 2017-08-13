using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zballos.Interfaces;

namespace Zballos.Objects
{
    class LifeInsurance : ITaxable
    {
        public double CalculateTribute()
        {
            return 42.0;
        }
    }
}
