namespace OpenClose;

public class EmployeeContractor : Employee
{

    public EmployeeContractor(string fullname, int hoursWorked)
    {
        Fullname = fullname;
        HoursWorked = hoursWorked;
        HourValue = (decimal)HoursValues.EmployeeContractor;
    }

    public override decimal CalculateSalaryMonthly()
    {
        decimal salary = HourValue * HoursWorked;
        return salary;
    }
}