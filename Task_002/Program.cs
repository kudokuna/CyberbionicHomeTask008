using System;

namespace Task_002
{
    class Program
    {
        static void SetPaymentValue(ref double payment) 
        {
            bool isCorrect = false;

            while (true)
            {
                Console.WriteLine("Enter credit mountly payment...");
                if (!(double.TryParse(Console.ReadLine(), out payment))) 
                {
                    Console.WriteLine("Wrong input please, try again later");
                } else 
            }
        }

        static void CalculateCreditRest(double payment) 
        {
            string loanIsPayed = "Loan is payed.";


        }
        static void Main(string[] args)
        {
            int creditSum = 700;
            double payment = default;
            SetPaymentValue(ref payment);
            
        }
    }
}
