using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingInCSharp
{
	internal class s2_Advanced
	{

		private IEnumerable<int> numbers()
		{
			for (int i = 0; ; i++)
			{
				yield return i;
			}
		}

		private IEnumerable<int> factoriels(IEnumerable<int> col)
		{
			var result = 1;
			foreach (var item in col)
			{
				if(item > 0)
					result = item * result;

				yield return result;
			}
		}

		public int Test(int count)
		{
			var a1 = numbers();
			var n = factoriels(a1)
				.Select(x=>x*x)
				.Take(count)
				.Sum();

			return n;
		}
	}
}
