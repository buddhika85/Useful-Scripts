<Query Kind="Program" />

using static System.Console;

void Main()
{
	var strs = new[] { null, "", "  ", "a", "2023/11/12", "10/26/2023" };

	foreach (var str in strs)
		TryConvertToDate(str);
}


private void TryConvertToDate(string str)
{
	WriteLine($"\nPassing {str}");
	if (DateTime.TryParse(str, out var date))
	{
		WriteLine($"Pass success => {date}");
	}
	else
	{
		WriteLine("Pass Error");
	}
}
