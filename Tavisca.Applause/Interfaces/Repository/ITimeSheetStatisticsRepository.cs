using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface ITimesheetStatisticsRepository
    {
        Task<List<TimeSheetStatistics>> GetTimeSheetStatistics();
    }
}
