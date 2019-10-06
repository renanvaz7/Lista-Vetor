using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Vetor_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] N = new int[80];
            int i;
            int maior = 0;
            int menor = 0;
            int Pmenor = 0;
            int Pmaior = 0;

            Random r = new Random();

            for (i = 0; i < 80; i++)
            {
                Console.WriteLine();
                Console.WriteLine((i + 1) + "º número:");

                N[i] = r.Next(1, 80);
                Console.WriteLine(N[i]);

                if (i == 0)
                {
                    menor = N[0];
                    maior = N[0];
                }
                if (N[i] < menor)
                {
                    menor = N[i];
                    Pmenor = i;
                }
                else if (N[i] > maior)
                {
                    maior = N[i];
                    Pmaior = i;
                }
            }

            Console.WriteLine("O menor número é: " + maior + " e sua posição é:" + (Pmaior + 1));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
