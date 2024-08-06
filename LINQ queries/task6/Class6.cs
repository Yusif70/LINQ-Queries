using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_queries.task6
{
	public class Class6
	{
		public static int CountQuery(List<int> numbers)
		{
			int count = numbers.FindAll(x => x % 2 == 0).Count;
			return count;
		}
	}
}
