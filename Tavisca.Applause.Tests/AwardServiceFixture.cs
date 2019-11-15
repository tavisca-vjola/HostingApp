using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Moq;
using Tavisca.Applause.Cassandra;
using Tavisca.Applause.Core.Services;
using System.Threading.Tasks;

namespace Tavisca.Applause.Tests
{
    public class AwardServiceFixture
    {
        
        private List<Award> _awards = new List<Award>();
        private List<Employee> _employees = new List<Employee>();
        public AwardServiceFixture( )
        {
            _awards.Add(new Award
            {
                Description = "dhdhd",
                EmployeeId="1132",
                Id="1",
                Month=03,
                Year=2019,
                Name="Monthly",
                Type="Kudos"

            });

            _employees.Add(new Employee
            {
                Id="1132",
                FirstName="Tanu",
                LastName="Sharma",

            });
          
        }
        
        [Fact]
        public async  void GetAnnualAwards_should_return_Annual_Awards()
        {
            
            var mockAwardStore = new Mock<IAwardsRepository>();
            var mockEmployeeStore = new Mock<IEmployeeRepository>();
            mockAwardStore.Setup(c => c.GetAnnualAwards(2019)).ReturnsAsync(_awards);
            mockEmployeeStore.Setup(c=>c.GetEmployee(_awards[0].EmployeeId)).ReturnsAsync(_employees[0]);
            var awardService = new AwardService(mockAwardStore.Object, mockEmployeeStore.Object);
            var awards = await awardService.GetAnnualAwards(2019);
            awards.Should().NotBeNull();
            Assert.Equal(_awards[0].Id,awards[0].Awards.Id);
            Assert.Equal(_awards[0].EmployeeId, awards[0].Employee.Id);

            

        }
        [Fact]
        public async Task GetMonthlyAwards_should_return_monthlyAwards()
        {


            var mockAwardStore = new Mock<IAwardsRepository>();
            var mockEmployeeStore = new Mock<IEmployeeRepository>();
            mockAwardStore.Setup(c => c.GetMonthlyAwards("kudos", 1, 2019)).ReturnsAsync(_awards);
            var awardService = new AwardService(mockAwardStore.Object, mockEmployeeStore.Object);
            mockEmployeeStore.Setup(c => c.GetEmployee(_awards[0].EmployeeId)).ReturnsAsync(_employees[0]);
            var awards = await awardService.GetMonthlyAwards("kudos", 1, 2019);
            awards.Should().NotBeNull();
            Assert.Equal(_awards[0].Id, awards[0].Awards.Id);
            Assert.Equal(_awards[0].EmployeeId, awards[0].Employee.Id);


        }
        [Fact]
        public async Task GetAnnualAwards_should_return_null_for_invalid_data()
        {
            var mockAwardStore = new Mock<IAwardsRepository>();
            var mockEmployeeStore = new Mock<IEmployeeRepository>();
            mockAwardStore.Setup(c => c.GetAnnualAwards(2019)).ReturnsAsync(_awards);
            mockEmployeeStore.Setup(c => c.GetEmployee(_awards[0].EmployeeId)).ReturnsAsync(_employees[0]);
            var awardService = new AwardService(mockAwardStore.Object, mockEmployeeStore.Object);
            var awards = await awardService.GetAnnualAwards(2015);
            awards.Should().BeNull();
            

        }
        [Fact]
        public async Task GetMonthly_awards_should_return_null_for_invalid_data()
        {
            var mockAwardStore = new Mock<IAwardsRepository>();
            var mockEmployeeStore = new Mock<IEmployeeRepository>();
            mockAwardStore.Setup(c => c.GetMonthlyAwards("kudos", 1, 2019)).ReturnsAsync(_awards);
            mockEmployeeStore.Setup(c => c.GetEmployee(_awards[0].EmployeeId)).ReturnsAsync(_employees[0]);
            var awardService = new AwardService(mockAwardStore.Object, mockEmployeeStore.Object);
            var awards = await awardService.GetMonthlyAwards("kudos", 1, 220231);
            awards.Should().BeNull();


        }
        [Fact]
        public async Task Get_award_of_employee_should_return_award_list_for_particular_employee()
        {
            var pagedAwardList = new PagedAwardList
            {
                PageState = "xzz",
                Awards = _awards
            };
            var mockAwardStore = new Mock<IAwardsRepository>();
            var mockEmployeeStore = new Mock<IEmployeeRepository>();
            mockAwardStore.Setup(c => c.GetAwardsByEmployeeId("1121","xyz",2)).ReturnsAsync(pagedAwardList);
            mockEmployeeStore.Setup(c => c.GetEmployee(_awards[0].EmployeeId)).ReturnsAsync(_employees[0]);
            var awardService = new AwardService(mockAwardStore.Object, mockEmployeeStore.Object);
            var awards = await awardService.GetAwardsOfAnEmployee("1121","xyz",2);
            awards.Should().NotBeNull();

        }
        [Fact]
        public async Task Get_award_of_employee_should_return_null_for_invalid_input()
        {
           
            var mockAwardStore = new Mock<IAwardsRepository>();
            var mockEmployeeStore = new Mock<IEmployeeRepository>();
            mockAwardStore.Setup(c => c.GetAwardsByEmployeeId("1144", "xyz", 2)).ReturnsAsync((PagedAwardList)null);
            mockEmployeeStore.Setup(c => c.GetEmployee(_awards[0].EmployeeId)).ReturnsAsync(_employees[0]);
            var awardService = new AwardService(mockAwardStore.Object, mockEmployeeStore.Object);
            var awards = await awardService.GetAwardsOfAnEmployee("1144", "xyz", 2);
            awards.Should().BeNull();

        }



    }
}
