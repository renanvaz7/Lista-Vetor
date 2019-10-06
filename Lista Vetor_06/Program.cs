using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Vetor_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] N = new int[20];
            int i;

            Random r = new Random();
            Console.WriteLine("Vetor Original");
            Console.WriteLine();

            for (i = 0; i < 20; i++)
            {
                N[i] = r.Next(1, 20);
                Console.WriteLine(N[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Aperte ENTER para escrever o vetor na ordem contrária");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Vetor invertido");
            Console.WriteLine();

            for (i = 19; i >= 0; i--)
            {
                Console.WriteLine(N[i]);
            }
            Console.ReadKey();
        }
    }
}
