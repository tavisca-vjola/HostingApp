using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IEmployeeActivityRepository
    {
        Task<EmployeeActivity> AddActivity(EmployeeActivity employeeActivity);
        Task<PagedActivity> GetActivities(string employeeId, string pageState, int pageSize);
        Task<EmployeeActivity> UpdateActivity(EmployeeActivity employeeActivity);
        Task<bool> DeleteActivity(string activityId);
    }
}
