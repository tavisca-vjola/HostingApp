using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Applause.Cassandra.MockDatabase
{
    public class MockPlatformStore : IPlatformRepository
    {
        private List<Platform> _platformList;
        public MockPlatformStore()
        {
            _platformList = new List<Platform>
            {
                new Platform
                {
                    Name="Github"
                },
                new Platform
                {
                    Name="TimeSheet"
                }
            };
        }
        
        public Task<bool> DeletePlatform(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Platform>> GetAllPlatforms()
        {
            return _platformList;
        }

        public async Task<Platform> GetPlatformByName(string name)
        {
            return _platformList.Find(platform => platform.Name == name);
        }

       

        public async Task<Platform> AddPlatform(Platform platform)
        {
            if (platform != null)
            {
                _platformList.Add(platform);
            }

           
            return platform;
        }

        public async Task<Platform> UpdatePlatform(Platform platform)
        {
            if (platform != null)
            {
                var existingPlatform = await GetPlatformByName(platform.Name);
                if (existingPlatform != null)
                {
                    _platformList.Remove(existingPlatform);
                    _platformList.Add(platform);
                }
            }
            return platform;
        }
    }
}
