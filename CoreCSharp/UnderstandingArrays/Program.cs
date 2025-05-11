namespace UnderstandingArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeclareImplicitArrays();
        }

        static void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Implicit Array Initialization.");

            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a: {0}", a.ToString());

            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is a: {0}", b.ToString());

            var c = new[] { "hello", null, "there" };
            Console.WriteLine("c is a: {0}", c.ToString());

            var d = new[] { 882L, 134, 911 };
            Console.WriteLine("d is a: {0}", d.ToString());

            Console.WriteLine();
        }
    }
}
