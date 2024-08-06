using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_queries.task5
{
	public class Class5
	{
		public static List<int> SortInAscendingQuery(List<int> numbers)
		{
			List<int> sortedInAscending = [.. numbers.Order()];
			return sortedInAscending;
		}
	}
}
