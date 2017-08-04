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
            base.Update(2 * tax);
        }
    }
}
