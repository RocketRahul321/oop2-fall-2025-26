Console.WriteLine("enter celcius temperatue");
double celceusius = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("enter fahrenheit temperatue");
double fahrenheit = Convert.ToDouble(Console.ReadLine());
double converted = celceusius * 9 / 5 + 32;


Console.WriteLine($" converted temperature is {converted}");