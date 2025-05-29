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
        }

    }
}
