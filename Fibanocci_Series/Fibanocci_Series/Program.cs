using System;
public class Fibonacci
{
    public class FibonocciNumbers
    {
        int n1 = 0, n2 = 1, n3, number;

        public void Fibo(int number)
        {
            Console.Write(n1 + " " + n2 + " ");//printing 0 and 1
            for (int i = 2; i <=number;i++) //loop starts from 2 because 0 and 1 are already printed    
            {
                if (i <= number)
                {
                    n3 = n1 + n2;
                    Console.Write(n3 + " ");
                    n1 = n2;
                    n2 = n3;
                }
            }
        }
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of elements: ");
            int number = Convert.ToInt32(Console.ReadLine());
            FibonocciNumbers f = new FibonocciNumbers();
            f.Fibo(number);


        }
    }
}