using System;
using System.Numerics;

namespace _10._Poke_Mon
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int N = int.Parse(Console.ReadLine());
			int M = int.Parse(Console.ReadLine());
			int Y = int.Parse(Console.ReadLine());
			int count = 0;
			double n = N; // n= 50 % от N

			while (N >= M)
			{
				N -= M;
				count++;
				if (n / 2 == N)
				{
					if (Y != 0)
					{
						N = N / Y;
					}
				}
			}
			Console.WriteLine(N);
			Console.WriteLine(count);
		}
	}
}
