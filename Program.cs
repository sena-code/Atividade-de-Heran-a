using System;

namespace Atividade_6
{
    class Program
    {
        static void Main(string[] args)
        {
            CNPJ vini = new CNPJ();

            vini.name = "Vinicius";
            Console.WriteLine(vini.Greeting());
            Console.WriteLine(vini.ValidateCNPJ());
        }
    }
}
