using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IActivityRepository
    {
        Task<List<Activity>> GetAllActivitiesByPlatform();
        Task<Activity> GetActivityByName(string name);
        Task<Activity> UpdateActivity(Activity activity);
        Task<Activity> AddActivity(Activity activity);
    }
}
