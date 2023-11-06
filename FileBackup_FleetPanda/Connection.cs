using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace FileBackup_FleetPanda;

public class Connection
{
   // public static SQLiteConnection connect = null;
    public SqlConnection connect;
    public void Connect()
    {      
        connect = new SqlConnection("Server=UPRETY; Database=FleetPanda; Trusted_Connection= True; MultipleActiveResultSets=true;");

        try
        {
            connect.Open();
        }
        catch (Exception)
        {
            //nothing 
        }
    }
    public void Close()
    {

        try
        {
            connect.Close();
        }
        catch (Exception)
        {
            //nothing 
        }
    }
}
