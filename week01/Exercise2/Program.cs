using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello! What was your grade? " );
        int grade = int.Parse(Console.ReadLine());
        Console.WriteLine(grade);
        string letter = "";
        
        if (grade >= 90)
        {
            letter = "A";
            
        }
        
        else if (grade >= 80)
        {
            letter = "B";
            
        }
         else if (grade >= 70)
        {
            letter = "C";
            
        }
         else if (grade >= 60)
        {
            letter = "D";
            
           
        }
        else
        {
            letter = "F";
            
        }
        
        Console.WriteLine(letter);

        if (grade >= 70)
        {
        
            Console.WriteLine("congratulations, you passed :)");
        }
        else
        {
    
            Console.WriteLine("Good luck next semester :(");
        }
    }
}