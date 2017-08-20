using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CEP
{
    class Program
    {
        static void Main(string[] args)
        {
            string cep = "79020200";
            string result = GetEnderecoJson(cep);

            Debug.WriteLine(result);
        }

        private static string GetEnderecoJson(string cep)
        {
            string url = "https://viacep.com.br/ws/" + cep + "/json/";

            string result = new HttpClient().GetStringAsync(url).Result;
            return result;
        }
    }
}
