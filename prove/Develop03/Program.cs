using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        // Test code for the program
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        ScriptureMemorizer memorizer = new ScriptureMemorizer(scripture);
        memorizer.Run();
    }
}
