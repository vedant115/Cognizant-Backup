using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Net_App1         //DO NOT change the namespace name
{
    public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the choice");
        Console.WriteLine("1. Delete the college id in the database.");
        Console.WriteLine("2. Get College By Id");
        Console.WriteLine("3. Calculate the Fees of the College.");
        Console.WriteLine("4. Exit");
        Console.WriteLine("Select Your Choice :");

        var choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("Enter the Id :");
                var id = Convert.ToInt32(Console.ReadLine());
                var deleted = new CollegeUtility().DeleteCollegeById(id);
                Console.WriteLine(deleted ? "College Information Deleted Successfully" : "College Information Deletion Failed");
                break;

            case "2":
                Console.WriteLine("Enter the College id");
                var collegeId = Convert.ToInt32(Console.ReadLine());
                var college = new CollegeUtility().GetCollegeById(collegeId);
                if (college != null)
                {
                    Console.WriteLine($"{college.Id} {college.Name} {college.StudentsCount}");
                }
                else
                {
                    Console.WriteLine("College Not Found");
                }
                break;

            case "3":
                Console.WriteLine("Enter the CollegeName :");
                var collegeName = Console.ReadLine();
                Console.WriteLine("Enter the Department :");
                var department = Console.ReadLine();
                var fees = new CollegeUtility().CalculateFees(collegeName, department);
                if (fees > 0)
                {
                    Console.WriteLine($"Calculated Fees Amount for {department} department in '{collegeName}' College - {fees}");
                }
                else
                {
                    Console.WriteLine("Invalid College Name or Department");
                }
                break;
            case "4":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}

}

