using System;

public class Expense : Transaction
{
    public string Category { get; set; }
    public string ExpenseType { get; set; }

    public override string GetDetails()
    {
        // Get expense details logic
        return "";
    }

    public string GetExpenseType()
    {
        // Get expense type logic
        return ExpenseType;
    }
}
