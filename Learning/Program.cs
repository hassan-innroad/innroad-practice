using System;
using Learning.App;
class Program
{
    static void Main()
    {
        Console.WriteLine("choose a program to run...");
        Console.WriteLine("Option 1: Arithmetic Calculator.");
        Console.WriteLine("Option 2: Run the test dump file.");
        Console.WriteLine("Option 3: Run the Dictionary.");

        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Calculate.CalculateFunction();
                break;
            case "2":
                TestingDump.testingDumpMain();
                break;
            case "3":
                Dictionary.dictionaryMainFunction();
                break;
            default:
                Console.WriteLine("Invalid option. Please choose a valid option.");
                break;
        }

    }
};
