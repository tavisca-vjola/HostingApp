using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace Tavisca.Applause.Timesheet
{
    interface ITimesheetReader
    {
        DataTable Read(Stream stream);
    }
}
