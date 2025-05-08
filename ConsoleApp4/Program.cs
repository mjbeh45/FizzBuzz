using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // da in der Aufgabe steht, dass die Zahklen bis 100 zurückgegben werden sollen.
            for (int i = 1; i <= 100; i++)
            {
                //wenn die Zahl durch 7,5 und 3 teilbar ist, dann gebe "FizzBuzz" aus
                if (i % 7 == 0 && i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzzJazz");
                }
                // wenn die Zahl durch 3 und 5 teilbar ist, dann gebe "FizzBuzz" aus
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                // wenn die Zahl durch 7 und 5 teilbar ist, dann gebe "FizzBuzz" aus
                else if (i % 7 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("BuzzJazz");

                }
                // wenn die Zahl durch 7 und 3 teilbar ist, dann gebe "FizzBuzz" aus
                else if (i % 7 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzJazz");

                }

                // wenn die Zahl durch 7teilbar ist, dann gebe "Fizz" aus

                else if (i % 7 == 0)
                {
                    Console.WriteLine("Jazz");
                }
                // wenn die Zahl durch 3 teilbar ist, dann gebe "Fizz" aus

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                // wenn die Zahl durch 5 teilbar ist, dann gebe "Buzz" aus

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else
                {
                    Console.WriteLine(i);
                }
                     

                

            }

          
        }
    }
}
