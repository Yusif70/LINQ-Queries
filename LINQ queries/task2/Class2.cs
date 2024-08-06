using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_queries.task2
{
	public class Class2
	{
		public static List<int> SquaredNumbersQuery(List<int> numbers)
		{
			List<int> squaredNumbers = numbers.Select(number => number*number).ToList();
			return squaredNumbers;
		}
	}
}
