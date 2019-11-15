using System.Collections.Generic;

namespace Tavisca.Applause
{
    public class EmployeePlatformMapping
    {
        public string EmpId { get; private set; }

        public List<EmployeePlatformIdentifier> EmployeePlatformIdentifiers = new List<EmployeePlatformIdentifier>();
    }
}
