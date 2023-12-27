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
	public static string GetRequestType(this RefundAmendRequestType type)
	{
		switch (type)
		{
			case RefundAmendRequestType.RefundFees:
				return "Refund Fees";
			case RefundAmendRequestType.BacsRequested:
				return "Bacs";
			case RefundAmendRequestType.ChequeNotReceived:
				return "Cheque not received";
			default:
				return "Undefined";
		}
	}
}

void Main()
{	
	foreach (var item in (RefundAmendRequestType[]) Enum.GetValues(typeof(RefundAmendRequestType)))
		Console.WriteLine($"{item} => {item.GetRequestType()}");
}

