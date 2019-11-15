using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IAwardService
    {
        Task<List<EmployeeAwardDetail>> GetMonthlyAwards(string awardName, int month, int year);
        Task<List<EmployeeAwardDetail>> GetAnnualAwards( int year);
        Task<PagedAwardList> GetAwardsOfAnEmployee(string employeeId, string pageState, int pageSize);
    }
}
