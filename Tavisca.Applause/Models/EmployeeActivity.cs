using System;

namespace Tavisca.Applause
{
    public class EmployeeActivity
    {
        public string EmployeeId { get; set; }
        public string ActivityType { get; set; }
        public DateTime DateTime { get; set; }
        public Activity Activity { get; set; }
    }
}
