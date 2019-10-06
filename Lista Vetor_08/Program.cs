using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Vetor_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] original = new int[100];
            int[] pares = new int[100];
            int[] impares = new int[100];
            int i;
            int x = 0;
            int y = 0;

            Random r = new Random();

            Console.WriteLine("Vetor Original");

            for (i = 0; i < 100; i++)
            {
                original[i] = r.Next(1, 100);
                Console.WriteLine(original[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Aperte enter para preencher o vetor 'pares' e 'ímpares'");
            Console.ReadKey();
            Console.WriteLine();
            Console.Clear();

            for (i = 0; i < 100; i++)
            {
                if (original[i] % 2 == 0)
                {
                    pares[x] = original[i];
                    x++;
                }
                if (original[i] % 2 == 1)
                {
                    impares[y] = original[i];
                    y++;
                }
            }
            Console.WriteLine("Vetor Pares");
            Console.WriteLine();

            for (i = 0; i < 100; i++)
            {
                Console.WriteLine(pares[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Vetor Ímpares");
            Console.WriteLine();

            for (i = 0; i < 100; i++)
            {
                Console.WriteLine(impares[i]);
            }

            Console.ReadKey();
        }
    }
}
