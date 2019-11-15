using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause.Cassandra
{
    public class MockConfigurationStore : IConfigurationRepository
    {
        private List<Configuration> _configurations= new List<Configuration>();
        public MockConfigurationStore()
        {
            _configurations = new List<Configuration>
            {
                new Configuration
                {
                    Key="github",
                    Value="token"
                },

                new Configuration
                {
                    Key="Jira",
                    Value="token"
                },

                new Configuration
                {
                    Key="chatops",
                    Value="token"
                }

            };
        }

        public async Task<Configuration> AddConfiguration(Configuration configuration)
        {
            if (configuration != null)
            {
                _configurations.Add(configuration);
                
            }
            return configuration;

        }

        public async Task<bool> DeleteConfiguration(string key)
        {
            var configuration = await GetConfiguration(key);
            if (configuration == null)
                return false;
            else
            {
                _configurations.Remove(configuration);
                return true;
            }
                
        }

        public async Task<List<Configuration>> GetAllConfigurations()
        {
            return _configurations;
        }

        public async  Task<Configuration> GetConfiguration(string key)
        {
            return _configurations.Find(configuration => configuration.Key == key);
        }

        public async Task<Configuration> UpdateConfiguration(Configuration configuration)
        {
            if (configuration != null)
            {
                var existingConfiguration = await GetConfiguration(configuration.Key);
                if (existingConfiguration != null)
                {
                    _configurations.Remove(existingConfiguration);
                    _configurations.Add(configuration);
                }
                else
                    throw new System.Exception($"No configuration found with key '{configuration.Key}'");
            }
            
            return configuration;
        }
    }
}
