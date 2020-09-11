using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programozasi_tetelek
{
    class Program
    {
        static int[] tomb = new int[] { 12, 7, 2, 4, 45, 99, 1, 8, 95, 50 };
        static void Main(string[] args)
        {
            TombKiiras();
            Osszegzes();

            Console.ReadKey();
        }

        private static void Osszegzes()
        {
            int szum = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                szum = szum+tomb[i];
            }
            Console.WriteLine("Tömb elemeinek az összege: {0}",szum);
        }

        private static void TombKiiras()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0}, ", tomb[i]);
            } 
        }
    }
}
