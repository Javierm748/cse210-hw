using System;

class Program
{
    static void Main(string[] args)
    {Console.Write("What is your grade percentage?");
        String answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "c";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade letter is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed! ");
        }
        else
        {
            Console.WriteLine("Better luck next time! ");
        }
    }

    }



