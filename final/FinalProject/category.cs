using System;
using System.Collections.Generic;

public class Category
{
    public List<string> ExpenseCategories { get; set; }
    public List<string> IncomeCategories { get; set; }

    public Category()
    {
        ExpenseCategories = new List<string>();
        IncomeCategories = new List<string>();
    }

    public void AddCategory(string category, bool isExpense)
    {
        // Add category logic
    }

    public void RemoveCategory(string category, bool isExpense)
    {
        // Remove category logic
    }

    public List<string> GetCategoryList(bool isExpense)
    {
        // Get category list logic
        return isExpense ? ExpenseCategories : IncomeCategories;
    }
}
