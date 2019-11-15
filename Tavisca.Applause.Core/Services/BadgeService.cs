using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;


namespace Tavisca.Applause.Core.Services
{
    public class BadgeService : IBadgeService
    {
        private readonly IEmployeeBadgeRepository _employeeBadgeRepository;
        private readonly IEmployeeRepository _employeeRepository;

        public BadgeService(IEmployeeBadgeRepository employeeBadgeRepository, IEmployeeRepository employeeRepository)
        {
            _employeeBadgeRepository = employeeBadgeRepository;
            _employeeRepository = employeeRepository;
        }

        public Task<Badge> AddBadge(Badge badge)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteBadge(string type)
        {
            throw new NotImplementedException();
        }

        public Task<List<Badge>> GetAllBadges()
        {
            throw new NotImplementedException();
        }

        public Task<Badge> GetBadge(string type)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedEmployeeBadgeMapping> GetRecentBadgeWinners(string pageState, int pageSize)
        {
            var employeeBadgeMappings = new List<EmployeeBadgeMapping>();
            var pagedEmployeeBadges =  await _employeeBadgeRepository.GetRecentBadgeWinners(pageState,pageSize);
            if(pagedEmployeeBadges != null && pagedEmployeeBadges.Badges.Count > 0)
            {
                foreach(var employeeBadge in pagedEmployeeBadges.Badges)
                {
                    var employee = await _employeeRepository.GetEmployee(employeeBadge.EmployeeId);
                    if (employee != null)
                        employeeBadgeMappings.Add(new EmployeeBadgeMapping(employee, employeeBadge));
                }
            }
            var pagedEmployeeBadgeMapping = new PagedEmployeeBadgeMapping
            {

                EmployeeBadgeMappings = employeeBadgeMappings,
                PageState = pagedEmployeeBadges.PageState
            };
            return pagedEmployeeBadgeMapping;
                
        }

        public async Task<Dictionary<string, List<Employee>>> GetRecentWinnersByBadgeType(int limit)
        {
            
            Dictionary<string, List<Employee>> dictionary = new Dictionary<string, List<Employee>>();
            List<Employee> employees = new List<Employee>();
            var goldResult = (await _employeeBadgeRepository.GetRecentWinnersByBadgeType("gold", limit));
            var silverResult = (await _employeeBadgeRepository.GetRecentWinnersByBadgeType("silver", limit));
            var bronzeResult = (await _employeeBadgeRepository.GetRecentWinnersByBadgeType("bronze", limit));
            employees= await GetEmployeesForBadgeDetails(goldResult);          
            dictionary["gold"] = employees;
            employees = await GetEmployeesForBadgeDetails(silverResult);
            dictionary["silver"] = employees;
            employees = await GetEmployeesForBadgeDetails(bronzeResult);
            dictionary["bronze"] = employees;
            return dictionary;
        }

        private async Task<List<Employee>> GetEmployeesForBadgeDetails(List<EmployeeBadge> employeeBadgeList)
        {
            List<Employee> employees= new List<Employee>();
            foreach (EmployeeBadge employeeBadge in employeeBadgeList)
            {
                var employee = await _employeeRepository.GetEmployee(employeeBadge.EmployeeId);
                if (employee != null)
                    employees.Add(employee);
            }

            return employees;

        }

        public Task<Badge> UpdateBadge(Badge badge)
        {
            throw new NotImplementedException();
        }

    }
}
