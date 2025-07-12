namespace Employees
{
    class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }

        public SalesPerson() { }
        public SalesPerson(string fullName, int age, int empId, float currPay, string ssn, int numbOfSales) : base(fullName, age, empId, currPay, ssn, EmployeePayTypeEnum.Commission)
        {
            SalesNumber = numbOfSales;
        }
    }
}
