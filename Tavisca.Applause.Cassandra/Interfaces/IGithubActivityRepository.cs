using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause.Cassandra.Interfaces
{
    public interface IGithubActivityRepository
    {
        Task<GithubActivity> AddRecord(GithubActivity employeeActivity);
        Task<PagedGithubActivity> GetRecord(string employeeId, int year, int month);
        Task<GithubActivity> UpdateRecord(GithubActivity employeeActivity);
        Task<bool> DeleteRecord(string activityId);
        Task<List<GithubActivity>> GetAllActivities(int year, int month);
        Task<int> GetTotalNumberOfGitActivities(int year, int month);
        Task<int> GetTotalNumberOfGitActivities(string employeeId);
    }
}
