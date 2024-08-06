using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_queries.task4
{
	public class Class4
	{
		public static List<string> SortQuery(List<string> strings)
		{
			List<string> sortedList = [.. strings.Order()];
			return sortedList;
		}
	}
}
