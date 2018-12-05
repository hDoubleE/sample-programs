using System;

namespace InterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateInterest(100, 30, 5);
        }

        static void CalculateInterest(double amount, int years, double interest)
        {
            Convert.ToDouble(interest);
            interest = interest / 100;

            for (int i = 0; i < years; i++)
            {
                double interestPerPeriod = amount * interest;
                double result = amount + interestPerPeriod;
                amount += interestPerPeriod;
                Console.WriteLine(result);
            }
        }
    }
}