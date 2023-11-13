<Query Kind="Program">
  <Namespace>static System.Console</Namespace>
</Query>

using static System.Console;
private const int MillenimumTwoYears = 2000;

void Main()
{
	var yyMMs = new string[] { "23-01", "24-02", "23-03", "23-04", "23-05", "23-06", "23-07", "23-08", "23-09", "23-10", "23-11", "23-12" };

	foreach (var yyMM in yyMMs)
	{
		var startEndDates = GetStartEndDate(yyMM);
		WriteLine($"{startEndDates[0].ToShortDateString()} to {startEndDates[1].ToShortDateString()}");
	}
}


// accepts a string from yy-MM
// and returns [] of dd/mm/yyyy
// 23-01 => { 01/01/2023, 31/01/2023 }
private DateTime[]? GetStartEndDate(string yyMM)
{
	var monthAndYear = FindMonthAndYear(yyMM);
	if (monthAndYear == null)
		return null;
	
	var month = monthAndYear[0];
	var year = monthAndYear[1] + MillenimumTwoYears;
	var daysInMonth = DateTime.DaysInMonth(year, month);
	return new DateTime[]
	{
		new DateTime(year,month,1),
		new DateTime(year,month,daysInMonth)
	};
}


private int[]? FindMonthAndYear(string yyMM)
{
	if (int.TryParse(yyMM.Substring(0, 2), out var year))
	{
		if (int.TryParse(yyMM.Substring(3, 2), out var month))
		{
			return new int[] { month, year };
		}
	}

	return null;
}