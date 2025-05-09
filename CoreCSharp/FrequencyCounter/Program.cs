using System.Text.RegularExpressions;

namespace FrequencyCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your sentence: ");
            string sentence = Console.ReadLine();
            Dictionary<string, int> occurrences = new Dictionary<string, int>();

            string cleaned = Regex.Replace(sentence, @"[^\w\s]", "").ToLower();

            string[] words = cleaned.Split(' ', StringSplitOptions.RemoveEmptyEntries);


            foreach (string word in words)
            {
                if (occurrences.ContainsKey(word))
                    occurrences[word]++;
                else
                    occurrences.Add(word, 1);
            }

            foreach (var wrd in occurrences)
            {
                Console.WriteLine($"{wrd.Key}: {wrd.Value}");
            }
        }
    }
}
