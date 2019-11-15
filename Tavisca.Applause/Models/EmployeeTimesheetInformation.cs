using System;

namespace Tavisca.Applause
{
    public class EmployeeTimesheetInformation
    {
        public string EmployeeId { get; set; }
        public string UserName { get; set; }
        public string Tribe { get; set; }
        public string Squad { get; set; }
        public TimesheetMonthlySubmissionStatus TimesheetSubmissionStatus { get; set; }
        public DateTime Date { get; set; }
        public TimesheetDailySubmissionStatus TimesheetDailySubmissionStatus { get; set; }  
    }
}
