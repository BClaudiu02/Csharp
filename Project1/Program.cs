using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration of numbers and operations
            int age = 23;
            Console.WriteLine(age);

            age++;
            Console.WriteLine(age);
            Console.WriteLine(++age);

            long bigNumber = 9000000L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            var negative = -55.2;
            Console.WriteLine(negative);

            string textPrecision = "35.140001";
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision);

            string textMoney = "100.54";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);

            const int vat = 20;
            int balance = 1000;

            Console.WriteLine(balance * (vat / 100D));

            // Declaration of text and characters
            string name = "John Doe";
            Console.Write("Your name is: ");
            name += " and you are a student.";
            Console.Write(name);
            Console.WriteLine();

            char letter = 'A';
            Console.WriteLine(letter);

            // Declaration of boolean values
            bool value = true;
            Console.WriteLine(value);

            value = false;
            Console.WriteLine(value);

            // Exercise: Modulo operation
            int a = 8;
            int b = 5;
            var c = a % b;
            Console.WriteLine(c);


            //ConsoleIO
            Console.Write("Enter your name: ");
            string nume = Console.ReadLine() ?? "";

            Console.Write("Enter your age: ");
            string varstaInput = Console.ReadLine() ?? "0";
            int varsta = Convert.ToInt32(varstaInput);

            Console.WriteLine();
            Console.WriteLine("Your name is " + nume + " and you are " + varsta + " years old.");


            //If statements
            if (varsta < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else if (varsta >= 18 && varsta < 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior.");
            }


            //Exercise: If statements
            // Console.Write("Enter the first number: ");
            // string firstNumberInput = Console.ReadLine() ?? "0";
            // int firstNumber = Convert.ToInt32(firstNumberInput);

            // Console.Write("Enter the second number: ");
            // string secondNumberInput = Console.ReadLine() ?? "0";   
            // int secondNumber = Convert.ToInt32(secondNumberInput);

            // int answer = firstNumber * secondNumber;

            // Console.WriteLine("Value of " + firstNumber + " * " + secondNumber + " is: ");
            // string answerInput = Console.ReadLine() ?? "0";
            // int userAnswer = Convert.ToInt32(answerInput);

            // if (userAnswer == answer)
            // {
            //     Console.WriteLine("Correct!");
            // }
            // else
            // {
            //     Console.WriteLine("Incorrect! The correct answer is: " + answer);
            // }


            //Switch statements
            Console.Write("Enter a number for a day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine() ?? "0");

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
                    break;
            }


            //For loops
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Hello, I am a for loop and this is iteration number " + i);
            }


            //While loops
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine("Hello, I am a while loop and this is iteration number " + j);
                j++;
            }

            Console.Write("Enter the first number: ");
            string firstNumberInput = Console.ReadLine() ?? "0";
            int firstNumber = Convert.ToInt32(firstNumberInput);

            Console.Write("Enter the second number: ");
            string secondNumberInput = Console.ReadLine() ?? "0";   
            int secondNumber = Convert.ToInt32(secondNumberInput);

            int answer = firstNumber * secondNumber;
            int userAnswer = 0;

            Console.WriteLine("What is the value of " + firstNumber + " * " + secondNumber + "?");
            Console.WriteLine();

            while (answer != userAnswer)
            {
            string answerInput = Console.ReadLine() ?? "0";
            userAnswer = Convert.ToInt32(answerInput);

            if (userAnswer == answer)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect! Try again!");
            }
            }

           
            Console.ReadLine();
            
        }
    }
}