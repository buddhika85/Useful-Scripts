<Query Kind="Program" />

using static System.Console;

void Main()
{
	WriteLine($"{1234:n}");
	WriteLine($"{9876:n0}");

	WriteLine($"${1234:n}");
	WriteLine($"£{9876:n0}");
}