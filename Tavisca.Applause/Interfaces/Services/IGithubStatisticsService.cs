using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IGithubStatisticsService
    {
        Task<GithubStatistics> GetGithubStatitics();
    }
}