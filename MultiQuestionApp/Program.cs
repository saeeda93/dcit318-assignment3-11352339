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
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Question1();
                    break;
                case "0":
                    return;
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
}
