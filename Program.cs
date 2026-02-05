using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RemoveDuplicate
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter to world to check the duplicates:");
            string Input = Console.ReadLine();
            removeDuplicate(Input);
            Console.WriteLine("Press any key exist");
            Console.ReadLine();

        }
        static void removeDuplicate(string str)
        {
            string result = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
