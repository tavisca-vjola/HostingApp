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
    public class ConfigurationServiceFixture
    {
        private List<Configuration> _configurations;
        private Configuration _configurationSingle= null;
        public ConfigurationServiceFixture()
        {
            _configurations = new List<Configuration>
            {
                new Configuration
                {
                    Key="github",
                    Value="helloworldeon"
                },
                new Configuration
                {
                    Key="jenkins",
                    Value="hello"
                }

            };
        }
        [Fact]
        public async Task AddConfiguration_should_return_configuraion_object_if_added()
        {
            var mockConfiguration = new Mock<IConfigurationRepository>();
            mockConfiguration.Setup(x => x.AddConfiguration(new Configuration { Key = "pluralsight", Value = "saivjm" })).ReturnsAsync(new Configuration { Key = "sai", Value = "vjm" });
            var configrationService = new ConfigurationService(mockConfiguration.Object);
            var result = configrationService.AddConfiguration(new Configuration { Key = "pluralsight", Value = "saivjm" });
            result.Should().NotBeNull();


        }
        [Fact]
        public async Task AddConfiguration_should_return_configuraion_object_if_null()
        {
            var mockConfiguration = new Mock<IConfigurationRepository>();
            mockConfiguration.Setup(x => x.AddConfiguration(new Configuration { Key = "pluralsight", Value = "saivjm" })).ReturnsAsync(new Configuration { Key = "sai", Value = "vjm" });
            var configrationService = new ConfigurationService(mockConfiguration.Object);
            var result = await configrationService.AddConfiguration(new Configuration { Key = "ind", Value = "indian" });
            result.Should().BeNull();
            //Assert.Equal(result, _configurationSingle);


        }
        [Fact]
        public async Task UpdateConfiguration_should_return_configuraion_object_if_exists()
        {
            var mockConfiguration = new Mock<IConfigurationRepository>();
            mockConfiguration.Setup(x => x.UpdateConfiguration(new Configuration { Key = "pluralsight", Value = "saivjm" })).ReturnsAsync(new Configuration { Key = "sai", Value = "vjm" });
            var configrationService = new ConfigurationService(mockConfiguration.Object);
            var result = configrationService.AddConfiguration(_configurationSingle);
            result.Should().NotBeNull();
            

        }
        [Fact]
        public async Task UpdateConfiguration_should_return_configuraion_object_if_null()
        {
            var mockConfiguration = new Mock<IConfigurationRepository>();
            mockConfiguration.Setup(x => x.UpdateConfiguration(new Configuration { Key = "pluralsight", Value = "saivjm" })).ReturnsAsync(new Configuration { Key = "sai", Value = "vjm" });
            var configrationService = new ConfigurationService(mockConfiguration.Object);
            var result = await configrationService.AddConfiguration(new Configuration { Key = "india", Value = "ipl" });
            result.Should().BeNull();
            Assert.Equal(result,_configurationSingle);


        }
    }
}
