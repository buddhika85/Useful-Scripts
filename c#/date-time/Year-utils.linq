<Query Kind="Program" />

void Main()
{
	Console.WriteLine(GetAllYearsAfter(2014));
}

public static int GetCurrentYear()
{
	return DateTime.Today.Year;
}

public static int[] GetAllYearsBefore(int goBack)
{
	return Enumerable.Range(GetCurrentYear() - goBack, goBack + 1).ToArray();
}

public static IEnumerable<int> GetAllYearsAfter(int startYear)
{
	var count = GetCurrentYear() - startYear + 1;
	return Enumerable.Range(startYear, count);
}