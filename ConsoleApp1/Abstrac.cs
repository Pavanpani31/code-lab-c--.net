using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Abstrac
    {

    }
    public abstract class animal
    {
        public abstract void makesound(); // adstarc methos with no body 

        public void sleep() // drived Class 
        {
            Console.WriteLine("Animal id sleeping");
        }
    }

    public class dog : animal
    {
        public override void makesound() // over ride the abstarct method 
        {
            Console.WriteLine("Dog Bow Bow");
        }
    }

    public class cat : animal
    {
        public override void makesound()
        {
            Console.WriteLine("Cat meow meow");
        }
    }

   class program
   {
        static void main()
        {
            animal dog = new dog();
            dog.sleep();
            dog.makesound();

            animal cat = new cat();
            cat.sleep();
            cat.sleep();
        }
    }

}
