using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number or string to check palindrome or not:");
        string input = Console.ReadLine();

        CheckPalindrome(input);

        Console.WriteLine("Press any key to exit");
        Console.ReadLine();
    }

    static void CheckPalindrome(string str)
    {
        bool flag = true;  

        for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
        {
            if (str[i] != str[j])
            {
                flag = false;
                break;
            }
        }

        if (flag)
        {
            Console.WriteLine("Is a palindrome");
        }
        else
        {
            Console.WriteLine("Is Not a palindrome");
        }
    }
}
