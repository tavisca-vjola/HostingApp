using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Applause.Core.Services
{
    public class TimesheetStatisticsService:ITimeSheetStatisticsService
    {
        private readonly ITimesheetStatisticsRepository _timeSheetStatisticsRepository;
        public TimesheetStatisticsService(ITimesheetStatisticsRepository timeSheetStatisticsRepository)
        {
            _timeSheetStatisticsRepository = timeSheetStatisticsRepository;
        }

        public async Task<List<TimeSheetStatistics>> GetTimeSheetStatistics()
        {
            return await _timeSheetStatisticsRepository.GetTimeSheetStatistics();
        }
    }
}
