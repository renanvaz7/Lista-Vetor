using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Vetor_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] N = new int[10];
            int[] N2 = new int[10];
            int i, a, aux, n;
            a = 1;
            float fatorial = 1;

            Console.WriteLine("Digite um valor de N");
            a = Int32.Parse(Console.ReadLine());

            for (i = 1; i < 15; i++)
            {
                N2[i] = N[i];
            }

            Console.WriteLine("Vetor N2");
            Console.WriteLine();

            for (i = 0; i <= 10; i++)
            {
                for (n = 0; n <= 9; n++)
                {
                    if (N2[n] < N2[n + 1])
                    {
                        aux = N2[n];
                        N2[n] = N2[n + 1];
                        N2[n + 1] = aux;
                    }
                }
            }

            Console.WriteLine("Vetor N");
            Console.WriteLine();

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(N[i]);
                Console.WriteLine();
            }

            Console.WriteLine("Vetor N2 ordenado");
            Console.WriteLine();

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(N2[i]);
            }
            Console.ReadKey();
        }
    }
}
