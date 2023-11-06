using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileBackup_FleetPanda.Model;

public class ActivityLogModel
{
    public DateTime date_time { get; set; } = DateTime.Now;
    public string source_path { get; set; }
    public string destination_path { get; set; }
    public string message { get; set; }
    public char status { get; set; }
    // X -> Backup Cancelled, S -> Backup Sucessful , E -> Error 
    public string cby { get; set; } = "Admin";
}
