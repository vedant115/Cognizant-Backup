using System;

class Program
{
    public static void Main(string[] args){
        EmployeeUtility emp = new EmployeeUtility();
        
        Console.WriteLine("Enter the employee id");
        string id = Console.ReadLine();
        
        emp.EmployeeId = id;
        if(emp.ValidateEmployeeId()){
            Console.WriteLine("Enter the salary");
            double salary = double.Parse(Console.ReadLine());
            emp.Salary = salary;
            Console.WriteLine("Tax amount to pay is {0}", emp.CalculateTaxAmount());
        }
        else{
            Console.WriteLine("Invalid employee id.");
        }
        
    }
}