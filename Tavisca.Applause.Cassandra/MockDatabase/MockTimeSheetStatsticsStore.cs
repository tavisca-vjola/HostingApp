using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Applause.Cassandra
{
    public class MockTimeSheetStatsticsStore : ITimesheetStatisticsRepository
    {
        public async Task<List<TimeSheetStatistics>> GetTimeSheetStatistics() => new List<TimeSheetStatistics>
            {
                new TimeSheetStatistics
                {
                    TribeName="Enablement",
                    TotalNumberOfEmployees = 60,
                    NumberOfEmployeesFillingTimeSheet = 55,
                },

                new TimeSheetStatistics
                {
                    TribeName="CHAI",
                    TotalNumberOfEmployees = 123,
                    NumberOfEmployeesFillingTimeSheet = 90,
                },
                new TimeSheetStatistics
                {
                    TribeName="Checkout",
                    TotalNumberOfEmployees = 67,
                    NumberOfEmployeesFillingTimeSheet = 42,
                },
                new TimeSheetStatistics
                {
                    TribeName="BizOps",
                    TotalNumberOfEmployees = 32,
                    NumberOfEmployeesFillingTimeSheet = 23,
                },
                new TimeSheetStatistics
                {
                    TribeName="ORXe",
                    TotalNumberOfEmployees = 45,
                    NumberOfEmployeesFillingTimeSheet = 34,
                },
                new TimeSheetStatistics
                {
                    TribeName="Flights",
                    TotalNumberOfEmployees = 89,
                    NumberOfEmployeesFillingTimeSheet = 77,
                },

            };
    }
}
