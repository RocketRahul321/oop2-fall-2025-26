using System;
public abstract class Member
{
    protected string Name;
    protected int memberId;

    public Member(string name, int memberId)
    {
        this.Name = name;
        this.memberId = memberId;
    }

    public abstract double CalculateFees();
}
public class Student : Member
{
    public Student(string name, int memberId) : base(name, memberId) { }

    public override double CalculateFees()
    {
        return 300;
    }
}

public class Ragular : Member
{
    public Ragular(string name, int memberId) : base(name, memberId) { }

    public override double CalculateFees()
    {
        return 500;
    }
}
class Program
{
    static void Main()
    {
        Member s = new Student("Rahul", 51556);
        Member r = new Ragular("Amin", 52578);

        Console.WriteLine($"Student fees: {s.CalculateFees()}");
        Console.WriteLine($"Ragular fees: {r.CalculateFees()}");
    }
}