//question no.1

using System;

interface Irpintable
{
    void Print();
}

interface Iserializable
{
    void save();
}

//interface Istudent
//{
//    void display();
//}

class Rrport :Irpintable, Iserializable
{
    public void Print()
    {
        Console.WriteLine("Printing Report");
    }
    public void save()
    {
        Console.WriteLine("Saving Report");
    }
}

//class student:Istudent
//{
//    private int[] marks= new int[3];

//    public int this[int index]
//    {
//        get { return marks[index]; }
//        set { marks[index] = value; }
//    }
//    public void display()
//    {
//        Console.WriteLine("Displaying Student Information");
//        for (int i = 0; i < marks.Length; i++)
//        {
//            Console.WriteLine("Score " + (i + 1) + ": " + marks[i]);
//        }
//    }
//}

class Program
{
  static void Main()
  {
        Rrport rpt = new Rrport();
       // student stu = new student();

       //stu[0] = 88;
       //stu[1] = 92;
       //stu[2] = 85;

       //stu.display();

         rpt.Print();
            rpt.save();
    }
}


