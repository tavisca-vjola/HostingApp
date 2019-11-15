using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using FluentAssertions;
using Tavisca.Applause.Cassandra;
using System.Threading.Tasks;
using Tavisca.Applause.Core;
using System.Linq;

namespace Tavisca.Applause.Tests
{
    public class EmployeeServiceFixture
    {
        private List<Employee> DummyEmployeeList;
        private PagedEmployeeList _emp;
     
        public EmployeeServiceFixture()
        {
             DummyEmployeeList= new List<Employee>
             {
                new Employee
                {
                    Id = "C231",
                    FirstName = "sai",
                    LastName = "vanka",
                    Tribe = "Enablement",
                    Squad = "app services",
                    ProfilePictureUrl = "image.jpeg",
                    IEnabled = true,
                    RewardStats = new EmployeeRewardsStats
                    {
                        EmployeeId = "c123",
                        Points = 100,
                        Kudos = 1,
                        ShoutOut = 2,
                        Annual = 1,
                        BronzeBadge = 21,
                        SilverBadge = 2,
                        GoldBadge = 1

                    }
                },
                new Employee
                {
                    Id = "C231",
                    FirstName = "sai",
                    LastName = "vanka",
                    Tribe = "Enablement",
                    Squad = "app services",
                    ProfilePictureUrl = "image.jpeg",
                    IEnabled = true,
                    RewardStats = new EmployeeRewardsStats
                    {
                        EmployeeId = "c123",
                        Points = 100,
                        Kudos = 1,
                        ShoutOut = 2,
                        Annual = 1,
                        BronzeBadge = 21,
                        SilverBadge = 2,
                        GoldBadge = 1

                    }
                },
                new Employee
                {
                    Id = "C231",
                    FirstName = "sai",
                    LastName = "vanka",
                    Tribe = "Enablement",
                    Squad = "app services",
                    ProfilePictureUrl = "image.jpeg",
                    IEnabled = true,
                    RewardStats = new EmployeeRewardsStats
                    {
                        EmployeeId = "c123",
                        Points = 100,
                        Kudos = 1,
                        ShoutOut = 2,
                        Annual = 1,
                        BronzeBadge = 21,
                        SilverBadge = 2,
                        GoldBadge = 1

                    }
                }

            };
        }

        [Fact]
        public async Task GetEmployeeById_Should_Return_An_Employee()
        {
            var mockEmployeeStore = new Mock<IEmployeeRepository>();
            mockEmployeeStore.Setup(c => c.GetEmployee("1123")).ReturnsAsync(new Employee {Id="1123"});
            var employeeService = new EmployeeService(mockEmployeeStore.Object);
            var employee = await employeeService.GetEmployeeById("1123");
            employee.Should().NotBeNull();
        }
       



        [Fact]
        public async Task GetEmployeeById_Should_Return_Null_If_Employee_Is_Not_Found()
        {
            var mockEmployeeStore = new Mock<IEmployeeRepository>();
            mockEmployeeStore.Setup(c => c.GetEmployee("1124")).ReturnsAsync((Employee)null);
            var employeeService = new EmployeeService(mockEmployeeStore.Object);
            var employee = await employeeService.GetEmployeeById("1124");
            employee.Should().BeNull();
        }
        
        [Fact]
        public async Task GetPeginatedEmployee_Should_Return_List_Of_Employees()
        {
            var dummyPaginatedEmployees = new PagedEmployeeList
            {
                EmployeeList = DummyEmployeeList,
                PageState = "xzz",

            };
            var mockEmployeeStore = new Mock<IEmployeeRepository>();
            mockEmployeeStore.Setup(c => c.GetPaginatedEmployee(6,"xyz")).ReturnsAsync(dummyPaginatedEmployees);
            var employeeService = new EmployeeService(mockEmployeeStore.Object);
            var peginatedEmployee = await employeeService.GetPaginatedEmployees("xyz",6);
            peginatedEmployee.Should().NotBeNull();
            Assert.Equal(dummyPaginatedEmployees.EmployeeList.Count, peginatedEmployee.EmployeeList.Count);
            Assert.Equal(dummyPaginatedEmployees.PageState,peginatedEmployee.PageState);
        }
        [Fact]
        public async Task GetPaginatedEmployee_Should_Return_null_for_invalid_input()
        {
            var dummyPaginatedEmployees = new PagedEmployeeList
            {
                EmployeeList = DummyEmployeeList,
                PageState = "xzz",

            };
            var mockEmployeeStore = new Mock<IEmployeeRepository>();
            mockEmployeeStore.Setup(c => c.GetPaginatedEmployee(6, "xyz")).ReturnsAsync(dummyPaginatedEmployees);
            var employeeService = new EmployeeService(mockEmployeeStore.Object);
            var peginatedEmployee = await employeeService.GetPaginatedEmployees("abc", 6);
            peginatedEmployee.Should().BeNull();
           
        }
        [Fact]
        public async Task GetTopPerformers_Should_return_list_of_employees()
        {
            var mockEmployeeStore = new Mock<IEmployeeRepository>();
            mockEmployeeStore.Setup(c => c.GetTopPerformerByPoint(5)).ReturnsAsync(DummyEmployeeList);
            var employeeService = new EmployeeService(mockEmployeeStore.Object);
            var employee = await employeeService.GetTopPerformersByPoint(5);
            employee.Should().NotBeNull();
            Assert.Equal(employee,DummyEmployeeList);
        }
        [Fact]
        public async Task GetEmployeeByFirstName_Should_return_null_if_name_not_found()
        {
            var mockEmployeeStore = new Mock<IEmployeeRepository>();
            mockEmployeeStore.Setup(c => c.GetEmployeeByFirstName("sai")).ReturnsAsync(DummyEmployeeList);
            var employeeService = new EmployeeService(mockEmployeeStore.Object);
            var employee = await employeeService.GetEmployeeByName("saivjm");
            employee.Should().BeNull();
            
        }
        [Fact]
        public async Task GetEmployeeByLastName_Should_return_null_if_name_not_found()
        {
            var mockEmployeeStore = new Mock<IEmployeeRepository>();
            mockEmployeeStore.Setup(c => c.GetEmployeeByLastName("sai")).ReturnsAsync(DummyEmployeeList);
            var employeeService = new EmployeeService(mockEmployeeStore.Object);
            var employee = await employeeService.GetEmployeeByName("saivjm");
            employee.Should().BeNull();

        }
       




    }
}
