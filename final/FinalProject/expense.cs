using System;

public class Expense : Transaction
{
    public string Category { get; set; }
    public string ExpenseType { get; set; }

    public override string GetDetails()
    {
        return $"Expense: {Amount} for {Category} on {Date}. Type: {ExpenseType}.";
    }
}
