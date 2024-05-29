using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace ADO_Net_App1      //DO NOT change the namespace name
{
    public class DBHandler
{
    public OracleConnection GetConnection()
    {
        return new OracleConnection(DBConnection.connStr);
    }
}
}


