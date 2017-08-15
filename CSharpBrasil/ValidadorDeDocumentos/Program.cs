using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caelum.Stella.CSharp.Validation;

namespace ValidadorDeDocumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf1 = "31233311109";
            string cpf2 = "22222222222";
            string cpf3 = "86288366757";

            ValidarCPF(cpf1);
            ValidarCPF(cpf2);
            ValidarCPF(cpf3);
        }

        private static void ValidarCPF(string cpf)
        {
            try
            {
                new CPFValidator().AssertValid(cpf);
                Debug.WriteLine("CPF Válido! " + cpf);
            }
            catch (Exception e)
            {
                Debug.WriteLine("CPF Inválido! " + cpf + " Erro: " + e.ToString());
            }
        }
    }
}
