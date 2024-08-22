using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
namespace Learning.App
{
    class Dictionary
    {
        public static Dictionary<string, string> myDictionary = new();
        public static bool intialize = true;

        public static int dictionaryMainFunction()
        {
            if (intialize)
            {
                Console.WriteLine("Welcome to dictionary");
                myDictionary.Add("Words", "Meaning");
                intialize = false;
            }

            Console.WriteLine("Please select an option");
            Console.WriteLine("1. View All Words.");
            Console.WriteLine("2. Add a Word.");
            Console.WriteLine("3. Search a Word.");
            Console.WriteLine("4. To quit.");


            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    String result1 = viewAllWords();
                    Console.WriteLine(result1);
                    dictionaryMainFunction();
                    break;

                case "2":
                    Console.WriteLine("please enter a word");
                    string word = Console.ReadLine();
                    Console.WriteLine("please enter the meaning of this word");
                    string meaning = Console.ReadLine();
                    String result2 = addtoDictionary(word, meaning);
                    Console.WriteLine(result2);
                    dictionaryMainFunction();
                    break;

                case "3":
                    string search = searchWord();
                    Console.WriteLine($"{search}");
                    dictionaryMainFunction();
                    break;

                case "4":
                    break;

                default:
                    Console.WriteLine("Please enter a valid input");
                    dictionaryMainFunction();
                    break;
            }
            return 0;
        }

        public static string viewAllWords()
        {
            var enumerator = myDictionary.GetEnumerator();

            var current = enumerator.Current;
            Console.WriteLine("Your words:");
            Console.WriteLine($" {current.Key}: {current.Value}");

            while (enumerator.MoveNext())
            {
                current = enumerator.Current;
                Console.WriteLine($" {current.Key}: {current.Value}");
            }

            return "All words displayed";
        }
        public static string addtoDictionary(string word, string meaning)
        {
            myDictionary.Add(word, meaning);
            return "sucessfully added";
        }

        public static string searchWord()
        {
            try
            {
                Console.WriteLine("Please enter a word for meaning");
                string word = Console.ReadLine();
                string meaning = $"Meaning: {myDictionary[word]}";
                return meaning;
            }
            catch (KeyNotFoundException)
            {
                return "the Word was not found try again";
            }
        }
    }
}