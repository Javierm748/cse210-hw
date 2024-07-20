using System;
using System.Collections.Generic;

public class Report
{
    public List<Transaction> Transactions { get; set; }

    public Report()
    {
        Transactions = new List<Transaction>();
    }

    public string GenerateMonthlyReport(DateTime month)
    {
        // Generate monthly report logic
        return "Monthly report for " + month.ToString("MMMM yyyy");
    }

    public string GenerateAnnualReport(int year)
    {
        // Generate annual report logic
        return "Annual report for " + year;
    }

    public string GenerateCategoryReport(string category)
    {
        // Generate category report logic
        return "Category report for " + category;
    }
}
