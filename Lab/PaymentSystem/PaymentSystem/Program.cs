abstract class Payment
{
       public abstract void ProcessPayment(double amount);
}
class BkashPayment : Payment
{
    //
       public override void ProcessPayment(double amount)
       {
              Console.WriteLine($"Processing Bkash payment :{amount} Taka.");
       }
}

class  Creditcardprint : Payment
{
    
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processsing credit card  payment :{amount} Taka.");
    }

}

class Program
{
    static void Main()
    {
        
        Payment p2 = new BkashPayment();
        Payment p3 = new Creditcardprint();

        p2.ProcessPayment(1555);
        p3.ProcessPayment(10000);

        //Device d = new SmartPhone();
        //d.ShowBrand();
        //d.Start();
    }
}