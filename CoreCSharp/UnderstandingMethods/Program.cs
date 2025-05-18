namespace UnderstandingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddWrapper(15, 25));
            Console.WriteLine(AddUsingOut(15, 35, out int ans));
            Console.WriteLine(AddUsingOut(15, 15, out _));

            Console.WriteLine(ans);

            string s1 = "Mama";
            string s2 = "Mia";
            int i1 = 12;
            int i2 = 14;

            Console.WriteLine($"{s1} {s2}");
            Console.WriteLine($"{i1} {i2}");
            SwapStrings(ref s1, ref s2);
            SwapInts(ref i1, ref i2);
            Console.WriteLine($"{s1} {s2}");
            Console.WriteLine($"{i1} {i2}");

            Console.WriteLine(AddReadOnly(i1, i2));
            Console.WriteLine(AddReadOnly(i1));

            double[] doubles = new double[] { 3.14, 3.33, 3.99 };
            Console.WriteLine(CalculateAverage(1.4, 1.6, 1.8));
            Console.WriteLine(CalculateAverage(doubles));
            Console.WriteLine();

            DisplayFancyMessage(message: "This is a fancy text.", textColor: ConsoleColor.DarkRed, backgroundColor: ConsoleColor.White);
            DisplayFancyMessage(ConsoleColor.DarkMagenta, message: "This is another fancy text.", backgroundColor: ConsoleColor.White);
        }

        static int AddWrapper(int x, int y)
        {
            return Add();

            int Add() => x + y;
        }

        static int AddUsingOut(int x, int y, out int ans)
        {
            ans = x + y;

            return ans * ans;
        }

        static void SwapStrings(ref string s1, ref string s2)
        {
            string temp = s1;
            s1 = s2;
            s2 = temp;
        }
        static void SwapInts(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static int AddReadOnly(in int x, in int y = 10)
        {
            int ans = x + y;

            return ans;
        }
        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles.", values.Length);

            double sum = 0;
            if (values.Length == 0)
            {
                return sum;
            }

            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return sum / values.Length;
        }
        static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
        {
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;

            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);

            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldBackgroundColor;
        }
    }
}