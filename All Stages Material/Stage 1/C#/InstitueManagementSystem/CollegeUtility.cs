using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Net_App1  //DO NOT change the namespace name
{
	public class CollegeUtility
{
    public bool DeleteCollegeById(int id)
    {
        using (var connection = new DBHandler().GetConnection())
        {
            connection.Open();
            var command = new OracleCommand($"DELETE FROM College WHERE Id = {id}", connection);
            var rowsAffected = command.ExecuteNonQuery();
            return rowsAffected > 0;
        }
    }

    public College GetCollegeById(int id)
    {
        using (var connection = new DBHandler().GetConnection())
        {
            connection.Open();
            var command = new OracleCommand($"SELECT * FROM College WHERE Id = {id}", connection);
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new College
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Location = reader.GetString(2),
                    StudentsCount = reader.GetInt32(3)
                };
            }
            else
            {
                return null;
            }
        }
    }

    public int CalculateFees(string collegeName, string department)
{
    int tuitionFees = 0;
    int hostelFees = 0;

    if (collegeName.Equals("PSG")) {
        if (department.Equals("ECE")) {
            tuitionFees = 25000;
            hostelFees = 20000;
        } else if (department.Equals("CSE")) {
            tuitionFees = 30000;
            hostelFees = 20000;
        } else if (department.Equals("MECH")) {
            tuitionFees = 35000;
            hostelFees = 20000;
        }
    } else if (collegeName.Equals("COE")) {
        if (department.Equals("ECE")) {
            tuitionFees = 28500;
            hostelFees = 18500;
        } else if (department.Equals("CSE")) {
            tuitionFees = 35600;
            hostelFees = 18500;
        } else if (department.Equals("MECH")) {
            tuitionFees = 23450;
            hostelFees = 18500;
        }
    } else if (collegeName.Equals("NIT")) {
        if (department.Equals("ECE")) {
            tuitionFees = 45500;
            hostelFees = 35000;
        } else if (department.Equals("CSE")) {
            tuitionFees = 43000;
            hostelFees = 35000;
        } else if (department.Equals("MECH")) {
            tuitionFees = 55000;
            hostelFees = 35000;
        }
    }

    return tuitionFees + hostelFees;
}

}

}
