using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = "Diego";
            var idade = 32;

            bool MaiorDeIdade = idade > 18;

            if (MaiorDeIdade)
                Console.WriteLine(nome + " é maior de idade.");

            else
                Console.WriteLine(nome + " é menor de idade."); 
                Console.WriteLine($"Meu nome é {nome}, tenho {idade} anos de idade e sou maior de idade");


            Console.ReadKey(); 

        }
    }
}
