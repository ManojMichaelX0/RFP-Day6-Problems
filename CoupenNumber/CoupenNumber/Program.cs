using System;

namespace CoupenNumber
{
    public class CoupenNumber
    {
        public int N;
        public static void Coupen(int N)
        {
            Random random = new Random();
            for (int i = 0; i <N; i++)
            {
                Console.WriteLine(random.Next());
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N Value");
            CoupenNumber c = new CoupenNumber();
           int N=Convert.ToInt32(Console.ReadLine());
            CoupenNumber.Coupen(N);
           
        }
    }
}
