using System;
using System.Threading;
using System.IO;

namespace RandomGenerator
{
	class Program
	{
		static void ArrayOutEach(int [] array)
		{
			foreach (int i in array)
			{
				Console.WriteLine(i);
			}
		}
		static void ArrayOutFor(int [] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i] + " ");
			}
		}
		static void Main(string[] args)
		{
			/*
			Random rn = new Random();
			int counter = 1;
			while (true)
			{
				int num = rn.Next();
				Console.WriteLine(counter +"\t" +num);
				counter++;
				Thread.Sleep(66);
			}
			Console.ReadKey();
			*/
			///10 elemu vektort tolts fel 2jegyu random szamokkal
			/*
			int[] array = new int[10];
			Random generate = new Random();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = generate.Next(10, 100);
			}
			ArrayOutEach(array);
			//ArrayOutFor(array);
			*/
			///Beolvasas szovegesFajlbol
			StreamReader f = new StreamReader("in.txt");
			StreamWriter g = new StreamWriter("out.txt");
			string s;
			while ((s = f.ReadLine()) != null)
			{
				Console.WriteLine(s);
				g.WriteLine(s);
			}
			f.Close();
			g.Close();
		}
	}
}
