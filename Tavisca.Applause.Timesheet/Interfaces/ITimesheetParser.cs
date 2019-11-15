using System;
using System.Collections.Generic;
using System.Data;

namespace Tavisca.Applause.Timesheet
{
    interface ITimesheetParser
    {
        void Parse(DateTime date, DataTable timesheetDetails, List<Holiday> holidays, bool isEndOfMonth);
    }
}
