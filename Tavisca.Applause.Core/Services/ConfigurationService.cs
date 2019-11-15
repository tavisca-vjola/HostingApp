using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Tavisca.Applause.Cassandra;

namespace Tavisca.Applause.Core.Services
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly IConfigurationRepository _configurationRepository;
        public ConfigurationService(IConfigurationRepository configurationRepository)
        {
            _configurationRepository = configurationRepository;
        }
        public async Task<Configuration> AddConfiguration(Configuration configuration)
        {
            return await _configurationRepository.AddConfiguration(configuration);
        }

        public Task<bool> DeleteConfiguration(string key)
        {
            throw new NotImplementedException();
        }

        public async Task<Configuration> GetConfiguration(string key)
        {
            return await _configurationRepository.GetConfiguration(key);
        }

        public async Task<Configuration> UpdateConfiguration(Configuration configuration)
        {
           return await _configurationRepository.UpdateConfiguration(configuration);
        }
    }
}
