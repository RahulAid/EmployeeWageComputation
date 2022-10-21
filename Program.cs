namespace EmployeeWageComputation
{
    internal class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public static int computeEmpWage(string company, int empRatePerHour, int noOfWorkingDays, int maxHoursPerMonth)
        {

            //Variables

            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            //computation

            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < noOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;

            }

            Console.WriteLine("Total working days : " + totalWorkingDays + " Total working hours : " + totalEmpHrs);
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {

            computeEmpWage("DMart", 20, 2, 10);
            computeEmpWage("Reliance", 10, 4, 20);
        }
    }
}
