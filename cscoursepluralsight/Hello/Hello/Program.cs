using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)//string array
        {
            string name = Console.ReadLine();

            Console.WriteLine("How much sleep did you have last night ?");
            int hoursOfSleep = int.Parse(Console.ReadLine());
            Console.WriteLine("Hii World! "+name);
            if(hoursOfSleep<8)
                Console.WriteLine("You must be feeling tired.");
            else
            {
                
                Console.WriteLine("You are okay!");
            }
            Console.ReadKey();
        }
    }
}
