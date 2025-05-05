namespace EnvironmentClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowEnvironmentDetails();
        }

        static void ShowEnvironmentDetails()
        {
            Console.WriteLine("Domain Name: {0}", Environment.UserDomainName);
            Console.WriteLine("Machine Name: {0}", Environment.MachineName);
            Console.WriteLine("User Name: {0}", Environment.UserName);
            Console.WriteLine("\nMachines's Drives: ");
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive {0}", drive);
            }

            Console.WriteLine("\nOS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET Core Version: {0}", Environment.Version);

            Console.WriteLine("\nCommand Line: {0}", Environment.CommandLine);
            Console.WriteLine("\nCurrent Directory: {0}", Environment.CurrentDirectory);
            Console.WriteLine("\nDesktop Directory: {0}", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

            Console.WriteLine("\nProcess Path: {0}", Environment.ProcessPath);
            Console.WriteLine("\nMinutes since the machine's start: {0}", Environment.TickCount64/1000/60);
            Console.WriteLine("\nWorking set: {0}", Environment.WorkingSet);
        }
    }
}
