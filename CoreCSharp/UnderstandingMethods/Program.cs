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
    }
}
