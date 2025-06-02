namespace StudentManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student alice = new Student("Alice", 29, null, ContactPreference.Text, 80, 90, 70);
            var aliceStatus = alice.Average();

            Console.WriteLine($"{alice.Name}'s average grade is {aliceStatus.Average:F2}. She {aliceStatus.Status}!");

            Student john = new Student("John", 24, null, ContactPreference.Phone, 60, 70, 60);
            var johnStatus = john.Average();

            Console.WriteLine($"{john.Name}'s average grade is {johnStatus.Average:F2}. He {johnStatus.Status}!");
        }
    }

    struct Student
    {
        public string Name;
        public byte Age;
        public int[] Grades;
        public string? PhoneNumber;
        public ContactPreference ContactPref;

        public Student(string name, byte age, string? phoneNumber, ContactPreference contactPref, params int[] grades)
        {
            Name = name;
            Age = age;
            Grades = grades;
            PhoneNumber = phoneNumber;
            ContactPref = contactPref;
        }
        public (double Average, string Status) Average()
        {
            double gradeSum = 0;
            string status;

            foreach (int grade in Grades)
            {
                gradeSum += grade;
            }

            double average = gradeSum / Grades.Length;
            status = average >= 60 ? "Passed" : "Failed";

            return (average, status);
        }
    }

    [Flags]
    enum ContactPreference
    {
        None = 0,
        Phone = 1,
        Email = 2,
        Text = 4
    }
}
