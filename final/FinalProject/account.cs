using System;
using System.Collections.Generic;

public class Account
{
    public int AccountId { get; set; }
    public string AccountName { get; set; }
    public List<Transaction> Transactions { get; set; }
    public decimal Balance { get; set; }

    public Account()
    {
        Transactions = new List<Transaction>();
    }

    public void AddIncome(Income income)
    {
        // Add income logic
    }

    public void AddExpense(Expense expense)
    {
        // Add expense logic
    }

    public decimal GetBalance()
    {
        // Get balance logic
        return Balance;
    }
}
