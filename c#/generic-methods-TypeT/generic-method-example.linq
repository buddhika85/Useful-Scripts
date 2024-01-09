<Query Kind="Program" />

using static System.Console;

void Main()
{
	var nums = new int[] {1,2,3};
	var letters = new string[] {"a", "b", "c"};
	var bools = new List<bool> {true, false, false} ;
	var customers = new List<Customer> {
		new() { Id = 1, Name = "Jack"}, new() { Id = 2, Name = "Gill"}
	};
	
	WriteLine(Concatenate(nums, ","));
	WriteLine(Concatenate(letters, " "));
	WriteLine(Concatenate(bools, " | "));
	WriteLine(Concatenate(letters, " and "));
}


public string Concatenate<T>(IEnumerable<T> items, string delimeter)
{
	return string.Join(delimeter, items);
}

public class Customer
{
	public int Id { get; set; }
	public string Name { get; set; }
	public override string ToString()
	{
		return $"{Id} - {Name}";
	}
}