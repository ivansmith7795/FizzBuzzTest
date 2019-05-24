using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints the numbers from 1 to 100. 
            //But for multiples of three print “Fizz” instead of the 
            //number and for the multiples of five print “Buzz”. 
            //For numbers which are multiples of both three and five print “FizzBuzz”

            //lets start by creating our loop that will iterate through number 1 - 100

            for (int i = 1; i <= 100; i++)
            {
                //lets find out if number is divisible by 3
                double divisible3 = (double)i / 3;
                
                //lets find out if the number is divisible by 5
                double divisible5 = (double)i / 5;

                //setup our bool operators to test our Fizz or Buzz conditions
                bool isFizz = false;
                bool isBuzz = false;

                //if the number is divisble by 3, then make it a Fizz
                if (IsInteger(divisible3))
                {
                    isFizz = true;

                }

                //if the number is divisble by 5, then make it a Buzz
                if (IsInteger(divisible5))
                {
                    isBuzz = true;
                }

                //if the number isn't divisible by 3 or 5, print it out
                if(!isFizz && !isBuzz)
                {
                    Console.WriteLine(i);
                }

                //if the number is divisible by 3 but not 5, print out Fizz
                if(isFizz && !isBuzz)
                {
                    Console.WriteLine("Fizz");
                }

                //if the number is divisible by 5 but not 3, print out Buzz
                if (!isFizz && isBuzz)
                {
                    Console.WriteLine("Buzz");
                }

                //if the number is divisible by both 3 but not 5, print out FizzBuzz
                if (isFizz && isBuzz)
                {
                    Console.WriteLine("FizzBuzz");
                }

                
            }

            Console.ReadLine();

        }
        public static bool IsInteger(double number)
        {
            return number == Math.Truncate(number);
        }
    }
}
