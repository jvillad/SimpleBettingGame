using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = .75;
            CashTracker player = new CashTracker() { Name = "John", Cash = 5 };

            Console.WriteLine($"Welcome to the casino. The odds are {odds}");
            
            while (player.Cash > 0) 
            {
                player.WriteMyInfo();
                
                Console.Write("How much do you want to bet: ");

                string howMuch = Console.ReadLine();
                
                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = amount * 2;
                    double value = random.NextDouble();
                    if (value < odds)
                    {
                        Console.WriteLine("Bad luck, you lose.");
                        player.Cash -= amount;

                    }
                    else
                    {
                        Console.WriteLine($"You win, {pot}");
                        player.ReceiveCash(amount);

                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid amount.");
                }

            }
            Console.WriteLine("The house always wins.");
            Console.ReadLine();
        }
    }
}
