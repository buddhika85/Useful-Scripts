<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
</Query>

void Main()
{
	//var from2014 = GetAllYearsAfter(2014);
	//Console.WriteLine(from2014);
	//Console.WriteLine(GetAllYearsAfterWithDefault(2014));
	
	//Console.WriteLine(GetMonthNames("All"));
	//Console.WriteLine(GetTodayDateNum());
	
	Console.WriteLine(GetDatesForMonth(2023, GetMonthNumberOfYear("february")));
	Console.WriteLine(GetDatesForMonth(2024, GetMonthNumberOfYear("february")));
}

public const int MonthsCountInAnYear = 12;

public static int GetTodayDateNum()
{
	return DateTime.Today.Day;
}

public int[] GetDatesForMonth(int year, int month)
{
	return Enumerable.Range(1, DateTime.DaysInMonth(year, month)).ToArray();
}

public static int GetMonthNumberOfYear(string name)
{
	name = name.ToLower();
	return name switch
	{
		"january" => 1,
		"february" => 2,
		"march" => 3,
		"april" => 4,
		"may" => 5,
		"june" => 6,
		"july" => 7,
		"august" => 8,
		"september" => 9,
		"october" => 10,
		"november" => 11,
		"december" => 12,
		_ => throw new ArgumentException(			@"Can Only be a valid month name - January,FebruaryMarch,April,May,June,July,August,September,October,November,December")
	};
}

// fix for - some calendars, notably the Hebrew, can have 13 months
public static List<string> GetMonthNames(string allOption)
{
	var months = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList();
	if (months.Count <= MonthsCountInAnYear)
		return months;

	for (var i = 0; i < months.Count; i++)
	{
		if (string.IsNullOrWhiteSpace(months[i]))
			months.Remove(months[i]);
	}
	if (allOption != null)
		months.Insert(0, allOption);
	return months;
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