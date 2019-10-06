using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Vetor_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            int i;

            Random r = new Random();
            Console.WriteLine("Vetor A");

            for (i = 0; i < 10; i++)
            {
                A[i] = r.Next(1, 10);
                Console.WriteLine(A[i]);
            }

            Console.ReadKey();
        }
    }
}
