namespace OpenClose
{
    public class EmployeeFullTime : Employee
    {

        public EmployeeFullTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
            HourValue = (decimal)HoursValues.EmployeeFullTime;
        }

        public override decimal CalculateSalaryMonthly()
        {
            decimal salary = HourValue * HoursWorked;
            return salary;
        }
    }
}