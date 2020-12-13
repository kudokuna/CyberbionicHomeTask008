using System;

namespace ExtraTask_001
{
    class Program
    {
        static void SetValues(out int first, out int second, out int third)
        {           
            while (true)
            {
                Console.WriteLine("Please set three values");
                if ((!int.TryParse(Console.ReadLine(), out first)) || (!int.TryParse(Console.ReadLine(), out second)) || (!int.TryParse(Console.ReadLine(), out third)))
                {
                    Console.WriteLine("Wrong input please try again...");
                }
                else break;
            }
        }

        static Tuple<double, double, double> GetValuesDevidedByFive(int a, int b, int c)
        {
            return new Tuple<double, double, double>((double)a / 5, (double)b / 5, (double)c / 5);
        }
        static void Main(string[] args)
        {
            int first, second, third;
            SetValues(out first, out second, out third);
            Console.WriteLine($"Values devided by 5 is :{GetValuesDevidedByFive(first, second, third)}");

            //delay
            Console.ReadLine();
        }
    }
}
