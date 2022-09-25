namespace Ass6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("-- BU FOREX 4D FUNDING --");
            Console.WriteLine("-------------------------");
            
            //User Input
            Console.Write("Input your investment amount: ");
            //เงินเริ่มต้น
            double investAmount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input your number of downline member: ");
            //จน.สมาชิก
            int member = Convert.ToInt32(Console.ReadLine());
            double Rate = investAmount * 0.1;//โบนัสเริ่มต้น
            double BonusRate;

            //เงื่อนไข+แสดงผล
            if (member>=60)
            {
                BonusRate = 0.3;
                double BonusAmount = BonusRate * investAmount;
                Console.WriteLine();
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                Console.WriteLine($"Start Amount is {investAmount}");
                Console.WriteLine("Interest Rate is 10%");
                Console.WriteLine($"Interest Amount is {Rate}");
                Console.WriteLine($"Bonus Rate is {BonusRate*100}%");
                Console.WriteLine($"Bonus Amount is {BonusAmount}");
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Total Return Amount is {investAmount+Rate+BonusAmount}");
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            }
            else if (member <60&&member>=30)
            {
                BonusRate = 0.2;
                double BonusAmount = BonusRate * investAmount;
                Console.WriteLine();
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                Console.WriteLine($"Start Amount is {investAmount}");
                Console.WriteLine("Interest Rate is 10%");
                Console.WriteLine($"Interest Amount is {Rate}");
                Console.WriteLine($"Bonus Rate is {BonusRate * 100}%");
                Console.WriteLine($"Bonus Amount is {BonusAmount}");
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Total Return Amount is {investAmount + Rate + BonusAmount}");
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            }
            else if (member <30&&member>=10)
            {
                BonusRate = 0.1;
                double BonusAmount = BonusRate * investAmount;
                Console.WriteLine();
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                Console.WriteLine($"Start Amount is {investAmount}");
                Console.WriteLine("Interest Rate is 10%");
                Console.WriteLine($"Interest Amount is {Rate}");
                Console.WriteLine($"Bonus Rate is {BonusRate * 100}%");
                Console.WriteLine($"Bonus Amount is {BonusAmount}");
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Total Return Amount is {investAmount + Rate + BonusAmount}");
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            }
            else if(member<10 &&member>1)
            {
                BonusRate = 0.01;
                double BonusAmount = BonusRate * investAmount;
                Console.WriteLine();
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                Console.WriteLine($"Start Amount is {investAmount}");
                Console.WriteLine("Interest Rate is 10%");
                Console.WriteLine($"Interest Amount is {Rate}");
                Console.WriteLine($"Bonus Rate is {BonusRate * 100}%");
                Console.WriteLine($"Bonus Amount is {BonusAmount}");
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Total Return Amount is {investAmount + Rate + BonusAmount}");
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            }else if (member > 0 && member <= 1)
            {
                BonusRate = 0;
                double BonusAmount = BonusRate * investAmount;
                Console.WriteLine();
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                Console.WriteLine($"Start Amount is {investAmount}");
                Console.WriteLine("Interest Rate is 10%");
                Console.WriteLine($"Interest Amount is {Rate}");
                Console.WriteLine($"Bonus Rate is {BonusRate * 100}%");
                Console.WriteLine($"Bonus Amount is {BonusAmount}");
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Total Return Amount is {investAmount + Rate + BonusAmount}");
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            }
        }

    }
}