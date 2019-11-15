using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause.Cassandra.Interfaces
{
    public interface ITimesheetActivityRepository
    {
        Task<TimesheetActivity> AddRecord(TimesheetActivity employeeActivity);
        Task<PagedTimesheetActivity> GetRecords(string employeeId, int year, int month);//Employee's Monthly DAta
        Task<TimesheetActivity> GetRecord(string employeeId, int year, int month, int day);//Employee's Daily Data
        Task<List<TimesheetActivity>> GetRecord(int year, int month, int day, List<string> employeeIds);// Tribewise Daily Data
        Task<List<TimesheetActivity>> GetRecord(int year, int month, List<string> employeeIds);// Tribewise monthly
        Task<TimesheetActivity> UpdateRecord(TimesheetActivity employeeActivity);
        Task<bool> DeleteRecord(string activityId);
        Task<List<PagedTimesheetActivity>> GetAllActivities(int year, int month);
    }
}
