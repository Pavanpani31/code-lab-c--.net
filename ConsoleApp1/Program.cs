using System;
using System.Security.Cryptography.X509Certificates;
class Factorial
{
    static void Main()
    {
        Console.Write("Enter number to be check Factorail:");
        int num = int.Parse(Console.ReadLine());
        long fact = 1;

        for (int i = 1; i <= num; i++)
            fact *= i;
        Console.WriteLine($"Factorail of given number{num} is {fact}");
    }

}

class Fibonocci
{
    static void Main()
    {
        Console.Write("Enter number to check fibonocci");
        int num = int.Parse(Console.ReadLine());
        int a = 0, b = 1, c;

        Console.WriteLine($"{a} {b}");
        for (int i = 2; i <= num; i++)
        {
            c = a + b;
            Console.WriteLine($"{c}");
            a = b;
            b = c;
        }

    }
}


class Statement
{
    public static void Main()
    {
        int age = 18;
        Console.WriteLine("Enter your age:");
        age = Convert.ToInt32(Console.ReadLine());

        if (age <= 18)
        {
            Console.WriteLine("Your not able use this website");
        }
        else if (age > 18 && age <= 28)
        {
            Console.WriteLine("you Good Access this page please login");

        }
        else if (age >= 30)
        {
            Console.WriteLine("you willbe get better expericess of this page ");
        }

        else
        {
            Console.WriteLine("enter you age in currecte format");
        }
    }
}

class Primenumber
{
    public static void Main()
    {
        Console.WriteLine("Enter a number to check prime or not: ");
        int num = Convert.ToInt32(Console.ReadLine());
        bool IsPrime = true;
        for (int i = 2; i < num / 2; i++)
        {
            if (num % i == 0)
            {
                IsPrime = false;
                break;

            }
        }
        if (IsPrime)
        {
            Console.WriteLine($"The given {num} is a prime.");
        }
        else
        {
            Console.WriteLine($"The given {num} is Not a prime. ");
        }
        Console.ReadKey();
    }
}


//Constructor insilazation and calling in apppliacation programee 

class Rectangle
{
    public int lenght, width;
    public Rectangle(int x, int y)
    {
        lenght = x; 
        width = y;  
    }
    public int RectArea()
    {
        return lenght * width;
    } 

}
class RectangleAre
{
    public static void main()
    {
        Rectangle Rect1 = new Rectangle(15, 20); // controuctor 
        int area1 = Rect1.RectArea();
        Console.WriteLine("area1=" +area1);
    }
}
