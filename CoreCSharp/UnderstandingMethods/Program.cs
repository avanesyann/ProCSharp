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
    }
}
