using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface ITimesheetRepository
    {
        Task<EmployeeTimesheetInformation> AddEmployeeTimesheetInformation(EmployeeTimesheetInformation employeeTimesheetInformation);
        Task<List<EmployeeTimesheetInformation>> AddEmployeesTimesheetInformation(List<EmployeeTimesheetInformation> employeeTimesheetInformation);

        Task<EmployeeTimesheetReport> GetEmployeeTimesheetInformation(int year, int month, string empId);
        Task<List<EmployeeTimesheetReport>> GetTimesheetInformation(List<Employee> employeeIds);

    }
}
