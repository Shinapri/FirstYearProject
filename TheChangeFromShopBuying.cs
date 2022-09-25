using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("\nHow much money do you have?...");
            int money = Convert.ToInt32(Console.ReadLine());
            int change1 = money - 23;
            int change2 = money - 47;

            Console.Write("---Food Shop---\n1. Noodle  (23 Baht)\n2. Burger  (47 Baht)\nSelect 1 or 2...");
            int select = Convert.ToInt32(Console.ReadLine());
            if (money > 0)
            {
                if (money < 23)
                {
                    if (select == 1)
                    {
                        Console.WriteLine("You don't have ENOUGH money.");
                    }
                    else if (select == 2)
                    {
                        Console.WriteLine("You don't have ENOUGH money.");
                    }
                    else
                    {
                        Console.WriteLine("Select ONLY 1 or 2.");
                    }
                }
                else if (money >= 23 || money < 47)
                {
                    if (select == 1)
                    {
                        Console.Write("You select noodle. This is 23 Baht.\n");
                        Console.WriteLine("You pay {0}.", money);
                        Console.WriteLine("You get change for {0} Baht", change1);
                        int bank50 = change1 / 50;
                        int bank20 = (change1 % 50) / 20;
                        int coin1 = (change1 % 50) % 20;
                        Console.WriteLine("You get {0} Fifty-baht banknote.\nYou get {1} Twenty-baht banknote.\nYou get {2} one-baht coin.", bank50, bank20, coin1);
                    }
                    else if (select == 2)
                    {
                        Console.WriteLine("You don't have ENOUGH money.");
                    }
                    else
                    {
                        Console.WriteLine("Select ONLY 1 or 2.");
                    }
                }
                else if (money >= 47)
                {
                    if (select == 1)
                    {
                        Console.Write("You select noodle. This is 23 Baht.\n");
                        Console.WriteLine("You pay {0}.", money);
                        Console.WriteLine("You get change for {0} Baht", change1);
                        int bank50 = change1 / 50;
                        int bank20 = (change1 % 50) / 20;
                        int coin1 = (change1 % 50) % 20;
                        Console.WriteLine("You get {0} Fifty-baht banknote.\nYou get {1} Twenty-baht banknote.\nYou get {2} one-baht coin.", bank50, bank20, coin1);
                    }
                    else if (select == 2)
                    {
                        Console.Write("You select burger. This is 47 Baht.\n");
                        Console.WriteLine("You pay {0}.", money);
                        Console.WriteLine("You get change for {0} Baht", change2);
                        int bank20 = change2 / 20;
                        int coin5 = (change2 % 20) / 5;
                        int coin1 = (change2 % 20) % 5;
                        Console.WriteLine("You get {0} Twenty-baht banknote.\nYou get {1} Five-baht coin.\nYou get {2} one-baht coin.", bank20, coin5, coin1);
                    }
                    else
                    {
                        Console.WriteLine("Select ONLY 1 or 2.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Money must GREATER than 0.");
            }
        }
    }
}
