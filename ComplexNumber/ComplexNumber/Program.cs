using System;

namespace ComplexNumber
{
	class Complex
	{
		private double valos;
		private double kepzetes;
		public Complex(double valos, double kepzetes)
		{
			this.valos = valos;
			this.kepzetes = kepzetes;

		}
		public Complex()
		{
			valos = 0;
			kepzetes = 0;
		}
		public override string ToString()
		{
			return valos.ToString()+" + "+kepzetes.ToString()+"i";
		}
		public static Complex operator +(Complex k1,Complex k2)
		{
			Complex k = new Complex();
			k.valos = k1.valos + k2.valos;
			k.kepzetes = k1.kepzetes + k2.kepzetes;
			return k;
		}
		public static Complex operator *(Complex k1,Complex k2)
		{
			Complex k = new Complex();
			k.valos = k1.valos * k2.valos - k1.kepzetes * k2.kepzetes;
			k.kepzetes = k1.valos * k2.kepzetes + k2.valos * k2.kepzetes;
			return k;
		}
		public static Complex operator -(Complex k1, Complex k2)
		{
			Complex k = new Complex();
			k.valos = k1.valos - k2.valos;
			k.kepzetes = k1.kepzetes - k2.kepzetes;
			return k;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Complex k1 = new Complex(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
			Complex k2 = new Complex(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
			Console.WriteLine(k1);
			Console.WriteLine(k2);
			Complex k = new Complex();
			/*
			k = k1 + k2;
			Console.WriteLine(k1+" + "+k2+" = "+k);
			*/
			/*
			k = k1 * k2;
			Console.WriteLine(k1 + " * " + k2 + " = " + k);
			*/
			Console.ReadKey();
		}
	}
}
