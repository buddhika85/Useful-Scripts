<Query Kind="Program" />

public enum RefundAmendRequestType
{
	Undefined = 0,
	RefundFees = 1,
	BacsRequested = 2,
	ChequeNotReceived = 3
}
public static class EnumExtensionsExample
{
	public static RefundAmendRequestType GetRequestType(string input)
	{
		if (string.IsNullOrWhiteSpace(input))
			return RefundAmendRequestType.Undefined;

		input = input.ToLower();
		switch (input)
		{
			case "refundfees":
				return RefundAmendRequestType.RefundFees;
			case "bacs":
				return RefundAmendRequestType.BacsRequested;
			case "chequenotreceived":
				return RefundAmendRequestType.ChequeNotReceived;
			default:
				return RefundAmendRequestType.Undefined;
		}
	}
}

void Main()
{
	List<string> list = new() { "a", "RefundFees", "Bacs", "ChequeNotReceived"};
	foreach (var item in list)
		Console.WriteLine($"{item} => {EnumExtensionsExample.GetRequestType(item)}");
}

