using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Moq;
using FluentAssertions;
using Tavisca.Applause.Core.Services;
using Xunit;
using System.Linq;
namespace Tavisca.Applause.Tests
{
    public class RulesFixture
    {
        List<PlatformRule> PlatformRules;
        List<BadgesRule> BadgeRules;
        public RulesFixture()
        {
            BadgeRules = new List<BadgesRule>
            {
                new BadgesRule
                {
                    PlatformName="3",
                    BadgeType="Gold",
                    Description="To achieve gold badge you have to reach minimum of 5000 points and later this can be coverted into bounty points",

                },
                 new BadgesRule
                {
                    PlatformName="3",
                    BadgeType="silver",
                    Description="To achieve silver badge you have to reach minimum of 5000 points and later this can be coverted into bounty points",

                },
                  new BadgesRule
                {
                    PlatformName="3",
                    BadgeType="bronze",
                    Description="To achieve bronze badge you have to reach minimum of 5000 points and later this can be coverted into bounty points",

                }, new BadgesRule
                {
                    PlatformName="3",
                    BadgeType="Gold",
                    Description="To achieve gold badge you have to reach minimum of 5000 points and later this can be coverted into bounty points",

                }


            };
            PlatformRules = new List<PlatformRule>
            {
                new PlatformRule
                {
                    PlatformName="1",
                    RuleName="Daily",
                    Description="If you fill timesheets daily you have can achieve upto 100 points montly, and by doing this you can achieve some badges",
                    Points=200
                },
                new PlatformRule
                {
                    PlatformName="2",
                    RuleName="Weekly",
                    Description="If you fill timesheets daily you have can achieve upto 100 points montly, and by doing this you can achieve some badges",
                    Points=200
                },


            };
        }
        [Fact]
        public async void  GetplatformRules_should_not_be_null()
        {
            var mockRules = new Mock<IPlatformRuleRepository>();
            mockRules.Setup(c => c.GetAllPlatformRules()).ReturnsAsync(PlatformRules);
            mockRules.Should().NotBeNull();

        }
        [Fact]
        public async void GetplatformRules_should_return_all_platformRules()
        {
            var mockRules = new Mock<IPlatformRuleRepository>();
            var mockRules1 = new Mock<IBadgeRulesRepository>();
            mockRules.Setup(c => c.GetAllPlatformRules()).ReturnsAsync(PlatformRules);
            var ruleService = new RuleService(mockRules.Object,mockRules1.Object);
            var platform = await ruleService.GetPlatformRules();
            Assert.Equal(platform, PlatformRules);


        }
        
        [Fact]
        public async void GetBadgeRules_should_return_all_BadgesRules()
        {
            var mockRules = new Mock<IPlatformRuleRepository>();
            var mockRules1 = new Mock<IBadgeRulesRepository>();
            mockRules1.Setup(c => c.GetAllBadgeRules()).ReturnsAsync(BadgeRules);
            var ruleService = new RuleService(mockRules.Object, mockRules1.Object);
            var platform = await ruleService.GetBadgeRules();
            Assert.Equal(BadgeRules,platform);


        }
        [Fact]
        public async void GetBadgeRules_should_not_return_null()
        {
           
            var mockRules1 = new Mock<IBadgeRulesRepository>();
            mockRules1.Setup(c => c.GetAllBadgeRules()).ReturnsAsync(BadgeRules);
            mockRules1.Should().NotBeNull();

        }




    }
}
