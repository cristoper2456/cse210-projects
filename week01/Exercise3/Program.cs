using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        Console.Write("What is the magic Number ");
        int guess = int.Parse(Console.ReadLine());
        Console.WriteLine(guess);

        string message = "";
        while (guess != number)
        {
            
            if (guess < number)
            {
                message = "a little higher"; 
                
                
            }
            else if (guess > number)
            {
                message = "a little lower";
                
            }
            Console.Write("guess again ");
            guess = int.Parse(Console.ReadLine());
            Console.WriteLine(guess);
            Console.WriteLine(message);
        }
    Console.WriteLine("you got it");
    
    }
}