using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IEmployeeBadgeRepository
    {
        Task<EmployeeBadge> AddBadge(EmployeeBadge employeeBadge);
        Task<PagedEmployeeBadgeList> GetBadges(string employeeId);
        Task<bool> DeleteBadges(EmployeeBadge employeeBadge);
        Task<EmployeeBadge> UpdateBadge(EmployeeBadge employeeBadge);
        Task<PagedEmployeeBadgeList> GetRecentBadgeWinners(string pageState, int pageSize);
        Task<List<EmployeeBadge>> GetRecentWinnersByBadgeType(string badgeType, int limit);
    }
}
