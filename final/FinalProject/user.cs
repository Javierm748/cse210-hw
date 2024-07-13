using System;
using System.Collections.Generic;

public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public List<Account> Accounts { get; set; }

    public User()
    {
        Accounts = new List<Account>();
    }

    public void Register(string username, string password, string email)
    {
        // Registration logic
    }

    public bool Login(string username, string password)
    {
        // Login logic
        return true;
    }

    public void Logout()
    {
        // Logout logic
    }

    public void UpdateProfile(string username, string email)
    {
        // Update profile logic
    }
}
