using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        string choice = "";

        do
        {
            Console.WriteLine("\nP - Print numbers");
            Console.WriteLine("A - Add a number");
            Console.WriteLine("M - Display mean of the number ");
            Console.WriteLine("S - Display  the smallest number");
            Console.WriteLine("L - Display  the largest number");
            Console.WriteLine("F - Find a number in the list ");
            Console.WriteLine("C - Clear the list");
            Console.WriteLine("Q - Quit");

            Console.Write("Enter your choice: ");
            choice = Console.ReadLine().ToUpper();

            switch (choice)
            {
                case "P":
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("[] - the list is empty");
                    }
                    else
                    {
                        Console.Write("[ ");
                        foreach (int num in numbers)
                        {
                            Console.Write(num + " ");
                        }
                        Console.WriteLine("]");
                    }
                    break;

                case "A":
                    Console.Write("Enter a number: ");
                    int number = int.Parse(Console.ReadLine());
                    numbers.Add(number);
                    Console.WriteLine(number + " added");
                    break;

                case "M":
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to calculate the mean - no data");
                    }
                    else
                    {
                        int sum = 0;

                        foreach (int num in numbers)
                        {
                            sum += num;
                        }

                        double mean = (double)sum / numbers.Count;
                        Console.WriteLine("The mean is " + mean);
                    }
                    break;

                case "S":
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the smallest number - list is empty");
                    }
                    else
                    {
                        int smallest = numbers[0];

                        foreach (int num in numbers)
                        {
                            if (num < smallest)
                            {
                                smallest = num;
                            }
                        }

                        Console.WriteLine("The smallest number is " + smallest);
                    }
                    break;

                case "L":
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the largest number - list is empty");
                    }
                    else
                    {
                        int largest = numbers[0];

                        foreach (int num in numbers)
                        {
                            if (num > largest)
                            {
                                largest = num;
                            }
                        }

                        Console.WriteLine("The largest number is " + largest);
                    }
                    break;

                case "Q":
                    Console.WriteLine("Goodbye");
                    break;

                default:
                    Console.WriteLine("Unknown selection, please try again");
                    break;
            }

        } while (choice != "Q");
    }
}