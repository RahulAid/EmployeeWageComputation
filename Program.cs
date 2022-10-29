namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("Microsoft", 100, 20, 100);
            empWageBuilder.addCompanyEmpWage("Google", 200, 30, 150);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total Wage as queried by respective companies are : ");
            Console.WriteLine("Total wage for Microsoft " + empWageBuilder.getTotalWage("Microsoft"));
            Console.WriteLine("Total wage for Google " + empWageBuilder.getTotalWage("Google"));
            Console.ReadLine();
        }
    }
}
