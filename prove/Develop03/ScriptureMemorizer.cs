using System;
using System.Collections.Generic;
using System.Linq;
public class ScriptureMemorizer
{
    private Scripture scripture;
    private List<string> hiddenWords;
    private Random random;

    public ScriptureMemorizer(Scripture scripture)
    {
        this.scripture = scripture;
        hiddenWords = new List<string>();
        random = new Random();
    }

    public void Run()
    {
        Console.WriteLine("Press enter to hide words or type 'quit' to end.");
        Console.WriteLine(scripture.Reference);
        Console.WriteLine(scripture.Text);

        while (hiddenWords.Count < CountWords(scripture.Text))
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                return;

            Console.WriteLine("Enter the number of words to hide:");
            if (int.TryParse(Console.ReadLine(), out int wordsToHide))
            {
                HideWords(wordsToHide);
                Console.Clear();
                DisplayScripture();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

    private void DisplayScripture()
    {
        string displayedText = scripture.Text;
        foreach (string word in hiddenWords)
        {
            displayedText = displayedText.Replace(word, new string('_', word.Length));
        }
        Console.WriteLine(scripture.Reference);
        Console.WriteLine(displayedText);
    }

    private void HideWords(int wordsToHide)
    {
        string[] words = scripture.Text.Split(' ');
        List<string> wordsList = words.ToList();
        for (int i = 0; i < wordsToHide; i++)
        {
            string wordToHide = wordsList[random.Next(wordsList.Count)];
            if (!hiddenWords.Contains(wordToHide))
            {
                hiddenWords.Add(wordToHide);
                wordsList.Remove(wordToHide);
            }
        }
    }

    private int CountWords(string text)
    {
        return text.Split(' ').Length;
    }
}
//What did I do to exceed requirements? Added a feature that allows users to specify the number of words they want to hide each time they press Enter, giving them more flexibility in their memorization process.