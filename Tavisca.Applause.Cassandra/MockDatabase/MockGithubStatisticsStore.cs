using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Applause.Cassandra
{
    public class MockGithubStatisticsStore: IGithubStatisticsRepository
    {
        
        public async Task<GithubStatistics> GetGithubStatitics() => new GithubStatistics
        {
            
            NumberOfPRs = 1440,
            NumberOfPRsWithOutComments = 340,
            Date = DateTime.UtcNow,
            NumberOfPRsWithComments= 1100

        };


    }

}
