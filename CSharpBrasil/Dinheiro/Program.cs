using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caelum.Stella.CSharp.Vault;

namespace Dinheiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money = 250.67;
            Debug.WriteLine(money);

            double value1 = 450.00;
            double value2 = 599.98;
            Money total = value1 + value2;
            Debug.WriteLine(total);

            Money difference = value2 - value1;
            Debug.WriteLine(difference);

            Money euro = new Money(Currency.EUR, 10000);
            Debug.WriteLine(euro);

            Money dolar = new Money(Currency.USD, 45200);
            Debug.WriteLine(dolar);

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Debug.WriteLine(dolar);

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

        }
    }
}
