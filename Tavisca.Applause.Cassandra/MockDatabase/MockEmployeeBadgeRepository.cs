using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Applause.Cassandra
{
    public class MockEmployeeBadgeRepository : IEmployeeBadgeRepository
    {
        private List<EmployeeBadge> _employeeBadges= new List<EmployeeBadge>();
        public MockEmployeeBadgeRepository()
        {
            _employeeBadges = new List<EmployeeBadge>()
            {
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"
                        
                    },
                    DateTime=new DateTime(2019,11,5),
                    EmployeeId="1121",             

                },
                 new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,10,5),
                    EmployeeId="1122",

                },
                 new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,9,23),
                    EmployeeId="1123",

                },
                 new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,2,1),
                    EmployeeId="1125",

                },

                  new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,11,11),
                    EmployeeId="1126",

                },

                   new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,3,23),
                    EmployeeId="1129",

                },
                   new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,10,15),
                    EmployeeId="1131",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,1,5),
                    EmployeeId="1121",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,1,10),
                    EmployeeId="1121",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,1,18),
                    EmployeeId="1121",

                },
                
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,1,1),
                    EmployeeId="1122",

                },
               
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,3,1),
                    EmployeeId="1122",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,4,1),
                    EmployeeId="1122",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,5,1),
                    EmployeeId="1122",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Silver",
                        Type="Silver"

                    },
                    DateTime=new DateTime(2018,5,1),
                    EmployeeId="1122",

                },
                
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,2,1),
                    EmployeeId="1123",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,3,1),
                    EmployeeId="1123",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,4,1),
                    EmployeeId="1123",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,5,5),
                    EmployeeId="1123",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Silver",
                        Type="Silver"

                    },
                    DateTime=new DateTime(2018,5,5),
                    EmployeeId="1123",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,5,10),
                    EmployeeId="1123",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,6,1),
                    EmployeeId="1123",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,7,1),
                    EmployeeId="1123",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,8,1),
                    EmployeeId="1123",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,9,1),
                    EmployeeId="1123",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Silver",
                        Type="Silver"

                    },
                    DateTime=new DateTime(2018,9,1),
                    EmployeeId="1126",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,1,1),
                    EmployeeId="1124",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,2,1),
                    EmployeeId="1124",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,3,1),
                    EmployeeId="1124",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,4,1),
                    EmployeeId="1124",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,5,5),
                    EmployeeId="1124",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Silver",
                        Type="Silver"

                    },
                    DateTime=new DateTime(2018,5,5),
                    EmployeeId="1124",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,5,10),
                    EmployeeId="1124",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,6,1),
                    EmployeeId="1124",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,7,1),
                    EmployeeId="1124",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,8,1),
                    EmployeeId="1124",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,9,1),
                    EmployeeId="1124",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Silver",
                        Type="Silver"

                    },
                    DateTime=new DateTime(2018,9,1),
                    EmployeeId="1127",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,1,1),
                    EmployeeId="1125",

                },
                
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,3,1),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,4,1),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,5,5),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Silver",
                        Type="Silver"

                    },
                    DateTime=new DateTime(2018,5,5),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,5,10),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,6,1),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,7,1),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,8,1),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,9,1),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Silver",
                        Type="Silver"

                    },
                    DateTime=new DateTime(2018,9,1),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,10,1),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,11,1),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,12,1),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,1,1),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,1,15),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Silver",
                        Type="Silver"

                    },
                    DateTime=new DateTime(2019,1,15),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,1,31),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,2,10),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,2,21),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,3,15),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,3,23),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Silver",
                        Type="Silver"

                    },
                    DateTime=new DateTime(2018,3,23),
                    EmployeeId="1125",

                },

                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,3,30),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,4,15),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,4,21),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,5,15),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,5,23),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Silver",
                        Type="Silver"

                    },
                    DateTime=new DateTime(2018,5,23),
                    EmployeeId="1125",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Gold",
                        Type="Gold"

                    },
                    DateTime=new DateTime(2018,5,23),
                    EmployeeId="1125",

                },

               
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,4,15),
                    EmployeeId="1126",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,4,21),
                    EmployeeId="1126",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,5,15),
                    EmployeeId="1126",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,5,23),
                    EmployeeId="1126",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Silver",
                        Type="Silver"

                    },
                    DateTime=new DateTime(2018,5,23),
                    EmployeeId="1123",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,1,31),
                    EmployeeId="1127",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,2,10),
                    EmployeeId="1127",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,2,21),
                    EmployeeId="1127",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,3,15),
                    EmployeeId="1127",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,3,23),
                    EmployeeId="1127",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Silver",
                        Type="Silver"

                    },
                    DateTime=new DateTime(2018,3,23),
                    EmployeeId="1124",

                },

                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,3,30),
                    EmployeeId="1127",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,4,15),
                    EmployeeId="1127",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,4,21),
                    EmployeeId="1127",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,5,15),
                    EmployeeId="1127",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,5,23),
                    EmployeeId="1127",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Silver",
                        Type="Silver"

                    },
                    DateTime=new DateTime(2018,5,23),
                    EmployeeId="1127",

                },

                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,1,31),
                    EmployeeId="1128",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,2,10),
                    EmployeeId="1128",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,2,21),
                    EmployeeId="1128",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,3,15),
                    EmployeeId="1128",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,3,23),
                    EmployeeId="1128",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Silver",
                        Type="Silver"

                    },
                    DateTime=new DateTime(2018,3,23),
                    EmployeeId="1128",

                },

                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,3,30),
                    EmployeeId="1128",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,4,15),
                    EmployeeId="1128",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,4,21),
                    EmployeeId="1128",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,5,15),
                    EmployeeId="1128",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,5,23),
                    EmployeeId="1128",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Silver",
                        Type="Silver"

                    },
                    DateTime=new DateTime(2018,5,23),
                    EmployeeId="1128",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,5,31),
                    EmployeeId="1128",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,1,31),
                    EmployeeId="1129",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,2,10),
                    EmployeeId="1129",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,2,21),
                    EmployeeId="1129",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,3,15),
                    EmployeeId="1129",

                },
               
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Silver",
                        Type="Silver"

                    },
                    DateTime=new DateTime(2018,3,23),
                    EmployeeId="1129",

                },

                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,3,30),
                    EmployeeId="1129",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,4,15),
                    EmployeeId="1129",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,4,21),
                    EmployeeId="1129",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,5,15),
                    EmployeeId="1129",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,5,23),
                    EmployeeId="1129",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Silver",
                        Type="Silver"

                    },
                    DateTime=new DateTime(2018,5,23),
                    EmployeeId="1129",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,5,31),
                    EmployeeId="1129",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,5,31),
                    EmployeeId="1129",

                },

                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,1,31),
                    EmployeeId="1130",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,2,10),
                    EmployeeId="1130",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,2,21),
                    EmployeeId="1130",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,3,15),
                    EmployeeId="1130",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,3,23),
                    EmployeeId="1130",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Silver",
                        Type="Silver"

                    },
                    DateTime=new DateTime(2018,3,23),
                    EmployeeId="1130",

                },

                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,3,30),
                    EmployeeId="1130",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,4,15),
                    EmployeeId="1130",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,4,21),
                    EmployeeId="1130",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,5,15),
                    EmployeeId="1130",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,5,23),
                    EmployeeId="1130",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Silver",
                        Type="Silver"

                    },
                    DateTime=new DateTime(2018,5,23),
                    EmployeeId="1130",

                },

                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,3,30),
                    EmployeeId="1131",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,4,15),
                    EmployeeId="1131",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,4,21),
                    EmployeeId="1131",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2019,5,15),
                    EmployeeId="1131",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Bronze",
                        Type="Bronze"

                    },
                    DateTime=new DateTime(2018,5,23),
                    EmployeeId="1131",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Silver",
                        Type="Silver"

                    },
                    DateTime=new DateTime(2018,5,23),
                    EmployeeId="1131",

                },

                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Gold",
                        Type="Gold"

                    },
                    DateTime=new DateTime(2018,5,23),
                    EmployeeId="1131",

                },

                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Gold",
                        Type="Gold"

                    },
                    DateTime=new DateTime(2018,5,23),
                    EmployeeId="1129",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Gold",
                        Type="Gold"

                    },
                    DateTime=new DateTime(2018,5,23),
                    EmployeeId="1128",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Gold",
                        Type="Gold"

                    },
                    DateTime=new DateTime(2018,5,23),
                    EmployeeId="1130",

                },
                new EmployeeBadge
                {
                    Badge= new Badge()
                    {
                        IconUrl="uri",
                        Name="Gold",
                        Type="Gold"

                    },
                    DateTime=new DateTime(2018,5,23),
                    EmployeeId="1122",

                },

            };
            _employeeBadges = _employeeBadges.OrderByDescending(x => x.DateTime).ToList();


        }
        public Task<EmployeeBadge> AddBadge(EmployeeBadge employeeBadge)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteBadges(EmployeeBadge employeeBadge)
        {
            throw new NotImplementedException();
        }

        public Task<PagedEmployeeBadgeList> GetBadges(string employeeId)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedEmployeeBadgeList> GetRecentBadgeWinners(string pageState, int pageSize)
        {
            List<EmployeeBadge> employeeBadges;
            List<string> pageStatusList = new List<string>() { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            if (pageState == null)
            {
                employeeBadges = _employeeBadges.Take(pageSize).ToList();
                pageState = pageStatusList[0];
            }
            else
            {
                int index = pageStatusList.FindIndex(x => x == pageState);
                employeeBadges = _employeeBadges.Skip((index + 1) * pageSize).Take(pageSize).ToList();
                if (employeeBadges[employeeBadges.Count - 1].EmployeeId == _employeeBadges[_employeeBadges.Count - 1].EmployeeId)
                    pageState = null;
                else
                    pageState = pageStatusList[index + 1];
            }
            return new PagedEmployeeBadgeList
            {
                Badges= employeeBadges,
                PageState =pageState
            };
        }

        public async Task<List<EmployeeBadge>> GetRecentWinnersByBadgeType(string badgeType, int limit)
        {
            return _employeeBadges.FindAll(c => c.Badge.Type.Equals(badgeType, StringComparison.InvariantCultureIgnoreCase)).Take(limit).ToList();
        }

        public Task<EmployeeBadge> UpdateBadge(EmployeeBadge employeeBadge)
        {
            throw new NotImplementedException();
        }
    }
}
