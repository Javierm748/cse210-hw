using System;

public class Budget
{
    public string Category { get; set; }
    public decimal BudgetAmount { get; set; }
    public decimal SpentAmount { get; set; }

    public void SetBudget(string category, decimal amount)
    {
        // Set budget logic
    }

    public decimal GetBudget()
    {
        // Get budget logic
        return BudgetAmount;
    }

    public bool CheckBudget(string category, decimal amount)
    {
        // Check budget logic
        return true;
    }
}
