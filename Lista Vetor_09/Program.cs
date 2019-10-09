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
            int[] A = new int[15];
            int i, aux = 1;

            Console.WriteLine("Vetor A");
            Console.WriteLine();

            for (i = 0; i < 15; i++)
            {
                if (i == 0)
                {
                    A[i] = 1;
                    Console.WriteLine("Posição " + i + " do vetor " + A[i]);
                }

                else
                {
                    aux = aux * i;
                    A[i] = aux;
                    Console.WriteLine("Posição " + i + " do vetor " + A[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
