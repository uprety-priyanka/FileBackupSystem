using FileBackup_FleetPanda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileBackup_FleetPanda.Services.Abstract;

public interface IActivityLogService
{
    int InsertIntoActivityLog(ActivityLogModel activityLogModel);
}
