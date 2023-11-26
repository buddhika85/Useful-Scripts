<Query Kind="Program" />

void Main()
{
	var from2014 = GetAllYearsAfter(2014);
	Console.WriteLine(from2014);
	
	
	Console.WriteLine(GetAllYearsAfterWithDefault(2014));
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

public static List<int> GetAllYearsAfterWithDefault(int startYear, int defaultIndexZero = -1)
{
	var list = GetAllYearsAfter(startYear).ToList();
	list.Insert(0, defaultIndexZero);
	return list;
}