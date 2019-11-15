using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tavisca.Applause.Cassandra;

namespace Tavisca.Applause.Core.Services
{
    public class AwardService : IAwardService
    {
        private readonly IAwardsRepository _awardRepository;
        private readonly IEmployeeRepository _employeesRepository;
       
        public List<EmployeeAwardDetail> EmployeeAwardDetails;
        

        public AwardService(IAwardsRepository awardRepository, IEmployeeRepository employeesRepository)
        {
            this._awardRepository = awardRepository;
            _employeesRepository = employeesRepository;
            EmployeeAwardDetails = new List<EmployeeAwardDetail>();
           
        }

        public  async Task<List<EmployeeAwardDetail>>GetAnnualAwards( int year)
        {
            var awards = await _awardRepository.GetAnnualAwards(year);
            if (awards == null)
                return null;
           
            foreach(var award in awards)
            {
                if (award != null)
                {

                    var employee = await _employeesRepository.GetEmployee(award.EmployeeId);

                    if (employee != null)
                    {
                        var emp = new EmployeeAwardDetail
                        {
                            Employee = employee,
                            Awards = award
                        };
                        EmployeeAwardDetails.Add(emp);
                    }
                }
            }
            return EmployeeAwardDetails;

           
        }

        public async Task<PagedAwardList> GetAwardsOfAnEmployee(string id, string pageState, int pageSize)
        {
            return await _awardRepository.GetAwardsByEmployeeId(id,pageState, pageSize);
        }

        public async Task<List<EmployeeAwardDetail>> GetMonthlyAwards(string awardName, int month, int year)
        {
           var awards=await _awardRepository.GetMonthlyAwards(awardName,month,year);
            if (awards == null)
                return null;
            foreach (var award in awards)
            {
                if (award != null)
                {
                    var employee = await _employeesRepository.GetEmployee(award.EmployeeId);

                    var emp = new EmployeeAwardDetail
                    {
                        Employee = employee,
                        Awards = award
                    };

                    EmployeeAwardDetails.Add(emp);

                }
            }
            return EmployeeAwardDetails;

        }


    }
}
