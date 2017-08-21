using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caelum.Stella.CSharp.Format;
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

            string cnpj1 = "18803365000110";
            string cnpj2 = "48840854000102";

            ValidarCNPJ(cnpj1);
            ValidarCNPJ(cnpj2);

            string titulo1 = "316613671937";
            string titulo2 = "225810281902";

            ValidarTituloEleitoral(titulo1);
            ValidarTituloEleitoral(titulo2);

            string cpfFormatado = new CPFFormatter().Format(cpf1);
            Debug.WriteLine(cpfFormatado);
            Debug.WriteLine(new CPFFormatter().Unformat(cpfFormatado));

            Debug.WriteLine(new CNPJFormatter().Format(cnpj1));
            Debug.WriteLine(new CNPJFormatter().Format(cnpj2));

            Debug.WriteLine(new TituloEleitoralFormatter().Format(titulo1));
            Debug.WriteLine(new TituloEleitoralFormatter().Format(titulo2));
        }

        private static void ValidarTituloEleitoral(string titulo)
        {
            if (new TituloEleitoralValidator().IsValid(titulo))
            {
                Debug.WriteLine("Título válido: " + titulo);
            }
            else
            {
                Debug.WriteLine("Título inválido: " + titulo);
            }
        }

        private static void ValidarCNPJ(string cnpj)
        {
            if (new CNPJValidator().IsValid(cnpj))
            {
                Debug.WriteLine("CNPJ válido: " + cnpj);
            }
            else
            {
                Debug.WriteLine("CNPJ inválido: " + cnpj);
            }
        }

        private static void ValidarCPF(string cpf)
        {
            if(new CPFValidator().IsValid(cpf))
            {
                Debug.WriteLine("CPF Válido! " + cpf);
            }
            else
            {
                Debug.WriteLine("CPF Inválido! " + cpf);
            }
        }
    }
}
