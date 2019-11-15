using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Moq;
using Tavisca.Applause.Cassandra;
using Tavisca.Applause.Core.Services;


namespace Tavisca.Applause.Tests
{
    public class GithubStatisticsServiceFixture
    {
        

        [Fact]
        public void GetGithubStatistics_ShouldReturnGithubStatistics()
        {
            var mockGithubStatisticsStore = new Mock<IGithubStatisticsRepository>();
            var githubStatisticsService = new GithubStatisticsService(mockGithubStatisticsStore.Object);
            var githubStatistics = githubStatisticsService.GetGithubStatitics();
            githubStatistics.Should().NotBeNull();

        }
        
    }
}
