using System;

namespace Fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Loop that prints all values from 1-255
            Console.WriteLine("\n");
            Console.WriteLine("#1 Loop");
            for(int i=1; i<=255; i++)
            {
                Console.WriteLine(i);
            }
            
            // Create a new loop that prints all values from 1-100 
            // that are divisible by 3 or 5, but not both
            Console.WriteLine("\n");
            Console.WriteLine("#2 Divisible Loop");
            for(int i=1; i<=255; i++)
            {
                if(i%3==0 && i%5==0)
                {
                    continue;
                }
                if(i%3==0 || i%5==0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
            }

            // Modify the previous loop to print "Fizz" for multiples of 3, 
            // "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
            Console.WriteLine("\n");
            Console.WriteLine("#3 FizzBuzz");
            for(int i=1; i<=255; i++)
            {
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                if(i%3==0)
                {
                    Console.WriteLine("Fizz");
                }
                if(i%5==0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    continue;
                }
            }

            // (Optional) Generate 10 random values and output the respective word, 
            // in relation to step three, for the generated values
            Console.WriteLine("\n");
            Console.WriteLine("#5 RandomValues");
            Random rand = new Random();
            for(int i=0; i<10; i++)
            {   
                int randNumber = rand.Next(0,256);
                if(randNumber%3==0 && randNumber%5==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                if(randNumber%3==0)
                {
                    Console.WriteLine("Fizz");
                }
                if(randNumber%5==0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
