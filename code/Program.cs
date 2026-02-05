using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the word you need to reverse:");
        string input = Console.ReadLine();

        ReverseString(input);

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }

    static void ReverseString(string str)
    {
        char[] chararray = str.ToCharArray();

        for (int i = 0, j = chararray.Length - 1; i < j; i++, j--)
        {
            char temp = chararray[i];
            chararray[i] = chararray[j];
            chararray[j] = temp;
        }

        Console.WriteLine("Reversed word: " + new string(chararray));
    }
}
