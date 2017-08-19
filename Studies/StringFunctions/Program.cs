using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string ms = "Avenida Afonso Pena, 1854, Centro, Campo Grande - Mato Grosso do Sul";

            string[] parts = ms.Split(',');

            foreach(string p in parts)
            {
                Debug.WriteLine(p);
            }

            string newAddress = ms.Replace("Centro", "Parque dos Poderes");
            Debug.WriteLine(newAddress);
            Debug.WriteLine(newAddress.ToUpper());
            Debug.WriteLine(newAddress.ToLower());
            Debug.WriteLine(newAddress.Substring(0, 15));
            Debug.WriteLine(newAddress.IndexOf("-"));

            string.Format("{0} {1}, what do you {2}?", "Good morning", "Jon T", "Thinking");
            // or direct
            Debug.WriteLine("{0} {1}, what do you {2}?", "Good morning", "Jon T", "Thinking");
        }
    }
}
