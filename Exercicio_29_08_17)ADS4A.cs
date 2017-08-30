//1 - Calcular e imprimir a soma dos números naturais de 1 ao 100.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Exercicios_29_08_17_ADS4A {

    class Exercicios {

        static void Main(string[] args) {
            
        }

        //1 - Calcular e imprimir a soma dos números naturais de 1 ao 100.
        public static void ex01()
        {
            int soma = 0;
            for (int i = 0; i <= 100; i++)
            {
                soma += i;
                Console.WriteLine(soma);
            }
        }

        //2 - Imprimir os múltiplos de 7 menores que 200.
        public static void ex02()
        {
            int multiplos7 = 0;
            for (int i = 0; i <= 200; i=+7)
            {
                Console.WriteLine(multiplos7);
            }
        }

        //3 - Calcular e imprimir os números divisíveis por 4 menores que 100
        public static void ex03()
        {
            for (int i = 0; i <= 100; i++)
            {
                if ((i % 4) == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
