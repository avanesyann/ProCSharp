namespace StudentManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Alice", 29, null, ContactPreference.Text, 80, 90, 70));
            students.Add(new Student("Rick", 17, null, ContactPreference.Text, 60, 90, 70));
            students.Add(new Student("John", 24, null, ContactPreference.Phone, 60, 70, 60));
            students.Add(new Student("Mark", 32, null, ContactPreference.Phone, 90, 90, 100));
            students.Add(new Student("Roland", 72, null, ContactPreference.Phone, 80, 76, 84));

            foreach (var student in students)
            {
                string label = student.Age switch
                {
                    < 18 => "Minor",
                    >= 65 => "Senior",
                    _ => "Adult"
                };
                var (avg, status) = student.Average();
                Console.WriteLine($"{student.Name}'s({label}) average grade is {avg:F2}. They {status}!");
            }
        }

        static bool TryReadGrade(string prompt, out int grade)
        {
            Console.WriteLine(prompt);
            string? input = Console.ReadLine();

            if (int.TryParse(input, out grade) && grade >= 0 && grade <= 100)
            {
                return true;
            }

            grade = 0;
            return false;
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
