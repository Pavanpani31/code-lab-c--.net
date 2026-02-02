using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class inheritance
    {
        public void Company()
        {
            Console.WriteLine("inheritance code = xxx");

        }
    }
    class fan : inheritance
    {
        public void model()
        {
            Console.WriteLine("Fan Model = Classic");

        }

    }

    class simpleinheristance
    {
        public static void main()
        {
            inheritance inheritance = new inheritance();
            fan fan = new fan();
            inheritance.Company();
            fan.Company();
            fan.model();
        }
    } 

}
