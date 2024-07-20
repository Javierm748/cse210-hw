using System;

public class Income : Transaction
{
    public string Source { get; set; }
    public string IncomeType { get; set; }

    public override string GetDetails()
    {
        return $"Income: {Amount} from {Source} on {Date}. Type: {IncomeType}.";
    }
}
