using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingInCSharp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const int count = 5;

			Console.WriteLine($"Simple		{(new s1_Simple()	).Test(count)}");
			Console.WriteLine($"Advanced	{(new s2_Advanced()	).Test(count)}");
			Console.WriteLine($"Expert		{(new s3_Expert()	).Test(count)}");
		}
	}
}
