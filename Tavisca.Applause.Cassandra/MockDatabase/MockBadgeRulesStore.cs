using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause.Cassandra
{
    public class MockBadgeRulesStore : IBadgeRulesRepository
    {
        private List<BadgesRule> _badgeRules = new List<BadgesRule>();
        public MockBadgeRulesStore()
        {
            _badgeRules = new List<BadgesRule>
            {
                new BadgesRule
                {
                    PlatformName="Badge",
                    BadgeType="Gold",
                    Description="To achieve gold badge you have to achieve minimum of 10 Silver Badges",

                },
                 new BadgesRule
                {
                    PlatformName="Badge",
                    BadgeType="Silver",
                    Description="To achieve silver badge you have to achieve minimu of 10 Bronze Badges",

                },
                  new BadgesRule
                {
                    PlatformName="Badge",
                    BadgeType="bronze",
                    Description="To achieve bronze badge you have to reach minimum of 50 points",

                },


            };
        }

        public async Task<List<BadgesRule>> GetAllBadgeRules()
        {
            return _badgeRules;
        }


        public async Task<BadgesRule> GetBadgeRule(string name)
        {
            return _badgeRules.Find(badge => badge.PlatformName == name);
        }

        public async Task<BadgesRule> UpdateBadgeRule(BadgesRule badgeRule)
        {
            if (badgeRule != null)
            {
                var badge = _badgeRules.Find(badges => badges.PlatformName == badgeRule.PlatformName);
                _badgeRules.Remove(badge);
                _badgeRules.Add(badgeRule);
            }

            return badgeRule;

        }

        public async Task<BadgesRule> AddBadgeRule(BadgesRule rules)
        {
            if (rules != null)
                _badgeRules.Add(rules);
            return rules;
        }

    }
}
