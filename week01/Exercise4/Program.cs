using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    
    {
        Console.WriteLine("Hi, welcome to the exercise number 4");
        Console.Write("Enter a list of numbers, type 0 when finished. ");
        int guess = int.Parse(Console.ReadLine());
        Console.WriteLine(guess);
        List<int> numbers = new List<int>();
        

        while (guess != 0)
        {
            numbers.Add(guess);
            Console.Write("Enter number ");
            guess = int.Parse(Console.ReadLine());
            Console.WriteLine(guess);
        }

        if (numbers.Count > 0)
        {    
            int total = 0;
            Console.WriteLine("\nYour numbers:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
                total += number;
            }
            
            double average = (double)total / numbers.Count;
            Console.WriteLine($"the average is: {average}");
            Console.WriteLine($"The sum is: {total}");
            int largest = numbers.Max();
            Console.WriteLine($"your biggest number is : {largest}");
            
        }
    }
}
