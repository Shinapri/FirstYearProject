using System;

namespace lab7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----Welcome to Ragnarok level up class----");
            Console.Write("Enter KEY level: ");
            int level = int.Parse(Console.ReadLine());
            Console.Write("Enter STR level: ");
            int strPoint = int.Parse(Console.ReadLine());
            Console.Write("Enter INT level: ");
            int intPoint = int.Parse(Console.ReadLine());


            //Level1-9
            if(level < 10)
            {
                Console.WriteLine("Novice");
            }
            //Level10-39
            else if (level < 39)
            {
                if (strPoint >= intPoint)
                {
                    Console.WriteLine("Swordman");
                }
                else
                {
                    Console.WriteLine("Magician");
                }
            }
            //Level40+
           else if (level >= 40)
            {
                if (strPoint >= intPoint)
                {
                    if (strPoint >= 100)
                    {
                        Console.WriteLine("Knight");
                    }
                    else
                    {
                        Console.WriteLine("Crusader");
                    }
                }
                else
                {
                    if(strPoint >= 100)
                    {
                        Console.WriteLine("Wizard");
                    }
                    else
                    {
                        Console.WriteLine("Sage");
                    }
                }
            }
        }
    }
}
