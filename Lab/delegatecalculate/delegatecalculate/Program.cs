
//using System.ComponentModel;

//Write a C# program using delegates that performs the following tasks:
//Declare a delegate that can reference a method which:
//Takes two integers as parameters
//Returns an integer
//Create two methods:
//One method adds two numbers
//Another method subtracts two numbers
//Create a method named Calculate that:
//Accepts two integers and a delegate as parameters
//Calls the delegate inside the method
//From the Main() method:
//Call Calculate() using both add and subtract methods
//Display the result on the console

//additional task : add user input for numbers and operation choice
//multiply and divide methods can be added as well


using System;

namespace delegatecalculate
{
    public delegate int Operation(int a, int b);

    public class Program
    {
        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Divide(int x, int y)
        {
           
            return x / y;
        }

        static int Calculate(int a, int b, Operation op)
        {
            return op(a, b);
        }

        static void Main(string[] args)
        {
            int a, b;
            string operation;

            Console.Write("Enter first integer: ");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("Invalid input. Enter a valid integer: ");
            }

            Console.Write("Enter second integer: ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Invalid input. Enter a valid integer: ");
            }

            Console.Write("Enter operation (add, sub, mult, div): ");
            operation = Console.ReadLine().ToLower();

            int result;

            switch (operation)
            {
                case "add":

                    result = Calculate(a, b, Add);

                    Console.WriteLine($"Addition is: {result}");

                    break;

                case "sub":

                    result = Calculate(a, b, Subtract);

                    Console.WriteLine($"Subtraction is: {result}");

                    break;

                case "mult":

                    result = Calculate(a, b, Multiply);

                    Console.WriteLine($"Multiplication is: {result}");

                    break;

                case "div":
                    result = Calculate(a, b, Divide);

                    Console.WriteLine($"Division is: {result}");

                    break;

                default:


                    Console.WriteLine("Invalid operation. Use: add, sub, mult, div");

                    break;
            }
        }
    }
}
