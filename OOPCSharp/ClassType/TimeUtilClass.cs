using static System.Console;
using static System.DateTime;

namespace ClassType
{
    static class TimeUtilClass                  // Utility Class
    {
        public static void PrintTime() => Console.WriteLine(DateTime.Now.ToShortTimeString());
        public static void PrintDate() => WriteLine(Today.ToShortDateString());
    }
}
