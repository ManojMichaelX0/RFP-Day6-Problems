using System;
public class PrimeNumber
{
    int m;
    public void Prime(int number)
    {
        m = number / 2;
        for (int i = 2; i <= m; i++)
        {
            if (number % i == 0)
            {
                Console.Write($" Given Number {number} is not Prime.");
                
            }
            else
            {
                Console.WriteLine($"Given Number {number} is a Prime");
            }
        }
        
    }
    

}
public class Program 
{
    
    public static void Main(string[] args)
    {
       
        Console.Write("Enter the Number to check Prime: ");
        int number = Convert.ToInt32(Console.ReadLine());
        PrimeNumber p = new PrimeNumber();
        p.Prime(number);
    }
}