using System;

namespace Task_002
{
    class Program
    {
        static void SetPaymentValue(out double payment) 
        {
            while (true)
            {
                Console.WriteLine("Enter credit mountly payment...");
                if ((!(double.TryParse(Console.ReadLine(), out payment))) || payment < 100)
                {
                    Console.WriteLine("Wrong input please, try again later");
                }
                else break;
            }
        }

        static void CalculateCreditRest(double payment, int creditAmount = 700) 
        {
            string loanIsPayed = "Loan is payed.\n";
            string loanIsUnpaid = "loan is unpaid yet\n";
            double restPayment = creditAmount - payment;
            
            if (restPayment > 0) 
            {
                Console.WriteLine(loanIsUnpaid);
                Console.WriteLine($"Loan rest is {restPayment} UAH");
                Console.WriteLine($"Next mounthly payment is {restPayment / 6} UAH");
            }

            if (restPayment == 0) 
            {
                Console.WriteLine(loanIsPayed);
            }

            if (restPayment < 0)
            {
                Console.WriteLine(loanIsPayed);
                Console.WriteLine($"Overpayment is {Math.Abs(restPayment)} UAH");
            }
        }
        static void Main(string[] args)
        {
            double payment;
            SetPaymentValue(out payment);
            CalculateCreditRest(payment);
            Console.ReadKey();
        }
    }
}
