// This is a prime number checking app
using System;
namespace PrimeNumbers
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter starting number: ");
            int startNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ending number: ");
            int endNum = int.Parse(Console.ReadLine());
            // Making number exception as prime numbers have to be positive
            if (startNum <= 0 || endNum <= 0)
            {
                Console.WriteLine("Invalid Input!");
                Console.ReadKey();
            }
            Console.WriteLine("These are the numbers between {0} and {1}", startNum, endNum);

            for(int i = startNum; i <= endNum; i++)
            {
                int counter = 0;
                for(int j = 2; j <= i/2; j++)
                {
                    if(i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if(counter == 0 && i != 1)
                {
                    Console.WriteLine("{0} ", i);
                }
            }
        }
    }
}
 

