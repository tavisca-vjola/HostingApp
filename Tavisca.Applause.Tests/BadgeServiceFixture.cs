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
    public class BadgeServiceFixture
    {
        readonly EmployeeBadge EmployeeBadge = new EmployeeBadge
        {
            Badge = new Badge
            {
                Name = "ghj"
            },
            DateTime = DateTime.Now,
            EmployeeId = "1121"

        };

        PagedEmployeeBadgeList PagedEmployeeBadge = new PagedEmployeeBadgeList();
        
        public BadgeServiceFixture()
        {

            PagedEmployeeBadge.Badges = new List<EmployeeBadge> { EmployeeBadge };
            PagedEmployeeBadge.PageState = "xzz";
        
        }

        [Fact]
        public async Task GetRecentWinnersAsync_Should_Return_Recent_Badge_Winners()
        {
            
            var mockBageStore = new Mock<IEmployeeBadgeRepository>();
            var mockEmployeeStore = new Mock<IEmployeeRepository>();
            mockBageStore.Setup(c => c.GetRecentBadgeWinners("one", 5)).ReturnsAsync(PagedEmployeeBadge);
            mockEmployeeStore.Setup(c => c.GetEmployee("1123")).ReturnsAsync(It.IsAny<Employee>);
            var BadgeService = new BadgeService(mockBageStore.Object, mockEmployeeStore.Object);
            var badges = await BadgeService.GetRecentBadgeWinners("one", 5);
            BadgeService.Should().NotBeNull();
        }

        
    }
}
