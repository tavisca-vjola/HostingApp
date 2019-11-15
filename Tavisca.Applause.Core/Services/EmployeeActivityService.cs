using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Applause.Core.Services
{
    public class EmployeeActivityService : IEmployeeActivityService
    {
        private readonly IEmployeeActivityRepository _employeeActivityRepository;
        public EmployeeActivityService(IEmployeeActivityRepository employeeActivityRepository)
        {
            _employeeActivityRepository = employeeActivityRepository;
        }

        

        public async Task<PagedActivity> GetActivityByEmployeeId(string id, string pageState, int pageSize)
        {
            return await _employeeActivityRepository.GetActivities(id, pageState, pageSize);
        }
    }
}
