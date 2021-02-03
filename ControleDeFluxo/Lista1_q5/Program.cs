using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_q5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5) Crie um programa com o nome Lista1_q5 que tenha uma variável
            // valorDaNotaFiscal e, de acordo com esse valor, o imposto deve ser calculado. As
            //regras de cálculo são:
            // a) Se o valor for menor 999, o imposto deve ser de 2 %
            // b) Se o valor estiver entre 1000 e 2999, o imposto deve ser de 2 %
            // c) Se o valor estiver entre 3000 e 6999, o imposto deve ser de 2 %
            //d) Se for maior 7000, o imposto deve ser de 3 %

            var valorDaNotaFiscal = 7500;
            
            if (valorDaNotaFiscal < 999)
            {
                var imposto = valorDaNotaFiscal * 0.02;

                Console.WriteLine($"O imposto é de {imposto} reais e representa 2% do valor da nota fiscal");

            }
            else if (valorDaNotaFiscal >= 1000 && valorDaNotaFiscal < 3000)
            { 
                var imposto = valorDaNotaFiscal * 0.02;

                Console.WriteLine($"O imposto é de {imposto} reais e representa 2% do valor da nota fiscal");

            }
            else if (valorDaNotaFiscal >= 3000 && valorDaNotaFiscal < 7000)
            {
                var imposto = valorDaNotaFiscal * 0.02;

                Console.WriteLine($"O imposto é de {imposto} reais e representa 2% do valor da nota fiscal");

            }
            else if (valorDaNotaFiscal > 7000)
            {
                var imposto = valorDaNotaFiscal * 0.03;

                Console.WriteLine($"O imposto é de {imposto} reais e representa 3% do valor da nota fiscal");
            }
            Console.ReadKey();
        }
    }
}
