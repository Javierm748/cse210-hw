using System;
using System.Collections.Generic;

public class Category
{
    public List<string> ExpenseCategories { get; private set; }
    public List<string> IncomeCategories { get; private set; }

    public Category()
    {
        ExpenseCategories = new List<string>();
        IncomeCategories = new List<string>();
    }

    public void AddCategory(string category, bool isExpense)
    {
        if (isExpense)
        {
            ExpenseCategories.Add(category);
            Console.WriteLine("Expense category added: " + category);
        }
        else
        {
            IncomeCategories.Add(category);
            Console.WriteLine("Income category added: " + category);
        }
    }

    public void RemoveCategory(string category, bool isExpense)
    {
        if (isExpense)
        {
            ExpenseCategories.Remove(category);
            Console.WriteLine("Expense category removed: " + category);
        }
        else
        {
            IncomeCategories.Remove(category);
            Console.WriteLine("Income category removed: " + category);
        }
    }

    public List<string> GetCategoryList(bool isExpense)
    {
        return isExpense ? ExpenseCategories : IncomeCategories;
    }
}
