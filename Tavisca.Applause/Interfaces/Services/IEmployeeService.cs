using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tavisca.Applause
{
    public interface IEmployeeService
    {
        Task<PagedEmployeeList> GetPaginatedEmployees(string pageStatus,int pageSize);
        Task<Employee> GetEmployeeById(string id);
        Task<PagedEmployeeList> GetEmployeeByName(string input);
        Task<List<Employee>> GetTopPerformersByPoint(int limit);


    }
}
