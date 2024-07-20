using System;
using System.Collections.Generic;

public class Account
{
    public int AccountId { get; set; }
    public string AccountName { get; set; }
    private List<Transaction> Transactions { get; set; }
    private decimal Balance { get; set; }

    public Account()
    {
        Transactions = new List<Transaction>();
    }

    public void AddIncome(Income income)
    {
        Transactions.Add(income);
        Balance += income.Amount;
        Console.WriteLine("Income added: " + income.Amount);
    }

    public void AddExpense(Expense expense)
    {
        Transactions.Add(expense);
        Balance -= expense.Amount;
        Console.WriteLine("Expense added: " + expense.Amount);
    }

    public decimal GetBalance()
    {
        return Balance;
    }
}
