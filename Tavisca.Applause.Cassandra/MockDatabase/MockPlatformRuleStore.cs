using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Applause.Cassandra
{
    public class MockPlatformRuleStore : IPlatformRuleRepository
    {
        private List<PlatformRule> _platformRules;
        public MockPlatformRuleStore()
        {
            _platformRules = new List<PlatformRule>
            {
                new PlatformRule
                {
                    PlatformName="Github",
                    RuleName="PR Review",
                    Description="2 Points for PR review with comments",
                    Points=2
                },
                new PlatformRule
                {
                    PlatformName="Time Sheet",
                    RuleName="Daily filling",
                    Description="1 Point for Filling Timesheet Daily",
                    Points=1
                },

                new PlatformRule
                {
                    PlatformName="Time Sheet",
                    RuleName="Montly Submission",
                    Description="5 points for Submitting on time",
                    Points=5
                },


            };
        }





        public async Task<List<PlatformRule>> GetAllPlatformRules()
        {
            return _platformRules;
        }

    }
}
