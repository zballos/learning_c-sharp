using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caelum.Stella.CSharp.Inwords;

namespace PorExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 1992.78;
            Debug.WriteLine(new Numero(valor).Extenso());

            valor = 2961738;
            Debug.WriteLine(new Numero(valor).Extenso());

            string extensoBRL = new MoedaBRL(valor).Extenso();
            Debug.WriteLine(extensoBRL);

            valor = 36758178.93;
            extensoBRL = new MoedaBRL(valor).Extenso();
            Debug.WriteLine(extensoBRL);
            Debug.WriteLine(extensoBRL.ToUpper());

        }
    }
}
