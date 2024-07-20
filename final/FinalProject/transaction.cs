using System;

public abstract class Transaction
{
    public int TransactionId { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }

    public abstract string GetDetails();

    public decimal GetAmount()
    {
        return Amount;
    }
}
