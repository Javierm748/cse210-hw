using System;

public class Transaction
{
    public int TransactionId { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }

    public virtual string GetDetails()
    {
        // Get details logic
        return "";
    }

    public decimal GetAmount()
    {
        // Get amount logic
        return Amount;
    }
}
