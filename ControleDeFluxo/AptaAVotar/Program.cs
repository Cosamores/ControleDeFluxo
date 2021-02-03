using System;

namespace AptaAVotar
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 19;
            bool brasileira = false;
            if (idade >= 16)
                if (brasileira)
                {
                    Console.WriteLine("Você está apta a votar.");
                }
                else
                {
                    Console.WriteLine("Você não está apta a votar.");

                }
            Console.ReadKey();
        }
           
    }

}
