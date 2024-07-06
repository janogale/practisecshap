using System;
using ConsoleApp1;

public class Basics

{

    public static void PrintResults()
    {


        List<Peoople> people = new()  {
                new Peoople { FirstName = "mukhtaR", LastName = "MOHAMED", Age = 30 },
                new Peoople { FirstName = "deka", LastName = "YOUSUF", Age = 30 },
                new Peoople { FirstName = "mahir", LastName = "MUKHTAR", Age = 30 }
            };


        /*foreach (var person in people)
        {
            Console.Write($"{TextProcessor.GetFullName(person.FirstName ?? "", person.LastName ?? "")}  is {person.Age} years old.");
            Console.WriteLine("");
        }*/

        // printing Enum number;
        //Console.WriteLine((int)EmployeeType.Sales);

        // Print Type Name
        Console.WriteLine(typeof(Startup));

        // foreach(var i in args)
        //     System.Console.WriteLine(i);

        // User Environment.GetCommandLineArgs to get args

        System.Console.WriteLine("---------");
        foreach (var arg in Environment.GetCommandLineArgs())
            System.Console.WriteLine(arg);


        // Run Http Request

        //await HttpAcess.Request();

        string[] numbers = { "z", "d", "x", "f", "b", "a" };
        int[] nums = [20, 9, 12, 45, 0, 21, 6, 13, 17, 10];

        // takes generic array
        foreach (var n in ConsoleApp1.Math.GetSmallestNumbers(nums, 3))
        {

            Console.WriteLine(n);
        };



        // Show system details
        ShowEnvironmentDetails();

    }

    
        static void ShowEnvironmentDetails()
        {
            // Print out the drives on this machine,
            // and other interesting details.
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("PC: {0}", Environment.MachineName);
            Console.WriteLine("Number of processors: {0}",
            Environment.ProcessorCount);
            Console.WriteLine(".NET Version: {0}",
            Environment.Version);

            //Console.Beep();

            System.Console.WriteLine("({0:C})", 100);
            Console.Title = "AppConsole";
            var balance = string.Format("Your current balance is {0:c}", 379374);
            System.Console.WriteLine(balance);

            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());

            var result = bool.TryParse("False", out bool b);
            System.Console.WriteLine(result);
            System.Console.WriteLine("I have {0:c}  dollars in my acocunt", 3000000);

        }
}








public record Peoople
{
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public int Age { get; init; }
}
