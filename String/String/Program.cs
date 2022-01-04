using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadIn(out string[] x, out int n);
            DeleteAll(x, n);
            WriteOut(x, n);
        }

        private static void DeleteAll(string[] x, int n)
        {
            for (int i = 0; i < n; i++)
            {
                x[i] = DeleteVowel(x[i]);
            }
        }

        private static string DeleteVowel(string s)
        {
            string vowel = "aeiouAEIOU";
            foreach (char c in vowel)
            {
                int i;
                while ((i = s.IndexOf(c)) >= 0)
                {
                    s = s.Remove(i, 1);
                }
            }

            return s;
        }

        private static void WriteOut(string[] x, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(x[i]);
            }
            Console.ReadKey();
        }

        private static void ReadIn(out string[] x, out int n)
        {
            x = new string[20];
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                x[i] = Console.ReadLine();
            }
        }
    }
}
