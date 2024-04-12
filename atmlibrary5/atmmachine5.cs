using System;
using System.Threading;

namespace ATMlibrary5
{
    public class atmmachine5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PLEASE INSERT YOUR CARD");
            Thread.Sleep(1000);
            Console.WriteLine("PLEASE ENTER YOUR PIN NUMBER");
            String pinnumber = Console.ReadLine();

            if (pinnumber == "1234")
            {
                Console.WriteLine("access granted");
                Thread.Sleep(1000);
                Console.WriteLine("1 - SHOW BALANCE \n" +
                    "2 - WITHDRAW MONEY");
                String choices = Console.ReadLine();

                if (choices == "1")
                {
                    balance();
                }
                else if (choices == "2")
                {
                    withdraws();
                }
            }
            else
            {
                Console.WriteLine("invalid input");
            }

        }

        public static void balance()
        {
            Console.WriteLine("YOUR BALANCE IS 30,000");
        }

        public static void withdraws()
        {
            {
                Thread.Sleep(2000);
                Console.WriteLine("ENTER AMOUNT: ");
                string amount = Console.ReadLine();

                if (int.TryParse(amount, out int withdrawalAmount))
                {
                    if (withdrawalAmount <= 21342)
                    {
                        Console.WriteLine("TAKE YOUR CASH");
                    }
                    else
                    {
                        Console.WriteLine("YOU DON'T HAVE ENOUGH MONEY");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid amount entered");
                }
            }
        }
    }
}