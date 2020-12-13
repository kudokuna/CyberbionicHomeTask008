using System;

namespace Task_003
{
    class Program
    {
        static int CalculateAmountOfWays(int clientsAmount) 
        {
            if (clientsAmount == 0)
            {
                return 1;
            }
            else 
            {
                return clientsAmount * (CalculateAmountOfWays(clientsAmount - 1));
            }
            
        }

        static void Main(string[] args)
        {
            int clientsAmount = default;
            Console.WriteLine("Please type amount of clients waited for delivery...");

            if (!int.TryParse(Console.ReadLine(), out clientsAmount)) 
            {
                Console.WriteLine("Wrong Input Please try again...");
            }

            Console.WriteLine($"Amount of ways is {CalculateAmountOfWays(clientsAmount)}");
            //delay
            Console.ReadLine();
        }
    }
}
