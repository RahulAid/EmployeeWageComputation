using System;

public class EmpWageBuilderObject
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;

    private string company;
    private int empRatePerHour;
    private int noOfWorkingDays;
    private int maxHoursPerMonth;
    private int totalEmpWage;
    public EmpWageBuilderObject(string company, int empRatePerHour, int noOfWorkingDays, int maxHoursPerMonth)
    {
        this.company = company;
        this.empRatePerHour = empRatePerHour;
        this.noOfWorkingDays = noOfWorkingDays;
        this.maxHoursPerMonth = maxHoursPerMonth;
    }

    public void computeEmpWage()
    {

        //Variables

        int empHrs = 0;
        int totalEmpHrs = 0;
        int totalWorkingDays = 0;

        //computation

        while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.noOfWorkingDays)
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
        int totalEmpWage = totalEmpHrs * this.empRatePerHour;
        Console.WriteLine("Total Emp Wage for company " + company + "is : " + totalEmpWage);
        //return totalEmpWage;
    }
    public string toString()
    {
        return "Total Emp Wage for Company " + company + "is : " + this.totalEmpWage;
    }
}
