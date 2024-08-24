namespace SRPDemo.After
{
    public class Payroll
    {
        public decimal CalculatePay(Employee employee, decimal hoursWorked)
        {
            return employee.HourlyRate * hoursWorked;
        }
    }
}
