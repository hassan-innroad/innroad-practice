// //TestingDump
using System;
using System.Security.Cryptography.X509Certificates;
namespace Learning.App
{
    public class TestingDump
    {
        public static int testingDumpMain()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Changed the console color");

            return 0;
        }
    }
}


// public class testingClass{
//     public int test {get; set;}
//     // public int test;
//     // public testingClass(int n){
//     //     test = n;
//     // }

//     public void Desrtruct(out int Test){
//         Test = test;
//     }

//     ~testingClass(){
//         test = 0;
//         Console.WriteLine($"the value of test at the end is, {test}");
//     }
// }

// class Program{
//     static void Main(){
//         testingClass test1 = new testingClass();
//         test1.test = 9;
//         Console.WriteLine(test1.test);
//         test1.Desrtruct(out int result);
//         Console.Write($"the result of destruct is: {result}");

//     }
// }

// // class Person (string firstName, string lastName)
// // {
// //  public string FirstName { get; set; } = firstName;
// //  public string LastName { get; set; } = lastName;
// // }
// // class Program {
// //     static void Main(){
// //          Person fahad = new Person("fahad", "asim");
// //         // Console.WriteLine($"{fahad.FirstName}");
// //         // var print = (string message="") =>{
// //         //     Console.Write(message);
// //         // };
// //         // print("hi there");


// //             string raw = @"ile\n\\ajins";

// //             Console.Write(raw);

// //     }
// // }
// /*
// public class Node{
//     public int data;
//     public Node next;
// }
// class Program{
// static void Main(){
//     Node head = null;
//     Node test = new Node();
//     test.data = 4;
//     test.next = head;
//     Console.Write($"testing what Node prints:, {test.data} ,{test.next}");
// }
// }

// */

// }

//newest dump

//GetNumbers();
// double GetNumbers()
// {
//     while (true)
//     {
//         try
//         {
//             Console.WriteLine("Enter first number");
//             newCalculation.n1 = Convert.ToDouble(Console.ReadLine());
//             Console.WriteLine("Enter second number");
//             newCalculation.n2 = Convert.ToDouble(Console.ReadLine());
//             return 0;
//         }
//         catch (System.FormatException)
//         {
//             Console.WriteLine("Please enter a valid number");
//             Console.WriteLine("Please enter the numbers again");
//         }
//     }
// };