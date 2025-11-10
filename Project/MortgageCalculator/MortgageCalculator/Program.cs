using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo bdCulture = new CultureInfo("bn-BD");

        double salary = 0;
        bool criminalRecord = false;
        int creditScore = 0;

        // salary 
        while (true)
        {
            Console.Write("Please enter the Monthly salary: ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();

            if (double.TryParse(input, out salary))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a numerical value.");
            }
        }

        // CreditScore 
        while (true)
        {
            Console.Write("Please enter the Credit score (0-500): ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();

            if (int.TryParse(input, out creditScore))
            {
                if (creditScore >= 0 && creditScore <= 500)
                    break;
                else
                    Console.WriteLine("Credit score must be between 0 and 500.");
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a numerical value.");
            }
        }

        //Criminalrecord 
        while (true)
        {
            Console.Write("Do you have a criminal record? (true/false): ");
            string input = (Console.ReadLine() ?? string.Empty).Trim().ToLower();

            if (input == "true")
            {
                Console.WriteLine("Sorry, you are not eligible for a loan due to criminal record.");
                return;
            }
            else if (input == "false")
            {
                criminalRecord = false;
                break;
            }
            else
            {
                Console.WriteLine("Invalid input, please enter 'true' or 'false'.");
            }
        }

        //Desiredloanamount 
        double loanAmount;
        while (true)
        {
            Console.Write("Enter your desired loan amount: ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();

            if (double.TryParse(input, out loanAmount))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a numerical value.");
            }
        }

        // Annualinterestrate
        double annualRate;
        while (true)
        {
            Console.Write("Enter annual interest rate (in %): ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();

            if (double.TryParse(input, out annualRate))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a numerical value.");
            }
        }

        //Loan period in years
        int years;
        while (true)
        {
            Console.Write("Enter loan period in years: ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();

            if (int.TryParse(input, out years))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a numerical value.");
            }
        }

        //Calculation

        double monthlyRate = annualRate / 100 / 12;

        int months = years * 12;

        double monthlyPayment = (loanAmount * monthlyRate * Math.Pow(1 + monthlyRate, months)) /
                                (Math.Pow(1 + monthlyRate, months) - 1);

        double totalPaid = monthlyPayment * months;

        double totalInterest = totalPaid - loanAmount;

        //Output
        Console.WriteLine("\nMortgage Calculator (Bangladesh)");

        Console.WriteLine($"Monthly Payment: {monthlyPayment.ToString("C", bdCulture)}");

        Console.WriteLine($"Total Paid: {totalPaid.ToString("C", bdCulture)}");

        Console.WriteLine($"Total Interest: {totalInterest.ToString("C", bdCulture)}");
    }
}
