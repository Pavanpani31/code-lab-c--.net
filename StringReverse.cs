using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    internal class StringReverse
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter world to reverse the sentences");
            string input = Console.ReadLine();
            reverseWorldOrder(input);
            Console.WriteLine("Press enter to exist");
            Console.ReadLine();
        }

        static void reverseWorldOrder(string str)
        {
            int i;
            StringBuilder reverseSentences = new StringBuilder();
            int Start = str.Length - 1;
            int End = str.Length - 1;

            while (Start > 0)
            {
                if (str[Start] == ' ')
                {
                    i = Start + 1;
                    while (i <= End)
                    {
                        reverseSentences.Append(str[i]);
                        i++;
                    }

                    reverseSentences.Append(' ');
                    End = Start - 1;
                }
                Start--;

            }
            for (i = 0; i <= End; i++)
            {
                reverseSentences.Append(str[i]);

            }
            Console.WriteLine(reverseSentences.ToString());
        }
    }
    
}
