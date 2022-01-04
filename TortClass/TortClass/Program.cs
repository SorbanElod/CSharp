using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortClass
{
    class Tort
    {
        private int szaml, nev;
        public Tort()
        {
            szaml = 0;
            nev = 1;
        }
        public Tort(int szaml, int nev)
        {
            this.szaml = szaml;
            this.nev = nev;
        }
        public void TortKi()
        {
            if (nev == 1) Console.Write(szaml);
            else Console.Write(szaml + "/" + nev);
        }
        static int Lnko(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b; a = b; b = r;
            }
            return a;
        }
        public void Egyszerusit()
        {
            int c = Lnko(Math.Abs(szaml), Math.Abs(nev));
            szaml /= c; nev /= c;
            if (szaml * nev < 0)
            {
                szaml = -Math.Abs(szaml); nev = Math.Abs(nev);
            }
            else
            {
                szaml = Math.Abs(szaml); nev = Math.Abs(nev);
            }

        }
        public static Tort operator +(Tort a, Tort b)
        {
            Tort c = new Tort();
            c.szaml = a.szaml * b.nev + a.nev * b.szaml;
            c.nev = a.nev * b.nev;
            c.Egyszerusit();
            return c;
        }
        public static Tort operator *(Tort a,Tort b)
        {
            Tort c = new Tort();
            c.szaml = a.szaml * b.szaml;
            c.nev = a.nev * b.nev;
            c.Egyszerusit();
            return c;
        }
        public static Tort operator /(Tort a,Tort b)
        {
            Tort c = new Tort();
            c.szaml = a.szaml * b.nev;
            c.nev = b.szaml * a.nev;
            c.Egyszerusit();
            return c;
        }
        public static Tort operator -(Tort a, Tort b)
        {
            Tort c = new Tort();
            c.szaml = a.szaml * b.nev - a.nev * b.szaml;
            c.nev = a.nev * b.nev;
            c.Egyszerusit();
            return c;
        }
        public override string ToString()
        {
            if (nev == 1) return szaml.ToString();
            else return szaml + "/" + nev;
        }
        public int getSzamlalo()
		{
            return szaml;
		}
        public void setSzamlalo(int szaml)
		{
            this.szaml = szaml;
		}
        public int Szaml
		{
			set
			{
                szaml = value;
			}
			get
			{
                return szaml;
			}
		}
        public int Nev
		{
			set
			{
                nev = value;
			}
			get
			{
                return nev;
			}
		}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tort t1 = new Tort();
            Tort t2 = new Tort();
            t1.Szaml = int.Parse(Console.ReadLine());
            t1.Nev = int.Parse(Console.ReadLine());
            t2.Szaml = int.Parse(Console.ReadLine());
            t2.Nev = int.Parse(Console.ReadLine());

            Tort t;

            t = t1 + t2;
            Console.WriteLine("{0} + {1}={2}", t1, t2, t);


            /*
            t = t1 * t2;
            Console.WriteLine("{0} * {1}={2}", t1, t2, t);
            */
      

            /*
            t = t1 / t2;
            Console.WriteLine("{0} / {1}={2}", t1, t2, t);
            */

            /*
            t = t1 - t2;
            Console.WriteLine("{0} - {1}={2}", t1, t2, t);
            */

            Console.ReadKey();
        }
    }
}
