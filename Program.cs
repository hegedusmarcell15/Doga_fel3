using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga_fel3
{
    internal class Program
    {
        public static int[] szam = new int[7];
        public static void homerseklet()
        {
            for (int i = 0; i < szam.Length; i++) 
            {
                Console.WriteLine("Adja meg az egész hét hőmérsékleteit: ", szam);
                szam[i] = Convert.ToInt32(Console.ReadLine());
            }
            int osszeg = 0;
            int legmelegebb = szam.Max();
            int leghidegebb = szam.Min();
            bool fagypontalatti = false;

            for (int i = 0;i < szam.Length;i++) 
            {
                osszeg += szam[i];
                if (szam[i] < 0)
                {fagypontalatti = true;}
            }

            int atlaghomerseklet = osszeg / 7;
                        if (fagypontalatti == true)
            {
                Console.WriteLine("Fagypont alatti nap is volt!");
            }
            Console.WriteLine("Az átlagkőmérséklet:{0}", atlaghomerseklet);
            Console.WriteLine("A legmagasabb hőmérséklet:{0}", legmelegebb);
            Console.WriteLine("A legalacsonyabb hőmérséklet:{0}", leghidegebb);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            homerseklet();
        }
    }
}
