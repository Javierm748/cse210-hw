using System;

public class Income : Transaction
{
    public string Source { get; set; }
    public string IncomeType { get; set; }

    public override string GetDetails()
    {
        // Get income details logic
        return "";
    }

    public string GetIncomeType()
    {
        // Get income type logic
        return IncomeType;
    }
}
