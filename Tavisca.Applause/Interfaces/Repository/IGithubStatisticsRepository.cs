            using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IGithubStatisticsRepository
    {
        Task<GithubStatistics> GetGithubStatitics();
    }
}
