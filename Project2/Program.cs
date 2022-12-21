// See https://aka.ms/new-console-template for more information
using System;
namespace perfectNumbers
{
    public class program
    {
        public static void Main()
        {
            int sum;
            int min, max;

            Console.Write("Enter first number : ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            max = Convert.ToInt32(Console.ReadLine());
            Console.Write("The Perfect numbers within the given range is : \n");
            for (int i = min; i <= max; i++)
            {
                sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum += j;
                }
                if (sum == i)
                    Console.WriteLine("{0} ", i);
            }
        }
    }

}