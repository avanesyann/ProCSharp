namespace UnderstandingArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeclareImplicitArrays();
            JaggedArray();
            IndicesAndRanges();
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

        static void JaggedArray()
        {
            Console.WriteLine("=> Jagged multidimensional array.");

            int[][] jagArr = new int[5][];

            for (int i = 0; i < jagArr.Length; i++)
            {
                jagArr[i] = new int[i + 7];
            }

            for (int i = 0; i < jagArr.Length; i++)
            {
                for (int j = 0; j < jagArr[i].Length; j++)
                {
                    Console.Write(jagArr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void IndicesAndRanges()
        {
            Console.WriteLine("=> Indices and Ranges.");

            int[] ranks = new int[] { 14, 16, 18, 20, 22, 24 };

            for (int i = 0; i < ranks.Length; i++)
            {
                Index idx = i;
                Console.WriteLine(ranks[idx]);
            }
            Console.WriteLine();
            for (int i = 1; i <= ranks.Length; i++)
            {
                Index idx = ^i;
                Console.WriteLine(ranks[idx]);
            }
        }
    }
}
