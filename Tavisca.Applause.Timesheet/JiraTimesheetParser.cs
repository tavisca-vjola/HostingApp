using System;
using System.Collections.Generic;
using System.Data;

namespace Tavisca.Applause.Timesheet
{
    public class JiraTimesheetParser : ITimesheetParser
    {
        public void Parse(DateTime date, DataTable timesheetDetails, List<Holiday> holidays, bool isEndOfMonth)
        {
            throw new NotImplementedException();
            /*foreach(var row in DT)
            {
                1. Check if date is holiday/weekend - yes -> AddEmployeeTimesheetInformation
                    No->
                        1. create "EmployeeTimesheetInformation" from row
                        2. AddEmployeeTimesheetInformation
                        3. HasUserLoggedHours -> Call Point Database to increase user's point for daily submission
                        ---- Daily Handling Ends Here-------------
                        4. If it is EOM - true
                            4.1 GetRemainingDaysOfMonth
                            4.2 for each remaining day 
                                  Repeat Daily Processing
                            4.3 IsTimesheetSubmitted - Yes
                                4.3.1 Call Point Database to increase user's point for monthly submission    
            }*/
        }

        private bool IsHoliday(DateTime date, List<Holiday> holidays)
        {
            throw new NotImplementedException();
        }

        private bool IsWeekend(DateTime date)
        {
            throw new NotImplementedException();
        }

        private bool HasUserLoggedHours(DateTime date, EmployeeTimesheetInformation employeeTimesheetInformation)
        {
            throw new NotImplementedException();
        }

        private void AddEmployeeTimesheetInformation(EmployeeTimesheetInformation employeeTimesheetInformation)
        {
            throw new NotImplementedException();
            //This method will call data store to add this record to database
        }

        private List<DateTime> GetRemainingDaysOfMonth(DateTime date)
        {
            throw new NotImplementedException();
            //Calculte remaining days excluding above date
        }

        private bool IsTimesheetSubmitted(DateTime date, EmployeeTimesheetInformation employeeTimesheetInformation )
        {
            throw new NotImplementedException();
        }

        private void AddEmployeeMonthlyTimesheetSubmissionStatus(EmployeeTimesheetInformation employeeTimesheetInformation)
        {
            throw new NotImplementedException();
            //This method will call data store to update employee's monthly timesheet submission status to database
        }
    }
}
