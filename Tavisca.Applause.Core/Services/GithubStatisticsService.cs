using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Applause.Core.Services
{
    public class GithubStatisticsService : IGithubStatisticsService
    {
        private readonly IGithubStatisticsRepository _githubStatisticsRepository;
        public GithubStatisticsService(IGithubStatisticsRepository githubStatisticsRepository)
        {
            _githubStatisticsRepository = githubStatisticsRepository;
        }

        public async Task<GithubStatistics> GetGithubStatitics()
        {
            return await _githubStatisticsRepository.GetGithubStatitics();
        }
    }
}
