using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Applause.Cassandra
{
    public class MockEmployeeRewardsStats : IEmployeeRewardsStatsRepository
    {
        private List<EmployeeRewardsStats> _employeesList= new List<EmployeeRewardsStats>();

        public MockEmployeeRewardsStats()
        {

            _employeesList = new List<EmployeeRewardsStats> {
                new EmployeeRewardsStats
                {
                         EmployeeId="1121",
                        Points=100,
                        Kudos=1,
                        ShoutOut=2,
                        Annual=1,
                        BronzeBadge=4,
                        SilverBadge=0,
                        GoldBadge=0


                },
                 new EmployeeRewardsStats
                {
                         Points=250,
                       EmployeeId="1122",
                       Annual=1,
                        Kudos=7,
                        ShoutOut=2,
                        BronzeBadge=0,
                        SilverBadge=1,
                        GoldBadge=0


                },

                   new EmployeeRewardsStats{
                       Points=500,
                        EmployeeId="1123",
                        Annual=3,
                        Kudos=1,
                        ShoutOut=2,
                        BronzeBadge=0,
                        SilverBadge=2,
                        GoldBadge=0


                     },
                   new EmployeeRewardsStats
                   {
                       Points=100,
                        EmployeeId="1124",
                         Annual=2,
                        Kudos=1,
                        ShoutOut=2,
                        BronzeBadge=0,
                        SilverBadge=4,
                        GoldBadge=0

                   },
                   new EmployeeRewardsStats
                   {
                        Points=2500,
                        EmployeeId="1125",
                        Annual=1,
                        Kudos=2,
                        ShoutOut=0,
                        BronzeBadge=0,
                        SilverBadge=0,
                        GoldBadge=1

                   },
                   new EmployeeRewardsStats
                   {
                       Points=1000,
                        EmployeeId="1126",
                        Annual=0,
                        Kudos=1,
                        ShoutOut=0,
                        BronzeBadge=0,
                        SilverBadge=4,
                        GoldBadge=0
                   },
                   new EmployeeRewardsStats
                   {
                       Points=500,
                        EmployeeId="1127",
                        Annual=0,
                        Kudos=1,
                        ShoutOut=1,
                        BronzeBadge=0,
                        SilverBadge=2,
                        GoldBadge=0
                   },
                   new EmployeeRewardsStats
                   {
                        Points=525,
                        EmployeeId="1128",
                        Annual=0,
                        Kudos=1,
                        ShoutOut=1,
                        BronzeBadge=1,
                        SilverBadge=2,
                        GoldBadge=0
                   },
                   new EmployeeRewardsStats
                   {
                       Points=550,
                        EmployeeId="1129",
                        Annual=0,
                        Kudos=1,
                        ShoutOut=1,
                        BronzeBadge=2,
                        SilverBadge=2,
                        GoldBadge=0
                   },
                   new EmployeeRewardsStats
                   {
                       Points=100,
                        EmployeeId="1130",
                        Annual=0,
                        Kudos=1,
                        ShoutOut=1,
                        BronzeBadge=4,
                        SilverBadge=2,
                        GoldBadge=0
                   }
                


        };
        }

        public async Task AddPoints(string employeeId, int points)
        {
            var stats = await GetEmployeeRewards(employeeId);
            if (stats != null)
                stats.Points += points;
        }

        public async Task<EmployeeRewardsStats> GetEmployeeRewards(string employeeId)
        {
            return _employeesList.Find(emp => emp.EmployeeId == employeeId);
        }

        public async Task<List<EmployeeRewardsStats>> GetEmployeeRewards()
        {
            return _employeesList;
        }

        public async Task<List<EmployeeRewardsStats>> GetRewardsByBadgeType(string badgeType)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBadgeCounter(string employeeId, string existingBadgeType, CounterOperation couterOperation, int numberOfBadges)
        {
            throw new NotImplementedException();
        }





    }
}
