using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

        static void DisplayWelcome ()
            {
            
                Console.WriteLine("Welcome to the Program!");
            }

        static string PromptUserName ()
            {
                Console.Write("What is your name? ");
                string name = Console.ReadLine();
                Console.WriteLine($"your name is: {name}");
                return(name);
            }

        static int PromptUserNumber ()

            {
                Console.Write("What is your favorite number ");
                int number = int.Parse(Console.ReadLine());
                
                return(number);
            }

        static int SquareNumber (int number)
            {
                int resultado = number * number;
                
                return resultado;
            }

        static void DisplayResult (string name, int square)

            {
               Console.WriteLine($"{name}, the square of your number is {square}");
            }


   
}