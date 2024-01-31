namespace OpenClose
{
    public class EmployeePartTime : Employee
    {

        public EmployeePartTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
            HourValue = (decimal)HoursValues.EmployeePartTime;
        }

        public override decimal CalculateSalaryMonthly()
        {
            decimal salary = HourValue * HoursWorked;
            if (HoursWorked > 160)
            {
                decimal effortCompensation = 5000M;
                int extraDays = HoursWorked - 160;
                salary += effortCompensation * extraDays;
            }
            return salary;
        }
    }
}