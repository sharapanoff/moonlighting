using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingInCSharp
{
	internal class s3_Expert
	{

		private IEnumerable<int> numbers()
		{
			for (int i = 0; ; i++)
			{
				yield return i;
			}
		}

		private Func<int,int> factoriel()
		{ 
			var result = 1;
			var r = new Func<int,int>(
				x => 
					x>0
						? result*=x
						: 1);

			return r;
		}

		public int Test(int count)
		{
			var f = factoriel();

			var n = numbers()
				.Select(x=>f(x))
				.Select(x=>x*x)
				.Take(count)
				.Sum();

			return n;
		}
	}
}
