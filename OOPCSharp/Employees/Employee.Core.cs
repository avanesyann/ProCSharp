namespace Employees
{
    partial class Employee
    {
        // Members of a class that represent an object's state should not be marked as public.

        protected string EmpName;             
        protected int EmpId;                   
        protected float CurrPay;             
        protected int EmpAge;                
        protected string EmpSsn;
        protected EmployeePayTypeEnum PayType { get; set; }
        protected DateTime HireDate { get; set; }

        // Contain a BenefitPackage object.
        protected BenefitPackage EmpBenefits = new BenefitPackage();

        public string Name
        {
            get { return EmpName; }
            set
            {
                if (value.Length > 15) 
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else
                {
                    EmpName = value;
                }
            }
        }
        public int Id
        {
            get => EmpId;
            set => EmpId = value;
        }
        public float Pay
        {
            get { return CurrPay; }
            set { CurrPay = value; }
        }
        public int Age
        {
            get { return EmpAge; }
            set { EmpAge = value; }
        }
        public string SocialSecurityNumber
        {
            get { return EmpSsn; }
            private set { EmpSsn = value; }
        }
    }
}
