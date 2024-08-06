using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_queries.task3
{
	public class Class3
	{
		public static List<string> WhereQuery(List<string> strings)
		{
			List<string> newStrings = strings.Where(x=>x.ToLower().StartsWith('a')).ToList();
			return newStrings;
		}
	}
}
