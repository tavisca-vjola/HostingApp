using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tavisca.Applause.Cassandra
{
    public class MockAwardsStore : IAwardsRepository
    {
        private List<Award> _awardList = new List<Award>
        {
            new Award{
                Id="1",
                EmployeeId="1121",
                Type="monthly",
                Description="sai is very hard working and passionate about his work. Did excellent work in CAR CAPI development and Kong implementation so that clients can migrate smoothly on the new platform. Keep it up the good work!!!.",
                Year=2018,
                Month=12,
                Name="kudos"
                
            },
            new Award
            {
                Id="2",
                EmployeeId="1121",
                Type="monthly",
                Description="sai is very hard working and passionate about his work. Did excellent work in CAR CAPI development and Kong implementation so that clients can migrate smoothly on the new platform. Keep it up the good work!!!.",
                Year=2019,
                Month=11,
                Name="shoutout"
                
            },

            new Award
            {
                Id="3",
                EmployeeId="1121",
                Type="monthly",
                Description="sai is very hard working and passionate about his work. Did excellent work in CAR CAPI development and Kong implementation so that clients can migrate smoothly on the new platform. Keep it up the good work!!!.",
                Year=2019,
                Month=10,
                Name="shoutout"
                
            },
            new Award
            {
                Id="4",
                EmployeeId="1121",
                Type="annual",
                Description="sai is very hard working and passionate about his work. Did excellent work in CAR CAPI development and Kong implementation so that clients can migrate smoothly on the new platform. Keep it up the good work!!!.",
                Year=2019,
                Month=10,
                Name="Whizz Kid"
            },

            new Award{
                Id="5",
                EmployeeId="1122",
                Type="annual",
                Description="Tanmay has delivered very important pieces of functionalities for multi-ticketing like fan-out and facets generation. He also played a key role in ensuring high unit testing coverage for the entire initiative. He has been very active in planning and managing team bonding activities. It’s great to have you in the team, keep up the good work!!!",
                Year=2018,
                Month=10,
                Name="best team player"
            },
            new Award
            {
                Id="6",
                EmployeeId="1122",
                Type="monthly",
                Description="Tanmay has delivered very important pieces of functionalities for multi-ticketing like fan-out and facets generation. He also played a key role in ensuring high unit testing coverage for the entire initiative. He has been very active in planning and managing team bonding activities. It’s great to have you in the team, keep up the good work!!!",
                Year=2019,
                Month=11,
                Name="shoutout"
            },
             new Award
            {
                Id="7",
                EmployeeId="1122",
                Type="monthly",
                Description="Tanmay has delivered very important pieces of functionalities for multi-ticketing like fan-out and facets generation. He also played a key role in ensuring high unit testing coverage for the entire initiative. He has been very active in planning and managing team bonding activities. It’s great to have you in the team, keep up the good work!!!",
                Year=2019,
                Month=11,
                Name="shoutout"
            },

              new Award
            {
                Id="8",
                EmployeeId="1122",
                Type="monthly",
                Description="Tanmay has delivered very important pieces of functionalities for multi-ticketing like fan-out and facets generation. He also played a key role in ensuring high unit testing coverage for the entire initiative. He has been very active in planning and managing team bonding activities. It’s great to have you in the team, keep up the good work!!!",
                Year=2019,
                Month=11,
                Name="Kudos"
            },
               new Award
            {
                Id="9",
                EmployeeId="1122",
                Type="monthly",
                Description="Tanmay has delivered very important pieces of functionalities for multi-ticketing like fan-out and facets generation. He also played a key role in ensuring high unit testing coverage for the entire initiative. He has been very active in planning and managing team bonding activities. It’s great to have you in the team, keep up the good work!!!",
                Year=2019,
                Month=11,
                Name="kudos"
            },
            new Award{
                Id="10",
                EmployeeId="1123",
                Type="monthly",
                Description="subhranshu has joined the team recently and has very soon grown into her role. He took ownership of Wasbi POC which will be  used for phase-wise roll-out for multi-ticket and completed several other user stories. He also spends lot of additional effort to learn the existing Nextgen eco-system .Apart from his contributions on multi-ticketing project, he has been very active in planning and coordinating the team bonding activities. Keep up the great work!",
                Year=2019,
                Month=11,
                Name="kudos"
            },
            new Award{
                Id="11",
                EmployeeId="1123",
                Type="monthly",
                Description="subhranshu has joined the team recently and has very soon grown into her role. He took ownership of Wasbi POC which will be  used for phase-wise roll-out for multi-ticket and completed several other user stories. He also spends lot of additional effort to learn the existing Nextgen eco-system .Apart from his contributions on multi-ticketing project, he has been very active in planning and coordinating the team bonding activities. Keep up the great work!",
                Year=2019,
                Month=11,
                Name="shoutout"
            },
            new Award{
                Id="12",
                EmployeeId="1123",
                Type="monthly",
                Description="subhranshu has joined the team recently and has very soon grown into her role. He took ownership of Wasbi POC which will be  used for phase-wise roll-out for multi-ticket and completed several other user stories. He also spends lot of additional effort to learn the existing Nextgen eco-system .Apart from his contributions on multi-ticketing project, he has been very active in planning and coordinating the team bonding activities. Keep up the great work!",
                Year=2019,
                Month=9,
                Name="shoutout"
            },
            new Award{
                Id="13",
                EmployeeId="1123",
                Type="annual",
                Description="subhranshu has joined the team recently and has very soon grown into her role. He took ownership of Wasbi POC which will be  used for phase-wise roll-out for multi-ticket and completed several other user stories. He also spends lot of additional effort to learn the existing Nextgen eco-system .Apart from his contributions on multi-ticketing project, he has been very active in planning and coordinating the team bonding activities. Keep up the great work!",
                Year=2019,
                Month=10,
                Name="best mentor"
            },
            new Award{
                Id="14",
                EmployeeId="1124",
                Type="monthly",
                Description="In the month of May/June - we have implemented Sabre on NextGen Platform and within next month we got notification of sunset of the same set of API's. Sundesh lead that activity efficiently and  completed re-writing of complete Connector within stipulated deadline with addressing almost all unknowns observed while implementation. Keep up the good work :)",
                Year=2019,
                Month=11,
                Name="shououts"
            },
            new Award{
                Id="15",
                EmployeeId="1124",
                Type="monthly",
                Description="In the month of January/February - we have implemented Sabre on NextGen Platform and within next month we got notification of sunset of the same set of API's. Sundesh lead that activity efficiently and  completed re-writing of complete Connector within stipulated deadline with addressing almost all unknowns observed while implementation. Keep up the good work :)",
                Year=2019,
                Month=2,
                Name="shououts"
            },
            new Award{
                Id="16",
                EmployeeId="1124",
                Type="monthly",
                Description="Sundesh shows immense sense of ownership and handled the all QA activities single handedly while migration Kenobi to NextGen Platform. Good test coverage is one of the best thing in the migration of CAPI Clients. CAPI Client migration is a bit tedious task than expected and he lives up to it. Keep up the good work :) ",
                Year=2019,
                Month=01,
                Name="kudos"
            },
            new Award{
                Id="17",
                EmployeeId="1125",
                Type="monthly",
                Description="Riddima means to rise. As per her name her rising day by day in the world of CAPI and OneConnect and become one most trustworthy team player. She is one of the instrumental member in migrating the Hotel CAPI Engine on NextGen Platform. Keep up the good work :).",
                Year=2019,
                Month=02,
                Name="kudos"
                
            },

            new Award{
                Id="18",
                EmployeeId="1125",
                Type="monthly",
                Description="Riddima means to rise. As per her name her rising day by day in the world of CAPI and OneConnect and become one most trustworthy team player. She is one of the instrumental member in migrating the Hotel CAPI Engine on NextGen Platform. Keep up the good work :).",
                Year=2019,
                Month=07,
                Name="kudos"

            },
             
             new Award{
                 Id="19",
                EmployeeId="1125",
                Type="annual",
                Description="Riddima has done a commendable work in testing at the time of Flight Product client launch activity. Her ability to identify corner cases while testing helped team to capture the bugs in early phase of client launch. She has done an exceptional work in client launch team; her intensity and the depth of testing coverage has gone a long way in building confidence for any client launch. Keep up the good work! ",
                Year=2019,
                Month=02,
                Name="Wiz kid"
            },
             new Award{
                Id="20",
                EmployeeId="1126",
                Type="monthly",
                Description="Rupika is very proactive in every aspect related to her work. She has shown high degree of ownership and understanding in Multi Ticket feature for Checkout. We are greatly delighted at your shared sense of team spirit and hard work that have been the leading light to many successful releases in Checkout features squad. Your extended support to mentor the freshers is much appreciated! Kudos to you Rupika!! Keep it up",
                Year=2019,
                Month=10,
                Name="kudos"
            },
             new Award{
                Id="21",
                EmployeeId="1127",
                Type="monthly",
                Description="omkar joined a bit late on Multi ticket project, but he was the fastest to get a command on it. Thanks for helping Checkout features squad to certify committed work items, when the additional QA capacity was needed. Kudos for using TDD for remove waive of charges implementation , tried to follow tdd approach for future developments also and spread TDD awareness and culture in current working squad.",
                Year=2019,
                Month=03,
                Name="kudos"
            },
             new Award{
                Id="22",
                EmployeeId="1127",
                Type="monthly",
                Description="omkar joined a bit late on Multi ticket project, but he was the fastest to get a command on it. Thanks for helping Checkout features squad to certify committed work items, when the additional QA capacity was needed. Kudos for using TDD for remove waive of charges implementation , tried to follow tdd approach for future developments also and spread TDD awareness and culture in current working squad.",
                Year=2019,
                Month=04,
                Name="shouout"
            },
             new Award{
                 Id="23",
                EmployeeId="1128",
                Type="monthly",
                Description="It was really your hard work and dedication that helped to achieve CAPI integration with Cart in a tight deadline. Thanks for your extended support on holiday(Dussehra) for configuring required program for Multi ticket demo on production. Kudos for creating actionable grafana dashboard for cart engine. Your attention to details makes a lot of difference in your work. We really appreciate your commitment to excellence! Keep up the good work !!",
                Year=2019,
                Month=01,
                Name="kudos"
            },
             new Award{
                 Id="24",
                EmployeeId="1128",
                Type="monthly",
                Description="It was really your hard work and dedication that helped to achieve CAPI integration with Cart in a tight deadline. Thanks for your extended support on holiday(Dussehra) for configuring required program for Multi ticket demo on production. Kudos for creating actionable grafana dashboard for cart engine. Your attention to details makes a lot of difference in your work. We really appreciate your commitment to excellence! Keep up the good work !!",
                Year=2019,
                Month=05,
                Name="shoutout"
            },

             new Award{
                 Id="25",
                EmployeeId="1129",
                Type="monthly",
                Description="He is one of the focused and well managed person in any challenging situation in checkout. He takes complete ownership of what comes his way and makes sure things keep moving. He is a great mentor and enables the team to meet the targets with high quality. He pushed himself beyond the boundaries and actively participated in the discovery phase to identify the items that should fall in roadmap and guiding team to move speedily in right direction. We appreciate the mentoring he has done for the other team members. Kudos to you Vikram and keep it up!!!",
                Year=2019,
                Month=04,
                Name="kudos"
            },
              new Award{
                  Id="26",
                EmployeeId="1129",
                Type="monthly",
                Description="He is one of the focused and well managed person in any challenging situation in checkout. He takes complete ownership of what comes his way and makes sure things keep moving. He is a great mentor and enables the team to meet the targets with high quality. He pushed himself beyond the boundaries and actively participated in the discovery phase to identify the items that should fall in roadmap and guiding team to move speedily in right direction. We appreciate the mentoring he has done for the other team members. Kudos to you Vikram and keep it up!!!",
                Year=2019,
                Month=10,
                Name="shoutout"
            },

             new Award{
                 Id="27",
                EmployeeId="1130",
                Type="monthly",
                Description="Saurabh always keeps his behavior cool and calm despite of pressure. He is great person to have in the team. Even with all his workload in Vikings squad, he is approachable to support checkout squad one for analyzing clops and incident. His sense of ownership and responsibility is appreciated! Kudos to you for guiding each squad member in taking decision and always available to help them in getting job done before deadlines. Great Job Saurabh!!",
                Year=2019,
                Month=02,
                Name="kudos"
            },
              new Award{
                 Id="28",
                EmployeeId="1130",
                Type="monthly",
                Description="Saurabh always keeps his behavior cool and calm despite of pressure. He is great person to have in the team. Even with all his workload in Vikings squad, he is approachable to support checkout squad one for analyzing clops and incident. His sense of ownership and responsibility is appreciated! Kudos to you for guiding each squad member in taking decision and always available to help them in getting job done before deadlines. Great Job Saurabh!!",
                Year=2019,
                Month=08,
                Name="shoutout"
            },
             new Award{
                 Id="29",
                EmployeeId="1131",
                Type="monthly",
                Description="Swarnesh is a great mentor and enables the team to meet the targets with high quality. His level of addressing concerns and his product-knowledge makes him a valuable asset to the team. Sagar has done an impressive job, wherein he has been fixing odd-time CLOPS with completing his deliverable on time. Kudos to you for guiding and encouraging each squad member in decision making. Great Job Swarnesh!!",
                Year=2019,
                Month=03,
                Name="kudos"
            },
             new Award{
                 Id="30",
                EmployeeId="1131",
                Type="monthly",
                Description="Swarnesh is a great mentor and enables the team to meet the targets with high quality. His level of addressing concerns and his product-knowledge makes him a valuable asset to the team. Sagar has done an impressive job, wherein he has been fixing odd-time CLOPS with completing his deliverable on time. Kudos to you for guiding and encouraging each squad member in decision making. Great Job Swarnesh!!",
                Year=2019,
                Month=04,
                Name="shoutout"
            }


        };
    

        public async Task<Award> AddAward(Award award)
        {
            if(award !=null)
                _awardList.Add(award);
            return award;
        }

        public async Task<PagedAwardList> GetAwardsByEmployeeId(string employeeId, string pageState,int pageSize)
        {

            List<string> pageStateList = new List<string>() { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            List<Award> awardList;
            if (pageState == null)
            {
                awardList= (_awardList.FindAll(award => award.EmployeeId == employeeId)).Take(pageSize).ToList();
                pageState = pageStateList[0];
            }
            else
            {
                int index = pageStateList.FindIndex(x => x == pageState);
                awardList= (_awardList.FindAll(award => award.EmployeeId == employeeId)).Skip((index + 1) * pageSize - 1).Take(pageSize).ToList();
                if (awardList[awardList.Count - 1].Id == _awardList[_awardList.Count - 1].Id)
                   pageState = null;
                else
                    pageState = pageStateList[index + 1];

            }

            return new PagedAwardList
            {
                Awards = awardList,
                PageState = pageState,
                
            };
        }


        public async Task<List<Award>> GetAnnualAwards(int year)
        {
            return _awardList.FindAll(award => award.Year == year && award.Type.Equals("annual", StringComparison.InvariantCultureIgnoreCase));
        }

        public async Task<List<Award>> GetMonthlyAwards(string awardType, int month, int year)
        {
            if (awardType != null)
            {
                return _awardList.FindAll(award => award.Year == year && award.Month == month && award.Name.Equals(awardType, StringComparison.InvariantCultureIgnoreCase));
            }
            else
                return null;
        }

        public async Task<Award> UpdateAward(Award award)
        {
            if (award != null)
            {
                int index = _awardList.FindIndex(a => a.EmployeeId == award.EmployeeId);
                _awardList.RemoveAt(index);
                _awardList.Add(award);
            }

            return award;
            
        }

    }
}
