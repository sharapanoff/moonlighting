using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingInCSharp
{
	internal class s1_Simple
	{
		private IEnumerable<int> factoriels()
		{
			var result = 1;
			for(var i=0;;i++)
			{
				if(i > 0)
					result *= i;

				yield return result;
			}
		}

		private IEnumerable<int> square(IEnumerable<int> col)
		{
			foreach (var item in col)
			{
				yield return item * item;
			}
		}
		
		public int Test(int count)
		{
			var a1 = factoriels();
			var n = square(a1)
				.Take(count)
				.Sum();

			return n;
		}

	}
}
