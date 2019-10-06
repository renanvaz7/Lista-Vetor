using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Vetor_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            int[] B = new int[10];
            int[] Soma = new int[20];
            int i;

            Random r = new Random();

            Console.WriteLine("Vetor 1:");
            Console.WriteLine();

            for (i = 0; i < 10; i++)
            {
                A[i] = r.Next(1, 10);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Vetor 2:");
            Console.WriteLine();

            for (i = 0; i < 10; i++)
            {
                B[i] = r.Next(1, 10);
                Console.WriteLine(B[i]);
            }
            Console.WriteLine("Aperte ENTER para somar os vetores");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("A soma dos vetores A+B é:");
            Console.WriteLine();

            for (i = 0; i < 10; i++)
            {
                Soma[i] = A[i] + B[i];

                Console.WriteLine(Soma[i]);
            }

            Console.ReadKey();
        }
    }
}
