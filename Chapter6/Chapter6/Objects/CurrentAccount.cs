using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6.Objects
{
    class CurrentAccount : Account
    {
        public override void Update(double tax)
        {
            this.Balance += this.Balance * 2 * tax;
        }
    }
}
