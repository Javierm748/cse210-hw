using System;

public class Budget
{
    public string Category { get; set; }
    public decimal BudgetAmount { get; set; }
    private decimal SpentAmount { get; set; }

    public void SetBudget(string category, decimal amount)
    {
        this.Category = category;
        this.BudgetAmount = amount;
        Console.WriteLine("Budget set: " + amount + " for " + category);
    }

    public decimal GetBudget()
    {
        return BudgetAmount;
    }

    public bool CheckBudget(string category, decimal amount)
    {
        if (this.Category == category && this.SpentAmount + amount > this.BudgetAmount)
        {
            Console.WriteLine("Budget exceeded for " + category);
            return false;
        }
        else
        {
            this.SpentAmount += amount;
            return true;
        }
    }
}
