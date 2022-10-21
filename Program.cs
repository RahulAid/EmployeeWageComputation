namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Wage Computation");
            int Fulltime = 1;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == Fulltime)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}