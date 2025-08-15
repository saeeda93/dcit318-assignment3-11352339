﻿using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== Finance System Menu =====");
            Console.WriteLine("1. Question 1");
            Console.WriteLine("2. Question 2");
            Console.WriteLine("3. Question 3");
            Console.WriteLine("4. Question 4");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": Question1(); break;
                case "2": Question2(); break;
                case "3": Question3(); break;
                case "4": Question4(); break;
                case "0": return;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static void Question1()
    {
        Console.Clear();
        Console.WriteLine("=== Question 1 ===");
        Console.Write("Enter principal amount: ");
        decimal principal = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter interest rate (%): ");
        decimal rate = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter time in years: ");
        int years = Convert.ToInt32(Console.ReadLine());

        decimal interest = principal * (rate / 100) * years;
        Console.WriteLine($"Simple Interest: {interest:C}");
        Console.WriteLine("Press Enter to return to menu.");
        Console.ReadLine();
    }

    static void Question2()
    {
        Console.Clear();
        Console.WriteLine("=== Question 2 ===");
        Console.Write("Enter amount in USD: ");
        decimal usd = Convert.ToDecimal(Console.ReadLine());

        decimal exchangeRate = 12.5m; // example rate
        decimal converted = usd * exchangeRate;

        Console.WriteLine($"Equivalent in local currency: {converted:C}");
        Console.WriteLine("Press Enter to return to menu.");
        Console.ReadLine();
    }

    static void Question3()
    {
        Console.Clear();
        Console.WriteLine("=== Question 3 ===");
        Console.Write("Enter total bill amount: ");
        decimal bill = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter number of people: ");
        int people = Convert.ToInt32(Console.ReadLine());

        if (people > 0)
        {
            decimal perPerson = bill / people;
            Console.WriteLine($"Each person should pay: {perPerson:C}");
        }
        else
        {
            Console.WriteLine("Number of people must be greater than zero.");
        }

        Console.WriteLine("Press Enter to return to menu.");
        Console.ReadLine();
    }

    static void Question4()
    {
        Console.Clear();
        Console.WriteLine("=== Question 4 ===");
        Console.Write("Enter monthly salary: ");
        decimal salary = Convert.ToDecimal(Console.ReadLine());

        decimal taxRate = 0.15m;
        decimal tax = salary * taxRate;
        decimal net = salary - tax;

        Console.WriteLine($"Tax: {tax:C}");
        Console.WriteLine($"Net Salary: {net:C}");
        Console.WriteLine("Press Enter to return to menu.");
        Console.ReadLine();
    }
}
