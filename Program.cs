using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Enter number A: ");
        // int numberA = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Enter number B: ");
        // int numberB = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("What is the value of" + numberA + "and" + numberB + ": ");
        // int answerInput = Convert.ToInt32(Console.ReadLine());

        // int actulaAnswer = numberA * numberB;

        // while(answerInput != actulaAnswer) 
        // {
        //     Console.WriteLine("Answer is wrong");

        //     Console.WriteLine("Enter your answer again:  ");
        //     answerInput = Convert.ToInt32(Console.ReadLine());
        // }

        // Console.WriteLine("Correct answer!");


        // bool success = true;

        // while(success)
        // {
        //     Console.WriteLine("Enter a number: ");
        //     string numInput = Console.ReadLine();

        //     if(int.TryParse(numInput, out int num))
        //     {
        //         Console.WriteLine(num);
        //         success = false;
        //     }
        //     else 
        //     {
        //         Console.WriteLine("Failed to convert the number");
        //     }
        // }

        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for(int i = 1 ; i <= number ; i++)
        {
            Console.WriteLine(i + " * " + number + " = " + i * number);
        } 

    }
}