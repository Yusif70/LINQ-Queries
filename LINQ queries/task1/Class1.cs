using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_queries.task1
{
	public class Class1
	{
		public static List<int> EvenNumbersQuery(List<int> numbers)
		{
			List<int> evenNumbers = numbers.FindAll(number => number % 2 == 0);
			return evenNumbers;
		}
	}
}
