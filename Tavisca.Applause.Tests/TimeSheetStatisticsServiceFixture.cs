using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.Applause.Core.Services;
using Xunit;

namespace Tavisca.Applause.Tests
{
    public class TimeSheetStatisticsServiceFixture
    {
        [Fact]
        public  void GetTimeSheetStatistics_ShouldReturnTimesheetStatistics()
        {
            var mockTimeSheetStatisticsStore = new Mock<ITimesheetStatisticsRepository>();
            var timeSheetStatisticsService = new TimesheetStatisticsService(mockTimeSheetStatisticsStore.Object);
            var timeSheetStatistics =  timeSheetStatisticsService.GetTimeSheetStatistics();
            timeSheetStatistics.Should().NotBeNull();

        }
    }
}
