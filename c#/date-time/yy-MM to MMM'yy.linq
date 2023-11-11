<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
</Query>

using static System.Console;

void Main()
{
	var yyMMs = new string[] {"23-01", "23-02", "23-03", "23-04", "23-05", "23-06", "23-07", "23-08", "23-09", "23-10", "23-11", "23-12"};

	foreach (var yyMM in yyMMs)
	{
		WriteLine($"{GetMonthStrWithYear(yyMM)}");
	}
}

// accepts a string from yy-MM
// and returns MMM'yy
// 23-01 => January' 23
private string GetMonthStrWithYear(string yyMM)
{
	var monthAndYear = FindMonthAndYear(yyMM);
	if (monthAndYear == null)
		return null;
	return $"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthAndYear[0])}' {monthAndYear[1]}";
}

private int[] FindMonthAndYear(string yyMM)
{
	if(int.TryParse(yyMM.Substring(0,2), out var year))
	{
		if (int.TryParse(yyMM.Substring(3, 2), out var month))
		{
			return new int[] {month, year};
		}
	}
	
	return null;
}