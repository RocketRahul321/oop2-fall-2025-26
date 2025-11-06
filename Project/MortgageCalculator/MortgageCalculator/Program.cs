
        using System.Globalization;

          Console.WriteLine("Enter three  values of loan annual ");

        Console.WriteLine("Enter value of loan (p):");

        double loan = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value of annual interest rate (r):");

        double annualInterest = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the number of payments you have paid (n):");

        int numberOfPayments = Convert.ToInt32(Console.ReadLine());

       
        double monthlyInterest = annualInterest / 12 / 100;

      
        double monthlyPayment = loan * monthlyInterest / (1 - Math.Pow(1 + monthlyInterest, -numberOfPayments));

        
        double totalPaid = monthlyPayment * numberOfPayments;

        double totalInterest = totalPaid - loan;

        
        CultureInfo culture = new CultureInfo("bn-BD");

        Console.WriteLine($"The monthly mortgage payment is: {monthlyPayment.ToString("C", culture)}");

        Console.WriteLine($"The total paid is: {totalPaid.ToString("C", culture)}");

        Console.WriteLine($"The total interest is: {totalInterest.ToString("C", culture)}");
    