using LINQ_queries.task1;
using LINQ_queries.task2;
using LINQ_queries.task3;
using LINQ_queries.task4;
using LINQ_queries.task5;
using LINQ_queries.task6;
using LINQ_queries.task7;
using LINQ_queries.task8;

List<int> numbers = [1, 3, 5, 7, 6, 9];
#region even numbers

List<int> evenNumbers = Class1.EvenNumbersQuery(numbers);

numbers.ForEach(x => Console.Write(x + " "));
Console.WriteLine("\n------------------");
evenNumbers.ForEach(x => Console.Write(x + " "));

#endregion

#region squares of numbers

List<int> squares = Class2.SquaredNumbersQuery(numbers);

numbers.ForEach(x => Console.Write(x + " "));
Console.WriteLine("\n------------------");
squares.ForEach(x => Console.Write(x + " "));

#endregion

List<string> words = ["abc", "xyz", "def"];
#region strings starting with 'a'

words.ForEach(x => Console.WriteLine(x));

List<string> stringsStartingWithA = Class3.WhereQuery(words);

Console.WriteLine("------------------");
stringsStartingWithA.ForEach(x => Console.WriteLine(x));

#endregion

#region sort strings

List<string> sorted = Class4.SortQuery(words);

words.ForEach(x => Console.WriteLine(x));
Console.WriteLine("------------------");
sorted.ForEach(x => Console.WriteLine(x));

#endregion

#region sort in ascending order

List<int> sortedInAscending = Class5.SortInAscendingQuery(numbers);

numbers.ForEach(x => Console.WriteLine(x));
Console.WriteLine("------------------");
sortedInAscending.ForEach(x => Console.WriteLine(x));

#endregion

#region count of even numbers

int count = Class6.CountQuery(numbers);

numbers.ForEach(x => Console.WriteLine(x));
Console.WriteLine("------------------");
Console.WriteLine($"count of even numbers: {count}");

#endregion

#region find first starting with 'b'

string letters = "b";
words.ForEach(x => Console.WriteLine(x));

string first = Class7.FindFirstStartingWithLetterQuery(words, letters);

Console.WriteLine("------------------");
Console.WriteLine($"first element that starts with {letters}: {first}");

#endregion

#region checking for existence

#region greater than number

int search = 20;
bool numberExists = Class8.GreaterThanSearchQuery(numbers, search);

numbers.ForEach(x => Console.WriteLine(x));
Console.WriteLine("------------------");
Console.WriteLine($"number greater than {search} {(numberExists ? "exists" : "doesn't exist")}");

#endregion

List<Person> people = [
	new Person("Yusif",20),
	new Person("Azima",21),
	new Person("Nijat",22),
	];
#region max age

int maxAge = Class8.MaxAgeQuery(people);

Console.WriteLine(maxAge);
#endregion

#region average age

double avgAge = Class8.AvgAgeQuery(people);
Console.WriteLine(avgAge);

#endregion

#region people names starting with letter

letters = "y";
List<Person> specificPeople = Class8.PeopleNamesStartingWithLetters(people, letters);

people.ForEach(x => Console.WriteLine($"{x.Name} {x.Age}"));
Console.WriteLine("------------------");
Console.WriteLine($"people whose names start with {letters}");
specificPeople.ForEach(x => Console.WriteLine($"{x.Name} {x.Age}"));

#endregion

#endregion
