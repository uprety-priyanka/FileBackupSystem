using FileBackup_FleetPanda.Model;
using FileBackup_FleetPanda.Services.Abstract;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FileBackup_FleetPanda.Services.Implementation;

public class ActivityLogService: IActivityLogService
{

    public int InsertIntoActivityLog(ActivityLogModel activityLogModel)
    {
        int rowsAffected = 0;

        try
        {

            Connection connect = new Connection();
            connect.Connect();

            var sqlCommand = new SqlCommand
            {
                Connection = connect.connect
            };
          
                    sqlCommand.CommandText = "INSERT INTO activity_log (date_time, source_path, destination_path, message, status, cby) " +
                                           "VALUES (@date_time, @source_path, @destination_path, @message, @status, @cby)";

                    sqlCommand.Parameters.AddWithValue("@date_time", activityLogModel.date_time);
                    sqlCommand.Parameters.AddWithValue("@source_path", activityLogModel.source_path);
                    sqlCommand.Parameters.AddWithValue("@destination_path", activityLogModel.destination_path);
                    sqlCommand.Parameters.AddWithValue("@message", activityLogModel.message);
                    sqlCommand.Parameters.AddWithValue("@status", activityLogModel.status);
                    sqlCommand.Parameters.AddWithValue("@cby", activityLogModel.cby);

                    rowsAffected = sqlCommand.ExecuteNonQuery();
                

            connect.Close();
            
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred during the insert: " + ex.Message);
        }

        return rowsAffected;
    }



    
}
