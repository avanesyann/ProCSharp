using System.Runtime.CompilerServices;

namespace UnderstandingTuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string, int, string) values = ("a", 5, "c");

            Console.WriteLine($"First item: {values.Item1}");
            Console.WriteLine($"Second item: {values.Item2}");
            Console.WriteLine($"Third item: {values.Item3}");

            (string FirstLetter, int TheNumber, string SecondLetter) valuesWithNames = ("a", 5, "c");
            var valuesWithNames2 = (FirstLetter: "a", TheNumber: 5, SecondLetter: "c");

            Console.WriteLine($"First item: {valuesWithNames.FirstLetter}");
            Console.WriteLine($"Second item: {valuesWithNames.TheNumber}");
            Console.WriteLine($"Third item: {valuesWithNames.SecondLetter}");

            // Item notation still works!

            Console.WriteLine($"First item: {valuesWithNames2.FirstLetter}");
            Console.WriteLine($"Second item: {valuesWithNames2.TheNumber}");
            Console.WriteLine($"Third item: {valuesWithNames2.SecondLetter}");

            Console.WriteLine();

            (int Number1, int Number2) example = (Custom1: 5, Custom2: 7);      // ignores right side

            Console.WriteLine(example.Number1);
            Console.WriteLine(example.Number2);

            Console.WriteLine();

            (int, (int, int)) nt = (5, (1, 2));

            Console.WriteLine($"Contents of nt: {nt.Item1}, {nt.Item2} = {nt.Item2.Item1}, {nt.Item2.Item2}");

            Console.WriteLine();

            var tsv = FillTheseValues();
            Console.WriteLine(tsv.Number);
            Console.WriteLine(tsv.Horsie);
            Console.WriteLine(tsv.IsStrong);

            Console.WriteLine();

            var name = SplitNames("Arthur Burton Morgan");
            Console.WriteLine(name.FirstName);
            Console.WriteLine(name.MiddleName);
            Console.WriteLine(name.LastName);

            Console.WriteLine();

            Console.WriteLine(RockPaperScissors("rock", "scissors"));

            Console.WriteLine();

            Point p = new Point(6, 8);
            var pointValues = p.Deconstruct();

            Console.WriteLine($"X is {pointValues.XPos}");
            Console.WriteLine($"Y is {pointValues.YPos}");

            Console.WriteLine(GetQuadrant(p));

            Console.WriteLine();

            var student = GetStudentInfo("Alice Johnson", 70, 40, 80);
            Console.WriteLine($"Name: {student.Name}, Average: {student.Average:F2}, Status: {student.Status}");
        }

        static (int Number, string Horsie, bool IsStrong) FillTheseValues()
        {
            return (9, "white horsie", true);
        }
        static (string FirstName, string MiddleName, string LastName) SplitNames(string fullName)
        {
            string[] name = fullName.Split(" ");

            return (name[0], name[1], name[2]);
        }

        static string RockPaperScissors(string first, string second)
        {
            return (first, second) switch
            {
                ("rock", "paper") => "Paper wins.",
                ("rock", "scissors") => "Rock wins.",
                ("paper", "rock") => "Paper wins.",
                ("paper", "scissors") => "Scissors wins.",
                ("scissors", "rock") => "Rock wins.",
                ("scissors", "paper") => "Scissors wins.",
                (_, _) => "Tie."
            };
        }

        static string GetQuadrant(Point p)
        {
            return p.Deconstruct() switch
            {
                (0, 0) => "Origin",
                var (x, y) when x > 0 && y > 0 => "One",
                var (x, y) when x < 0 && y > 0 => "Two",
                var (x, y) when x < 0 && y < 0 => "Three",
                var (x, y) when x > 0 && y < 0 => "Four",
                var (_, _) => "Border"
            };
        }

        static (string Name, double Average, string Status) GetStudentInfo(string name, int score1, int score2, int score3)
        {
            double average = (score1 + score2 + score3) / 3.0;
            string status = average >= 60 ? "Passed" : "Failed";

            return (name, average, status);
        }

        static (int WordCount, string LongestWord, double AverageLength) AnalyzeSentence(string sentence)
        {
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
                return (0, string.Empty, 0.0);

            string longest = words[0];
            int wordSum = 0;

            foreach (string word in words)
            {
                wordSum += word.Length;
                if (word.Length > longest.Length)
                {
                    longest = word;
                }
            }

            double average = (double)wordSum / words.Length;

            return (words.Length, longest, average);
        }
    }

    struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public (int XPos, int YPos) Deconstruct() => (X, Y);
    }
}
