using System;
class Student
{
    public void Details()
    {
        Console.Write("Roll No: ");
        long roll = Convert.ToInt64(Console.ReadLine());
        Console.Write("Name: ");
        string? name = Console.ReadLine();
        Console.Write("Mark 1: ");
        int m1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Mark 2: ");
        int m2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Mark 3: ");
        int m3 = Convert.ToInt32(Console.ReadLine());
        int total = m1 + m2 + m3;
        double avg = total / 3.0;
        Console.WriteLine("Roll No: " + roll);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Total: " + total);
        Console.WriteLine("Average: " + avg);
    }
}
class Program
{
    static void Main()
    {


        Student s = new Student();
        s.Details();
    }
}
