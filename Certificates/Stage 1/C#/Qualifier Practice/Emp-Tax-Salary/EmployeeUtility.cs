using System;

class EmployeeUtility : Employee
{
    public bool ValidateEmployeeId()
    {
        return (EmployeeId.Length == 4 && Char.IsUpper(EmployeeId[0])) ? true : false;
    }

    public double CalculateTaxAmount()
    {
        double totalTax = 0;
        if (Salary <= 20000)
        {
            totalTax = 0;
        }
        else if (Salary > 20000 && Salary <= 50000)
        {
            totalTax += (Salary - 20000) * 0.1;
        }
        else if (Salary > 50000 && Salary <= 100000)
        {
            totalTax += (30000) * 0.1 + (Salary - 50000) * 0.2;
        }
        else
        {
            totalTax += (30000) * 0.1 + (50000) * 0.2 + (Salary - 100000) * 0.3;
        }
        return totalTax;
    }
}