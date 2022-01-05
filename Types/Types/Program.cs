using System;

namespace Types
{
    class Program
    {
        public Program()
        {
            //String s = Console.ReadLine();
            //Console.WriteLine(s);
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(num);
            /*
            try
            {
                Console.WriteLine(int.Parse(Console.ReadLine()));
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
            */
            //Irj egy fuggvenyt, amely megcserel ket szamot
            /*
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
             Swap(ref a,ref b);
            Console.WriteLine(a + " " + b);
            Console.ReadKey();
            */
            //Egy fuggveny parametere egy egesz szam es visszaadja masik 2 parameterben\
            //a bemeno parameter szamjegyeinek osszeget es szorzatat
            /*
            int num, sum , mult ;
            num = int.Parse(Console.ReadLine());
            OsszeSzorzat(num, out sum, out mult);
            Console.WriteLine(sum+" "+mult);
            */
            ///10elemu tomb beolvas+kiir
            /*
            int [] a = new int [10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            */
            /*
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            */
            /*
            foreach(int i in a)
            {
                Console.Write(a[i] + " ");
            }
            */

            String s1 = Console.ReadLine();
            String s2 = Console.ReadLine();
            /*
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine();
            if (String.Compare(s1, s2) == -1) Console.WriteLine(s1);
            else Console.WriteLine(s2);
            */
            if (s1.IndexOf(s2) < 0) Console.WriteLine("Nincsbenne");
            else Console.WriteLine("Bennevan");
        }
        void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        void OsszeSzorzat(int a, out int sum, out int mult)
        {
            mult = 1;
            sum = 0;
            while (a > 0)
            {
                sum += a % 10;
                mult *= a % 10;
                a /= 10;
            }
        }
        static void Main(string[] args)
        {
            Program pg = new Program();


        }
    }
}
