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
        }
    }
}
