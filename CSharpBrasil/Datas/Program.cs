using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2017, 08, 20);
            Debug.WriteLine(dateTime.ToString("d"));
            Debug.WriteLine(dateTime.ToString("d", new CultureInfo("pt-BR")));
            Debug.WriteLine(dateTime.ToString("dd/MM"));
            Debug.WriteLine(dateTime.ToString("dd/MM/yy"));

            dateTime = new DateTime(2017, 08, 20, 19, 01, 56, 654);
            Debug.WriteLine(dateTime);
            Debug.WriteLine(dateTime.ToString("hh:mm"));
            Debug.WriteLine(dateTime.ToString("HH:mm"));
            Debug.WriteLine(dateTime.ToString("HH:mm:ss.fff"));

            Debug.WriteLine(dateTime.ToString("D"));
            Debug.WriteLine(dateTime.ToString("m"));
            Debug.WriteLine(dateTime.ToString("Y"));

            Debug.WriteLine(dateTime.ToString("g"));
            Debug.WriteLine(dateTime.ToString("G"));

            Debug.WriteLine(dateTime.ToString("O"));
            Debug.WriteLine(DateTime.Parse(dateTime.ToString("O")).ToString("dd/MM/yyyy HH:mm:ss.fff"));

            Debug.WriteLine(dateTime.ToString("t"));
            Debug.WriteLine(dateTime.ToString("T"));

        }
    }
}
