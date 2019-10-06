using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Vetor_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[100];
            int i;

            Random r = new Random();

            Console.WriteLine("Vetor Original");
            Console.WriteLine();

            for (i = 0; i < 100; i++)
            {
                A[i] = r.Next(1, 100);
                Console.WriteLine(A[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Aperte ENTER para escrever o vetor na ordem contrária");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Vetor invertido");
            Console.WriteLine();

            for (i = 99; i >= 0; i--)
            {
                Console.WriteLine(A[i]);
            }
            Console.ReadKey();
        }
    }
}
