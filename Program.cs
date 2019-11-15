using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var masiv = new int[100];
            var MinIndex = 0;
            masiv = Push(masiv);

            for (int x = 0; x < masiv.Length; x++)
            {
                MinIndex = x;
                for (int y = 0; y < masiv.Length; y++)
                {
                    if (masiv[MinIndex] < masiv[y])
                    {
                        MinIndex = y;
                    }
                    Swap(masiv, x, MinIndex);
                }
                
            }
            Write(masiv);
            Console.ReadKey();
        }
        static int[] Push(int[] masiv)
        {
            var random = new Random();
            for (int i = 0; i < masiv.Length; i++)
            {
                masiv[i] = random.Next(1, 100);
                if (masiv[i] < 10)
                {
                    Console.Write(" " + masiv[i] + " ");
                }
                else
                {
                    Console.Write(masiv[i] + " ");
                }
                
            }
            return masiv;
        }
        static int[] Swap(int[] masiv, int x, int MinIndex)
        {
            int t = masiv[x];
            masiv[x] = masiv[MinIndex];
            masiv[MinIndex] = t;
            return masiv;
        }
        static void Write(int[] masiv)
        {
            Console.WriteLine("\n");
            for (int v = 0; v < masiv.Length; v++)
            {
                if (masiv[v] < 10)
                {
                    Console.Write(" " + masiv[v] + " ");
                }
                else
                {
                    Console.Write(masiv[v] + " ");
                }
            }
        }
    }
}
