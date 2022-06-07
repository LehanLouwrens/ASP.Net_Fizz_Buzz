using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++) // Looping numbers 1 to 100
            {
                string output = "";
                if (i % 3 == 0) // check to see if the number is divisible by 3
                {
                    output = "Fizz";
                }

                if (i % 5 == 0) // check to see if number is divisible by 5
                {
                    output += "Buzz"; // Will add Buzz to Fizz if Fizz is already an output and will also add Buzz to values divisible by 5
                }

                if (output.Length == 0) // If output is 0 then neither Fizz or Buzz will be added
                {
                    output = i.ToString();
                }

                Console.WriteLine(output);
            }
        }
    }
}