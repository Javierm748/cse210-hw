using System;
using System.Collections.Generic;

public class User
{
    public string Username { get; set; }
    private string Password { get; set; }
    public string Email { get; set; }
    public List<Account> Accounts { get; private set; }

    public User()
    {
        Accounts = new List<Account>();
    }

    public void Register(string username, string password, string email)
    {
        this.Username = username;
        this.Password = password;
        this.Email = email;
        Console.WriteLine("User registered successfully.");
    }

    public bool Login(string username, string password)
    {
        if (this.Username == username && this.Password == password)
        {
            Console.WriteLine("Login successful.");
            return true;
        }
        else
        {
            Console.WriteLine("Invalid username or password.");
            return false;
        }
    }

    public void Logout()
    {
        Console.WriteLine("User logged out.");
    }

    public void UpdateProfile(string username, string email)
    {
        this.Username = username;
        this.Email = email;
        Console.WriteLine("Profile updated successfully.");
    }
}
