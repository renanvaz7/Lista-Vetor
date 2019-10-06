using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Vetor_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[15];
            int i, j, aux = 0;

            Random r = new Random();
            Console.WriteLine("Vetor A");

            for (i = 1; i < 15; i++)
            {
                A[i] = r.Next(1, 15);
                Console.WriteLine(A[i]);
            }

            for (i = 1; i < 14; i++)
            {
                for (j = i + 1; j < 15; j++)
                {
                    if (A[i] > A[j])
                    {
                        aux = A[i];
                        A[i] = A[j];
                        A[j] = aux;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Aperte ENTER para mostrar o vetor em ordem crescente");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Vetor organizado de forma crescente");
            Console.WriteLine();

            for (i = 1; i < 15; i++)
            {
                Console.WriteLine(A[i]);
            }
            Console.ReadKey();
        }
    }
}
