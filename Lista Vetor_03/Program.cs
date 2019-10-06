using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Vetor_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[100];
            int i;
            int par = 0;
            int impar = 0;

            Random r = new Random();

            for (i = 0; i < 100; i++)
            {
                A[i] = r.Next(1, 100);
                Console.WriteLine(A[i]);
            }
            for (i = 0; i < 100; i++)
            {
                if (A[i] % 2 == 0)
                {
                    par++;
                }
            }
            impar = 100 - par;

            Console.WriteLine("Total de números pares: " + par);
            Console.WriteLine();

            Console.WriteLine("Total de números ímpares: " + impar);

            Console.ReadKey();
        }
    }
}
