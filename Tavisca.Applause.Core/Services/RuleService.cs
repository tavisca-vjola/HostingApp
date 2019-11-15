using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tavisca.Applause.Cassandra;

namespace Tavisca.Applause.Core.Services
{
    public class RuleService : IRulesService
    {
        private readonly IPlatformRuleRepository _platformRulesRepository;
        private readonly IBadgeRulesRepository _badgesRulesRepository;
        public RuleService(IPlatformRuleRepository platformRulesRepository, IBadgeRulesRepository badgeRulesRepository)
        {
            _platformRulesRepository = platformRulesRepository;
            _badgesRulesRepository = badgeRulesRepository;
        }
        public async Task<List<BadgesRule>> GetBadgeRules()
        {
            return await _badgesRulesRepository.GetAllBadgeRules();
        }

        public async Task<List<PlatformRule>> GetPlatformRules()
        {
            return await _platformRulesRepository.GetAllPlatformRules();
        }
    }
}
