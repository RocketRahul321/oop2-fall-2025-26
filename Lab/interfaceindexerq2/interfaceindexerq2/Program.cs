
//question no.2

using System;



interface Istudent
{
    void display();
}



class student : Istudent
{
    private int[] marks = new int[3];

    public int this[int index]
    {
        get { return marks[index]; }
        set { marks[index] = value; }
    }
    public void display()
    {
        Console.WriteLine("Displaying Student Information");
        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine("Score " + (i + 1) + ": " + marks[i]);
        }
    }
}

class Program
{
    static void Main()
    {

        student stu = new student();

        stu[0] = 99;
        stu[1] = 60;
        stu[2] = 88;

        stu.display();


    }
}
