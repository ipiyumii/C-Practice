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

        // Console.WriteLine("Enter a number: ");
        // int number = Convert.ToInt32(Console.ReadLine());

        // for(int i = 1 ; i <= number ; i++)
        // {
        //     // Console.WriteLine(i + " * " + number + " = " + i * number);
        //     Console.WriteLine("{0} * {1} = {2}", i, number , i * number);
        // } 

        // Console.WriteLine("Enter a number :");
        // int number = Convert.ToInt32(Console.ReadLine());

        // for(int i = 1; i <= number; i++)
        // {
        //     if(i % 3 == 0 && i % 5 == 0)
        //     {
        //         Console.WriteLine("FizzBuzz");
        //     }
        //     else if(i % 3 == 0)
        //     {
        //         Console.WriteLine("Fizz");
        //     }
        //     else if(i % 5 == 0)
        //     {
        //         Console.WriteLine("Buzz");
        //     }
        //     else
        //     {
        //         Console.WriteLine(i);
        //     }
        // }

        // Console.WriteLine("Enter Password: ");
        // string password = Console.ReadLine();

        // Console.WriteLine("Enter Conform Password: ");
        // string conform_password = Console.ReadLine();

        // if(!password.Equals(string.Empty))
        // {
        //     if(!conform_password.Equals(string.Empty))
        //     {
        //         if(password.Length >= 6 && conform_password.Length >=6)
        //         {
        //             if(password == conform_password)
        //             {
        //                 Console.WriteLine("password match");
        //             }
        //             else
        //             {
        //                 Console.WriteLine("password do not match");
        //             }
        //         }
        //         else
        //         {
        //             Console.WriteLine("password must contain more than 6 characters");
        //         }
        //     } 
        //     else
        //     {
        //         Console.WriteLine("please enter a password confirmation");
        //     } 
        // }
        // else
        // {
        //     Console.WriteLine("please enter a password");
        // }

        // List<int> even_list = new List<int>();
        // List<int> odd_list = new List<int>();

        // for(int i=0; i<20; i++)
        // {
        //     if(i%2 == 0)
        //     {
        //         even_list.Add(i);
        //     }
        //     else
        //     {
        //         odd_list.Add(i);
        //     }
        // }

        // foreach(int item in even_list)
        // {
        //     Console.Write($"{item} ");
        // }

        // foreach(int item in odd_list)
        // {
        //     Console.Write($"{item} ");
        // }


        Console.WriteLine("Enter width: ");
        int width = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter height: ");
        int height = Convert.ToInt32(Console.ReadLine());

        int result = calculate(width, height);

        Console.WriteLine($"result: {result}");

       
    }

     static int calculate(int width, int height)
        {
            return(width * height) / 2;
        }
}