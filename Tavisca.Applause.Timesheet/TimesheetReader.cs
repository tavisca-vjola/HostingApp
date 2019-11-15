using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace Tavisca.Applause.Timesheet
{
    class TimesheetReader : ITimesheetReader
    {
        public DataTable Read(Stream stream)
        {
            throw new NotImplementedException();
            //This will change column names as per requirement and the will return updated data table
        }
    }
}
