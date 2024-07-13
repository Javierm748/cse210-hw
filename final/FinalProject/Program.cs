using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Sample interaction
        User user = new User();
        user.Register("testuser", "password123", "test@example.com");

        bool loggedIn = user.Login("testuser", "password123");
        if (loggedIn)
        {
            Console.WriteLine("User logged in successfully.");

            Account account = new Account { AccountId = 1, AccountName = "Checking Account" };
            user.Accounts.Add(account);

            Income income = new Income { TransactionId = 1, Amount = 1000, Date = DateTime.Now, Description = "Salary", Source = "Company", IncomeType = "Monthly" };
            account.AddIncome(income);

            Expense expense = new Expense { TransactionId = 2, Amount = 200, Date = DateTime.Now, Description = "Groceries", Category = "Food", ExpenseType = "Daily" };
            account.AddExpense(expense);

            Console.WriteLine("Account balance: " + account.GetBalance());

            user.Logout();
        }
        else
        {
            Console.WriteLine("Login failed.");
        }
    }
}
