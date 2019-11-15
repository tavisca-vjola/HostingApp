using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tavisca.Applause.Cassandra;
using System.Linq;
using Tavisca.Applause.Core.Validators;

namespace Tavisca.Applause.Core
{
    public class EmployeeService : IEmployeeService
    {
       private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;

        }
        
       

        public async Task<Employee> GetEmployeeById(string id)
        {
            return await _employeeRepository.GetEmployee(id);
        }

        public async Task<PagedEmployeeList> GetPaginatedEmployees(string pageState,int pageSize)
        {
            return await _employeeRepository.GetPaginatedEmployee(pageSize,pageState);

        }

        public async Task<List<Employee>> GetTopPerformersByPoint(int limit)
        {
            return await _employeeRepository.GetTopPerformerByPoint(limit);
        }

        public async Task<PagedEmployeeList> GetEmployeeByName(string input)
        {
            var employeeListByFirstName = (await _employeeRepository.GetEmployeeByFirstName(input));
            var employeeListByLastName = (await _employeeRepository.GetEmployeeByLastName(input));
            if (employeeListByFirstName != null && employeeListByLastName != null)
            {
                var employeeList = employeeListByFirstName.Concat(employeeListByLastName).ToList();

                return new PagedEmployeeList
                {
                    EmployeeList = employeeList,
                    PageState = null

                };
            }
            return null;
            
           
            
        }
        
    }
}
