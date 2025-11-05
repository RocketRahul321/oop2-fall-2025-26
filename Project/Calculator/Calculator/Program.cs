

       int count = 0;

    string opinion;


do
        {
            Console.WriteLine("Enter first number:");

            double value1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number:");

            double value2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What do you want to do? (+, -, *, /)");

            string operation = Console.ReadLine();

           

    switch (operation)
            {
                case "+":
                    Console.WriteLine("Result: " + (value1 + value2));

                    break;

                case "-":

                    Console.WriteLine("Result: " + (value1 - value2));

                    break;

                case "*":

                    Console.WriteLine("Result: " + (value1 * value2));

                    break;
                case "/":
                    if (value2 != 0)
                        Console.WriteLine("Result: " + (value1 / value2));
                    else
                        Console.WriteLine("Error: Division by zero");
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

            count++;
            Console.WriteLine("Do you want to continue? (yes/no)");
            opinion = Console.ReadLine();


} while (opinion.ToLower() == "yes");

        Console.WriteLine("End of program. You performed " + count + " calculations.");
    





