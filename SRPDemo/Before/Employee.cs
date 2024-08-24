using System.Text;

namespace SRPDemo.Before
{
    public class Employee
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public decimal HourlyRate { get; set; }


        /// <summary>
        /// Calculate how much to pay employee
        /// </summary>
        /// <param name="hoursWorked"></param>
        /// <returns></returns>
        public decimal CalculatePay(decimal hoursWorked)
        {
            return this.HourlyRate * hoursWorked;
        }

        /// <summary>
        /// Save customer info to database
        /// </summary>
        public void Save()
        {
            // TODO: Save to database
            Console.WriteLine("Saving data for employee {0} {1}...", FirstName, LastName);
        }

        /// <summary>
        /// Format text about Employee that can be appended to a report
        /// </summary>
        /// <returns></returns>
        public string ReportHours()
        {
            var sb = new StringBuilder();
            sb.Append(this.FirstName);
            sb.Append(" ");
            sb.Append(this.LastName);
            sb.Append("\n");
            sb.Append(this.JobTitle);

            return sb.ToString();
        }
    }
}
