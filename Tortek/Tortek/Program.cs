using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortek
{
    class Program
    {
        struct Tort
        {
            public int szam;
            public int nev;
        };
        static void Main(string[] args)
        {
            Tort x, y;
            TortBe(out x);
            TortBe(out y);
            TortKi(x);
            Console.WriteLine();
            TortKi(y);
            //egyszerusit
            //egyszerusit(ref x);
            //osszead

            //szorzas
            Console.ReadKey();
        }
        private static Tort osszead(Tort x, Tort y)
        {
            Tort sum;
            return sum;
        }
        private static void egyszerusit(ref Tort x)
        {
            int ln = lnko(x.szam, x.nev);
            x.szam /= ln;
            x.nev /= ln; 
        }
        private static int lnko(int a,int b)
        {
            //kivonasosmoccer
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else b = b - a;
            }
            return a;
        }

        private static void TortBe(out Tort x)
        {
            x.szam = int.Parse(Console.ReadLine());
            x.nev = int.Parse(Console.ReadLine());
        }
        private static void TortKi(Tort x)
        {
            Console.Write(x.szam + "/" + x.nev);
        }
    }
}
