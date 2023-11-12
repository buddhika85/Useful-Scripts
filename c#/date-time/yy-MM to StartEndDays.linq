<Query Kind="Program" />

void Main()
{
	// To Do: test code
}


// accepts a string from yy-MM
// and returns [] of dd/mm/yyyy
// 23-01 => { 01/01/2023, 31/01/2023 }
private DateTime[]? GetStartDate(string yyMM)
{
	var monthAndYear = FindMonthAndYear(yyMM);
	if (monthAndYear == null)
		return null;
	
	// To DO
	return null;
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