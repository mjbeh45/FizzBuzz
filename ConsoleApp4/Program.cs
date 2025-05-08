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
            var sb = new StringBuilder();
            // da in der Aufgabe steht, dass die Zahlen bis 100 zurückgegben werden sollen.
            for (int i = 1; i <= 100; i++)
            {
                sb.Clear();
                // wenn die Zahl durch 6 teilbar ist, dann gebe " " vor Fizz aus
                if (i % 6 == 0) sb.Append(" ");
                // wenn die Zahl durch 3 teilbar ist, dann gebe "Fizz" aus
                if (i % 3 == 0) sb.Append("Fizz");
                // wenn die Zahl durch 10 teilbar ist, dann gebe " " vor Buzz aus
                if (i % 10 == 0) sb.Append(" ");
                // wenn die Zahl durch 5 teilbar ist, dann gebe "Buzz" aus
                if (i % 5 == 0) sb.Append("Buzz");
                // wenn die Zahl durch 7 teilbar ist, dann gebe "Jazz" aus
                if (i % 7 == 0) sb.Append("Jazz");

                if (sb.Length == 0)
                {
                    sb.Append($"{i:D}");
                }

                sb.AppendLine();
                Console.Write(sb.ToString());
            }
        }
    }
}
