using System;

class Person
{
    public string name;
    public int age;

    public void GetPerson()
    {
        Console.Write("Enter Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Age: ");
        age = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayPerson()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Student : Person
{
    public int rollno;



    public void GetStudent()
    {
        Console.Write("Enter Roll Number: ");
        rollno = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayStudent()
    {
        Console.WriteLine("Roll Number: " + rollno);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        s.GetPerson();
        s.GetStudent();

        Console.WriteLine("\nStudent Details");
        s.DisplayPerson();
        s.DisplayStudent();

        Console.ReadLine();
    }
}
