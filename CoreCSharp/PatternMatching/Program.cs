using System.Collections.Concurrent;

namespace PatternMatching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IfElsePatternMatching("hello");
            IfElsePatternMatching(3.14);
            IfElsePatternMatching(8);
            IfElsePatternMatching(88ul);

            Console.WriteLine();

            IfElseUpdated(900);
            IfElseUpdated(19000);

            Console.WriteLine();

            SwitchPatternMatching(-6);
            SwitchPatternMatching(8);
            SwitchPatternMatching(140);
            SwitchPatternMatching(99);

        }

        static void IfElsePatternMatching(object item)
        {
            if (item is string stringItem)
            {
                Console.WriteLine($"{stringItem} is a string.");
            }
            if (item is int)
            {
                Console.WriteLine($"{item} is an int.");
            }
            if (item is double doubleItem)
            {
                Console.WriteLine($"{doubleItem} is a double.");
            }
            if (item is ulong ulongItem)
            {
                Console.WriteLine($"{ulongItem} is a ulong.");
            }
        }
        
        static void IfElseUpdated(object value)
        {
            if (value is >= 10 and < 100)
            {
                Console.WriteLine($"{value} is a two digit number.");
            }
            if (value is (>= 100 and < 1000) or (>= 10000 and < 100000))
            {
                Console.WriteLine($"{value} is either between 100 and 1.000 or 10.000 and 100.000");
            }
        }

        static void SwitchPatternMatching(int value)
        {
            switch (value)
            {
                case < 0:
                    Console.WriteLine($"{value} is negative.");
                    break;
                case < 10:
                    Console.WriteLine($"{value} is a single-digit number.");
                    break;
                case < 100:
                    Console.WriteLine($"{value} is a double-digit number.");
                    break;
                case > 100 and < 200:
                    Console.WriteLine($"{value} is between 100 and 200");
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;
            }
        }
    }
}
