namespace EmployeeApp
{
    partial class Employee
    {
        // Members of a class that represent an object's state should not be marked as public.

        private string _empName;                // backing field
        private int _empId;                     // backing field
        private float _currPay;                 // ...
        private int _empAge;                    // ..
        private string _empSSN;
        private EmployeePayTypeEnum _payType;
        private DateTime _hireDate;

        public string Name
        {
            get { return _empName; }
            set
            {
                if (value.Length > 15)      // "value" is a contextual keyword, not a true C# keyword
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else
                {
                    _empName = value;
                }
            }
        }
        public int Id
        {
            get => _empId;
            set => _empId = value;
        }
        public float Pay
        {
            get { return _currPay; }
            set { _currPay = value; }
        }
        public int Age
        {
            get { return _empAge; }
            set { _empAge = value; }
        }
        public string SocialSecurityNumber
        {
            get { return _empSSN; }
            private set { _empSSN = value; }
        }
        public EmployeePayTypeEnum PayType
        {
            get => _payType;
            set => _payType = value;
        }
        public DateTime HireDate
        {
            get => _hireDate;
            set => _hireDate = value;
        }
    }
}
