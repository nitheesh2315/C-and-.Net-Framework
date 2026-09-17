using System;

class Number
{
    int value;

    public Number(int v)
    {
        value = v;
    }

    public static Number operator +(Number a, Number b)
    {
        return new Number(a.value + b.value);
    }
    public static Number operator -(Number a, Number b)
    {
        return new Number(a.value - b.value);
    }

    public static Number operator *(Number a, Number b)
    {
        return new Number(a.value * b.value);
    }

    public void Display()
    {


        Console.WriteLine(value);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter First Number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Number a = new Number(n1);
        Number b = new Number(n2);
        Number add = a + b;
        Number sub = a - b;
        Number mul = a * b;

        Console.Write("Addition: ");
        add.Display();
        Console.Write("Subtraction: ");
        sub.Display();
        Console.Write("Multiplication: ");
        mul.Display();
        Console.ReadLine();
    }
}
