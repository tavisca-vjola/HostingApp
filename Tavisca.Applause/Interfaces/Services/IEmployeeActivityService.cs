using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IEmployeeActivityService
    {
        Task<PagedActivity> GetActivityByEmployeeId(string id, string pageState, int pageSize);

    }
}
