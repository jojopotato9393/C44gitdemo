using System;

namespace SleepySloth
{
    class Program
    {
        static void Main(string[] args)
        {
            string stevie = "what does stevie need to wake up?";
            Console.WriteLine(stevie);
            string needed = Console.ReadLine();
            Console.WriteLine("All Stevie needed was some " + needed + "!!" );
        }
    }
}
