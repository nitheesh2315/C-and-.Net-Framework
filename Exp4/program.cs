using System;
delegate void ProductDetails();
class Shopping
{
    public void Laptop()
    {
        Console.WriteLine("Product: Laptop");
        Console.WriteLine("Price: Rs.50000");
    }
    public void Mouse()
    {
        Console.WriteLine("Product: Mouse");
        Console.WriteLine("Price: Rs.500");
    }
}
class Program
{
    static void Main()
    {
        Shopping s = new Shopping();
        ProductDetails pd;
        pd = s.Laptop;
        pd();
        pd = s.Mouse;
        pd();
        Console.ReadLine();
    }
}
