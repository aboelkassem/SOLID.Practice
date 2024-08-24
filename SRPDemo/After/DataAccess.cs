namespace SRPDemo.After
{
    public class DataAccess
    {
        public void Save(Employee employee)
        {
            // TODO: Save to database
            Console.WriteLine("Saving data for employee {0} {1}...", 
                employee.FirstName, employee.LastName);
        }
    }
}
