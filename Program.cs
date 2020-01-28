using System;
using System.Collections.Generic;
using System.Linq;

namespace Sortering_LUAY
{
    class Program
    {
        static void Main()
        {
            int i = Convert.ToInt32(Console.ReadLine());
            int[] Sortering = new int[i] ;
            Random rnd = new Random();

            for (int f = 0; f < Sortering.Length; f++)
            {
                Sortering[f] = rnd.Next(Sortering.Length);
            }
            DateTime starttid = DateTime.Now;
            BubbelSortera(Sortering);
            TimeSpan Tid = DateTime.Now - starttid;
            Console.WriteLine("Tid: " + Tid);


        }

        public static void BubbelSortera (int[] lista)
        {
            for (int m = lista.Length-1; m > 0; m--)
            {
                for (int n = 0; n < m; n++)
                {
                    if (lista[n] > lista[n + 1])
                    {
                        int temp = lista[n];
                        lista[n] = lista[n + 1];
                        lista[n + 1] = temp;
                        
                    }
                }
            }
        }
    }

 
}
