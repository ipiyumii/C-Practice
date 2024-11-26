using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number A: ");
        int numberA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number B: ");
        int numberB = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What is the value of" + numberA + "and" + numberB + ": ");
        int answerInput = Convert.ToInt32(Console.ReadLine());

        int actulaAnswer = numberA * numberB;

        while(answerInput != actulaAnswer) 
        {
            Console.WriteLine("Answer is wrong");

            Console.WriteLine("Enter your answer again:  ");
            answerInput = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Correct answer!");
    }
}
