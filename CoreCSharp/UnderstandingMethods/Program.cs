namespace UnderstandingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddWrapper(15, 25));
        }

        static int AddWrapper(int x, int y)
        {
            return Add();

            int Add() => x + y;
        }
    }
}
