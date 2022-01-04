using System;
using System.IO;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            StreamReader f = new StreamReader("be1.txt");
            string str = f.ReadLine();
            string[] szamok = str.Split(' ');
            ParseIt(szamok);
            */
            StreamReader f = new StreamReader("be2.txt");
            GetMatrixFromFile(f);
            
        }

        private static void GetMatrixFromFile(StreamReader f)
        {
            int n, m;
            string str = f.ReadLine();
            string[] szamok = str.Split(' ');
            n = int.Parse(szamok[0]);
            m = int.Parse(szamok[1]);
            int[,] matrix = new int[20, 20];
            int[] v = new int[m + 1];
            for (int i = 0; i < n; i++)
            {
                str = f.ReadLine();
                szamok = str.Split(' ');
                ParseIt(szamok, out v);
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = v[j];
                }
            }
            YeetTheMatrix(n, m, matrix);
        }

        private static void YeetTheMatrix(int n, int m, int[,] matrix)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static void ParseIt(string[] szamok,out int[] v)
        {
            v = new int[szamok.Length];
            int n = 0;
            foreach (string s in szamok)
            {
                v[n++] = int.Parse(s);
            }
        }

        private static void ParseIt(string[] szamok)
        {
            int[] v = new int[szamok.Length];
            int n = 0;
            foreach (string s in szamok)
            {
                v[n++] = int.Parse(s);
            }
            VektorOut(v);
        }

        private static void VektorOut(int[] v)
        {
            foreach (int i in v)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
