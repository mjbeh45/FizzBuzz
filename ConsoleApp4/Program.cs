using System;
using System.Text;

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
                // Ausgabebuffer leeren
                sb.Clear();
                // wenn die Zahl durch 6 teilbar ist,  dann " " vor Buzz einfügen
                if (i % 6 == 0) sb.Append(" ");
                // wenn die Zahl durch 3 teilbar ist, dann "Fizz" vormerken
                if (i % 3 == 0) sb.Append("Fizz");
                // wenn die Zahl durch 10 teilbar ist, dann " " vor Buzz einfügen
                if (i % 10 == 0) sb.Append(" ");
                // wenn die Zahl durch 5 teilbar ist, dann "Buzz" vormerken
                if (i % 5 == 0) sb.Append("Buzz");
                // wenn die Zahl durch 7 teilbar ist, dann "Jazz" vormerken
                if (i % 7 == 0) sb.Append("Jazz");

                // wenn kein Text vorgemerkt wurde, dann die Zahl selbst in den StringBuilder einfügen
                if (sb.Length == 0) sb.Append($"{i:D}");

                // Zeilen Umbruch hinzufügen
                sb.AppendLine();
                
                // Text ausgeben
                Console.Write(sb.ToString());
            }
            
            AlternativeLoesung();
        }
    
        public static void AlternativeLoesung()
        {
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
                // wenn die Zahl durch 10 teilbar ist, dann gebe vor dem "Buzz" ein Leerzeichen aus

                else if (i % 10 == 0)
                {
                    Console.WriteLine(" Buzz");
                }

                // wenn die Zahl durch 7teilbar ist, dann gebe "Fizz" aus

                else if (i % 7 == 0)
                {
                    Console.WriteLine("Jazz");
                }
                // wenn die Zahl durch 6 teilbar ist, dann gebe vor dem "Fizz" ein Leerzeichen aus

                else if (i % 6 == 0)
                {
                    Console.WriteLine(" Fizz");
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
