// Created by: Youngwook
// Created on: NOV 2022
//
// This function gets user number and do proper calculation

using System;

class Program
{
    public static void Main(string[] args)
    {
        // input
        int first;
        int second;

        Console.WriteLine("This program gets user number to answer properly.");
        Console.WriteLine("n = x / y\n");

        Console.Write("Enter first number : "); first = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number : "); second = Convert.ToInt32(Console.ReadLine());

        int count = 0;
        int answer = first;

        // output
        while (answer >= second)
        {
            answer = answer - second;
            count = count + 1;
        }

        Console.WriteLine("\nThe answer is : " + count + " R " + answer);
        Console.WriteLine("\ndone.");
    }
}
