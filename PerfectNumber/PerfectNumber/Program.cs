using System;

namespace PerfectNumber
{
    public class PerfectNumber
    {
        public void Perfect(int number)
        {
            int sum = 0, n;
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine($"Entered number {number} is a perfect number");
            }
            else
            {
                Console.WriteLine($"Entered number {number} is not a perfect number");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int number = Convert.ToInt32(Console.ReadLine());
            PerfectNumber p = new PerfectNumber();
            p.Perfect(number);


        }
    }
}
