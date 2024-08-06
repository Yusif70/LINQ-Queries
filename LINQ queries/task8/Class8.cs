using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_queries.task8
{
	public class Class8
	{
		public static bool GreaterThanSearchQuery(List<int> numbers, int search)
		{
			bool numberExists = numbers.Exists(x => x > search);
			return numberExists;
		}
		public static int MaxAgeQuery(List<Person> people)
		{
			int maxAge = people.Max(x => x.Age);
			return maxAge;
		}
		public static double AvgAgeQuery(List<Person> people)
		{
			double avgAge = people.Average(x => x.Age);
			return avgAge;
		}
		public static List<Person> PeopleNamesStartingWithLetters(List<Person> people, string letters)
		{
			List<Person> specificPeople = people.FindAll(person => person.Name.StartsWith(letters, StringComparison.CurrentCultureIgnoreCase));
			return specificPeople;
		}
	}
	public class Person(string name, int age)
	{
		public string Name = name;
		public int Age = age;
	}
}
