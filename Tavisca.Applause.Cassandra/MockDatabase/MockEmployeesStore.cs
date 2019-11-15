using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Applause.Cassandra
{
    public class MockEmployeesStore : IEmployeeRepository
    {
        private List<Employee> _employeeList = new List<Employee>
        {
            new Employee
            {
                    Id="1121",
                    FirstName="Sai",
                    LastName="Vanka",
                    Tribe="GCE",
                    Squad="Support",
                    ProfilePictureUrl="/assets/images/users/sai.jpg",
                    IEnabled=true,
                    Email="vjola@tavisca.com",
                    RewardStats=new EmployeeRewardsStats{
                        EmployeeId="1121",
                        Points=100,
                        Kudos=1,
                        ShoutOut=2,
                        Annual=1,
                        BronzeBadge=4,
                        SilverBadge=0,
                        GoldBadge=0

                    }
            },
                 new Employee
                 {
                    Id="1122",
                    FirstName="Tanmay",
                    LastName="Sharma",
                    Tribe="Flights",
                    Squad="Api",
                    ProfilePictureUrl="/assets/images/users/tanmay.jpg",
                    IEnabled=true,
                    Email="tsharma@tavisca.com",
                    RewardStats=new EmployeeRewardsStats{
                        Points=250,
                       EmployeeId="1122",
                       Annual=1,
                        Kudos=2,
                        ShoutOut=2,
                        BronzeBadge=0,
                        SilverBadge=1,
                        GoldBadge=0

                    }
                 },
                  new Employee
                  {
                    Id="1123",
                    FirstName="Subharansu",
                    LastName="Panda",
                    Tribe="ORXe",
                    Squad="App Services",
                    ProfilePictureUrl="/assets/images/users/panda.jpg",
                    IEnabled=true,
                    Email="spanda@tavisca.com",
                    RewardStats=new EmployeeRewardsStats{
                        Points=500,
                        EmployeeId="1123",
                        Annual=1,
                        Kudos=1,
                        ShoutOut=2,
                        BronzeBadge=0,
                        SilverBadge=2,
                        GoldBadge=0

                    }
                  },
                  new Employee
                  {
                    Id="1124",
                    FirstName="Sundesh",
                    LastName="Chawla",
                    Tribe="CHAI",
                    Squad="Training",
                    ProfilePictureUrl="/assets/images/users/sundesh.jpg",
                    IEnabled=true,
                    Email="schawla@tavisca.com",
                    RewardStats=new EmployeeRewardsStats{
                        Points=100,
                        EmployeeId="500",
                        Annual=0,
                        Kudos=1,
                        ShoutOut=2,
                        BronzeBadge=0,
                        SilverBadge=2,
                        GoldBadge=0
                    }
                  },
                  new Employee
                  {
                    Id="1125",
                    FirstName="Riddima",
                    LastName="Mittal",
                    Tribe="Checkout",
                    Squad="Training",
                    ProfilePictureUrl="/assets/images/users/riddhima.jpg",
                    IEnabled=true,
                    Email="rmittal@tavisca.com",
                    RewardStats=new EmployeeRewardsStats{
                        Points=2500,
                        EmployeeId="1125",
                        Annual=1,
                        Kudos=2,
                        ShoutOut=0,
                        BronzeBadge=0,
                        SilverBadge=0,
                        GoldBadge=1
                    }
                  },


                  new Employee
                  {
                    Id="1126",
                    FirstName="Rupika   ",
                    LastName="Pawar",
                    Tribe="Bizops",
                    Squad="Training",
                    ProfilePictureUrl="/assets/images/users/rupika.jpg",
                    IEnabled=true,
                    Email="rpawar@tavisca.com",
                    RewardStats=new EmployeeRewardsStats{
                        Points=250,
                        EmployeeId="1126",
                        Annual=0,
                        Kudos=1,
                        ShoutOut=0,
                        BronzeBadge=0,
                        SilverBadge=1,
                        GoldBadge=0
                    }
                  },
                  new Employee
                  {
                    Id="1127",
                    FirstName="Omkar",
                    LastName="Deshpande",
                    Tribe="CHAI",
                    Squad="Insurance",
                    ProfilePictureUrl="/assets/images/users/omkar.jpg",
                    IEnabled=true,
                    Email="odeshpande@tavisca.com",
                    RewardStats=new EmployeeRewardsStats{
                        Points=500,
                        EmployeeId="1127",
                        Annual=0,
                        Kudos=1,
                        ShoutOut=1,
                        BronzeBadge=0,
                        SilverBadge=2,
                        GoldBadge=0
                    }
                  },
                   new Employee
                  {
                    Id="1128",
                    FirstName="Aman    ",
                    LastName="Khullar",
                    Tribe="Enablement",
                    Squad="People productivity",
                    ProfilePictureUrl="/assets/images/users/aman.jpg",
                    IEnabled=true,
                    Email="akhullar@tavisca.com",
                    RewardStats=new EmployeeRewardsStats{
                        Points=525,
                        EmployeeId="1128",
                        Annual=0,
                        Kudos=1,
                        ShoutOut=1,
                        BronzeBadge=1,
                        SilverBadge=2,
                        GoldBadge=0
                    }
                  },
                   new Employee
                  {
                    Id="1129",
                    FirstName="Vikram",
                    LastName="Shah",
                    Tribe="Enablement",
                    Squad="App-services",
                    ProfilePictureUrl="/assets/images/users/vikram.jpg",
                    IEnabled=true,
                    Email="vshah@tavisca.com",
                    RewardStats=new EmployeeRewardsStats{
                        Points=550,
                        EmployeeId="1129",
                        Annual=0,
                        Kudos=1,
                        ShoutOut=1,
                        BronzeBadge=2,
                        SilverBadge=2,
                        GoldBadge=0
                    }
                  },
                   new Employee
                  {
                    Id="1130",
                    FirstName="Saurabh",
                    LastName="Narhe",
                    Tribe="COD",
                    Squad="Spiderman",
                    ProfilePictureUrl="/assets/images/users/saurabh-narhe.jpg",
                    IEnabled=true,
                    Email="snarhe@tavisca.com",
                    RewardStats=new EmployeeRewardsStats{
                        Points=500,
                        EmployeeId="1130",
                        Annual=0,
                        Kudos=1,
                        ShoutOut=1,
                        BronzeBadge=0,
                        SilverBadge=2,
                        GoldBadge=0
                    }
                  },
                    new Employee
                  {
                    Id="1131",
                    FirstName="Swarnesh",
                    LastName="Mattapalli",
                    Tribe="Flights",
                    Squad="Superman",
                    ProfilePictureUrl="/assets/images/users/swarnesh.jpg",
                    IEnabled=true,
                    Email="smattapalli@tavisca.com",
                    RewardStats=new EmployeeRewardsStats{
                        Points=1025,
                        EmployeeId="1131",
                        Annual=0,
                        Kudos=1,
                        ShoutOut=1,
                        BronzeBadge=1,
                        SilverBadge=4,
                        GoldBadge=0
                    }
                    },
                     new Employee
                  {
                    Id="1132",
                    FirstName="Nikhil",
                    LastName="Chabukswar",
                    Tribe="Enablement",
                    Squad="Superman",
                    ProfilePictureUrl="/assets/images/users/1.jpg",
                    IEnabled=true,
                    Email="smattapalli@tavisca.com",
                    RewardStats=new EmployeeRewardsStats{
                        Points=24,
                        EmployeeId="1131",
                        Annual=0,
                        Kudos=0,
                        ShoutOut=0,
                        BronzeBadge=0,
                        SilverBadge=0,
                        GoldBadge=0
                    }
                    },
                     new Employee
                  {
                    Id="1133",
                    FirstName="Nishant",
                    LastName="Kumar",
                    Tribe="GCE",
                    Squad="API",
                    ProfilePictureUrl="/assets/images/users/2.jpg",
                    IEnabled=true,
                    Email="smattapalli@tavisca.com",
                    RewardStats=new EmployeeRewardsStats{
                        Points=21,
                        EmployeeId="1131",
                        Annual=0,
                        Kudos=0,
                        ShoutOut=0,
                        BronzeBadge=0,
                        SilverBadge=0,
                        GoldBadge=0
                    }
                    },

                      new Employee
                  {
                    Id="1134",
                    FirstName="Aman",
                    LastName="Chaudhury",
                    Tribe="Training",
                    Squad="Java",
                    ProfilePictureUrl="/assets/images/users/3.jpg",
                    IEnabled=true,
                    Email="smattapalli@tavisca.com",
                    RewardStats=new EmployeeRewardsStats{
                        Points=20,
                        EmployeeId="1131",
                        Annual=0,
                        Kudos=0,
                        ShoutOut=0,
                        BronzeBadge=0,
                        SilverBadge=0,
                        GoldBadge=0
                    }
                    },
                       new Employee
                  {
                    Id="1135",
                    FirstName="Rajesh",
                    LastName="Raikwar",
                    Tribe="Enablement",
                    Squad="App Services",
                    ProfilePictureUrl="/assets/images/users/4.jpg",
                    IEnabled=true,
                    Email="smattapalli@tavisca.com",
                    RewardStats=new EmployeeRewardsStats{
                        Points=20,
                        EmployeeId="1131",
                        Annual=0,
                        Kudos=0,
                        ShoutOut=0,
                        BronzeBadge=0,
                        SilverBadge=0,
                        GoldBadge=0
                    }
                    },
                       new Employee
                  {
                    Id="1136",
                    FirstName="Jai",
                    LastName="Soni",
                    Tribe="Enablement",
                    Squad="App Services",
                    ProfilePictureUrl="/assets/images/users/5.jpg",
                    IEnabled=true,
                    Email="smattapalli@tavisca.com",
                    RewardStats=new EmployeeRewardsStats{
                        Points=20,
                        EmployeeId="1131",
                        Annual=0,
                        Kudos=0,
                        ShoutOut=0,
                        BronzeBadge=0,
                        SilverBadge=0,
                        GoldBadge=0
                    }
                    },
                       new Employee
                  {
                    Id="1137",
                    FirstName="Smriti",
                    LastName="Srivastav",
                    Tribe="Enablement",
                    Squad="App Services",
                    ProfilePictureUrl="/assets/images/users/8.jpg",
                    IEnabled=true,
                    Email="smattapalli@tavisca.com",
                    RewardStats=new EmployeeRewardsStats{
                        Points=20,
                        EmployeeId="1131",
                        Annual=0,
                        Kudos=0,
                        ShoutOut=0,
                        BronzeBadge=0,
                        SilverBadge=0,
                        GoldBadge=0
                    }
                    },
                       new Employee
                  {
                    Id="1138",
                    FirstName="Smriti",
                    LastName="Prasad",
                    Tribe="Enablement",
                    Squad="App Services",
                    ProfilePictureUrl="/assets/images/users/8.jpg",
                    IEnabled=true,
                    Email="smattapalli@tavisca.com",
                    RewardStats=new EmployeeRewardsStats{
                        Points=20,
                        EmployeeId="1131",
                        Annual=0,
                        Kudos=0,
                        ShoutOut=0,
                        BronzeBadge=0,
                        SilverBadge=0,
                        GoldBadge=0
                    }
                    },
                       new Employee
                  {
                    Id="1139",
                    FirstName="Ashwarya",
                    LastName="Gandhe",
                    Tribe="Enablement",
                    Squad="App Services",
                    ProfilePictureUrl="/assets/images/users/7.jpg",
                    IEnabled=true,
                    Email="smattapalli@tavisca.com",
                    RewardStats=new EmployeeRewardsStats{
                        Points=20,
                        EmployeeId="1131",
                        Annual=0,
                        Kudos=0,
                        ShoutOut=0,
                        BronzeBadge=0,
                        SilverBadge=0,
                        GoldBadge=0
                    }
                    },
                       new Employee
                  {
                    Id="1140",
                    FirstName="Natasha",
                    LastName="Jain",
                    Tribe="Enablement",
                    Squad="App Services",
                    ProfilePictureUrl="/assets/images/users/6.jpg",
                    IEnabled=true,
                    Email="smattapalli@tavisca.com",
                    RewardStats=new EmployeeRewardsStats{
                        Points=20,
                        EmployeeId="1131",
                        Annual=0,
                        Kudos=0,
                        ShoutOut=0,
                        BronzeBadge=0,
                        SilverBadge=0,
                        GoldBadge=0
                    }
                    },
                       new Employee
                  {
                    Id="1141",
                    FirstName="Priti",
                    LastName="Chandan",
                    Tribe="Enablement",
                    Squad="App Services",
                    ProfilePictureUrl="/assets/images/users/8.jpg",
                    IEnabled=true,
                    Email="smattapalli@tavisca.com",
                    RewardStats=new EmployeeRewardsStats{
                        Points=20,
                        EmployeeId="1131",
                        Annual=0,
                        Kudos=0,
                        ShoutOut=0,
                        BronzeBadge=0,
                        SilverBadge=0,
                        GoldBadge=0
                    }
                    }


        };
        private List<string> _pageStatusList = new List<string>() { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
        

        public Task<Employee> AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEmployee(string employeeId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Employee>> GetEmployeesByTribe(string tribeName)
        {
            return _employeeList.FindAll(emp => emp.Tribe == tribeName);

        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            return _employeeList;
        }

        public async Task<List<Employee>> GetEmployeeByFirstName(string firstName)
        {
            var employeesSearchedByFirstName = _employeeList.FindAll(emp => emp.FirstName.Equals(firstName, StringComparison.InvariantCultureIgnoreCase));
            return employeesSearchedByFirstName;
        }

        public async Task<List<Employee>> GetEmployeeByLastName(string lastName)
        {
            var employeesSearchedByLastName = _employeeList.FindAll(emp => emp.LastName.Equals(lastName, StringComparison.InvariantCultureIgnoreCase));
            return employeesSearchedByLastName;
        }

        public async Task<Employee> GetEmployee(string employeeId)
        {
            return _employeeList.Find(emp => emp.Id == employeeId);
        }

        public async Task<PagedEmployeeList> GetPaginatedEmployee(int pageSize, string pageState)
        {
            PagedEmployeeList emp = new PagedEmployeeList();
            if (pageState == null || pageState == "null" )
            {
                emp.EmployeeList = _employeeList.Take(pageSize).ToList();
                emp.PageState = _pageStatusList[0];
            }
            else
            {
                int index = _pageStatusList.FindIndex(x => x == pageState);
                emp.EmployeeList = _employeeList.Skip((index + 1) * pageSize).Take(pageSize).ToList();
                if (emp.EmployeeList[emp.EmployeeList.Count-1].Id==_employeeList[_employeeList.Count-1].Id)
                    emp.PageState = null;
                else
                    emp.PageState = _pageStatusList[index + 1];

            }
            return emp;
        }

        

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            if (employee != null)
            {
                var existingEmployee = await GetEmployee(employee.Id);
                if (existingEmployee != null)
                {
                    _employeeList.Remove(existingEmployee);
                    _employeeList.Add(employee);
                }
                else
                    throw new Exception($"Employee not found with name '{employee.FirstName} + {employee.LastName}'");
            }
            return employee;


        }
        public async Task<List<Employee>> GetTopPerformerByPoint(int limit)
        {
            var topPerformers = _employeeList.Take(limit).ToList();
            return topPerformers;

        }


    }


}
