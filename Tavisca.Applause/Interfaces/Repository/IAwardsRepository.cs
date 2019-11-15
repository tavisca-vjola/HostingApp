using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IAwardsRepository
    {
        Task<Award> AddAward(Award award);
        Task<PagedAwardList> GetAwardsByEmployeeId(string employeeId, string pageState,int pageSIze);
        Task<List<Award>> GetMonthlyAwards(string awardName, int year, int month);
        Task<List<Award>> GetAnnualAwards(int year);
    }
}
