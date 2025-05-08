using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
                
                // wenn die Zahl durch 3 teilbar ist, dann gebe "Fizz" aus
                
                if (i % 3== 0)
                {
                    Console.WriteLine("Fizz");
                }
                // wenn die Zahl durch 5 teilbar ist, dann gebe "Buzz" aus
                
                else if (i % 5==0)
                {
                    Console.WriteLine("Buzz");
                }
                // wenn die Zahl durch 3 und 5 teilbar ist, dann gebe "Fizz" aus
                else if (i % 3 == 0 && i % 6 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                Console.WriteLine(i);  

                

            }

           // Console.ReadLine();
        }
    }
}
