using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_queries.task7
{
	public class Class7
	{
		public static string FindFirstStartingWithLetterQuery(List<string> strings, string letters)
		{
			string first = strings.First(x=>x.StartsWith(letters, StringComparison.CurrentCultureIgnoreCase));
			return first;
		}
	}
}
