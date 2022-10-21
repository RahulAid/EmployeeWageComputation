namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == time)
            {
                empHrs = 8;

            }
            else
            {
                empHrs = 0;

            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
        
    }
}