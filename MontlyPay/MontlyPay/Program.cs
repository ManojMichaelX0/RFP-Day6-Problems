using System;

namespace MontlyPay
{
    public class MontlyPayment
    {
        public static double P, Y, R, r, n, payment,x,y;
        public static void montlypayment(double P, double Y, double R)
        {
            n = 12 * Y;
            r = R /(12 * 100);
            x = (1 + r);
            y=Math.Pow(x,-n);
            payment = (P * r) / 1 - y;

            Console.WriteLine($"Payment for given values is : {payment}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MontlyPayment mp= new MontlyPayment();
            Console.WriteLine("Enter P , Y ,R values ");
            MontlyPayment.P = Convert.ToDouble(Console.ReadLine());
            MontlyPayment.Y = Convert.ToDouble(Console.ReadLine());
            MontlyPayment.R = Convert.ToDouble(Console.ReadLine());
            MontlyPayment.montlypayment(MontlyPayment.P, MontlyPayment.Y, MontlyPayment.R);
        }
    }
}