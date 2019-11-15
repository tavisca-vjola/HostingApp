using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Applause.Cassandra
{
    public class MockEmployeeActivityStore : IEmployeeActivityRepository
    {
        private List<EmployeeActivity> _employeeActivities = new List<EmployeeActivity>();
        
        public MockEmployeeActivityStore()
        {
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1121",
                        ActivityType = "PR Review",
                        DateTime = new DateTime(2019,1,1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "Did_a_PR_Review",
                            DisplayName = "Did a PR Review",
                            IconUrl = "assests/images/users/githublogo.jpg",
                            Name = "Github",
                            Platform = "Github"
                    },
                }
            );
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1121",
                       ActivityType = "PR Review",
                       DateTime = new DateTime(2018, 12, 1),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "Did a PR Review",
                           DisplayName = "Did a PR Review",
                           IconUrl = "assests/images/users/githublogo.jpg",
                           Name = "Github",
                           Platform = "Github"
                       },
                   }
           );
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1121",
                       ActivityType = "TimeSheet",
                       DateTime = new DateTime(2018, 12, 1),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "Successfully submitted TimeSheet",
                           DisplayName = "Successfully submitted TimeSheet",
                           IconUrl = "assests/images/users/timesheet.jpg",
                           Name = "TimeSheet",
                           Platform = "TImeSheet"
                       },
                   }
           );
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1121",
                       ActivityType = "PR Review",
                       DateTime = new DateTime(2018, 11, 30),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "Did a PR Review",
                           DisplayName = "Did a PR Review",
                           IconUrl = "assests/images/users/githublogo.jpg",
                           Name = "Github",
                           Platform = "Github"
                       },
                   }
           );
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1121",
                       ActivityType = "PR Review",
                       DateTime = new DateTime(2018, 10, 2),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "Did a PR Review",
                           DisplayName = "Did a PR Review",
                           IconUrl = "assests/images/users/githublogo.jpg",
                           Name = "Github",
                           Platform = "Github"
                       },
                   }
           );
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1121",
                       ActivityType = "PR Review",
                       DateTime = new DateTime(2018, 10, 1),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "Did a PR Review",
                           DisplayName = "Did a PR Review",
                           IconUrl = "assests/images/users/githublogo.jpg",
                           Name = "Github",
                           Platform = "Github"
                       },
                   }
           ); _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1121",
                        ActivityType = "PR Review",
                        DateTime = new DateTime(2018, 9, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "Did a PR Review",
                            DisplayName = "Did a PR Review",
                            IconUrl = "assests/images/users/githublogo.jpg",
                            Name = "Github",
                            Platform = "Github"
                        },
                    }

            );
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1122",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 1, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    }
            );
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1122",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 1, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    }
            );
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1122",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 1, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    }
            );
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1122",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 1, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    }
            );
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1122",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 1, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    }
            );
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1122",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 1, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    }
            );
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1122",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 1, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    }
            );
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1122",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 1, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    }
            );
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1122",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 1, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    }
            );
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1123",
                        ActivityType = "PR Review",
                        DateTime = new DateTime(2019, 1, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "Did a PR review",
                            DisplayName = "Did a PR review",
                            IconUrl = "assests/images/users/githublogo.jpg",
                            Name = "github",
                            Platform = "github"
                        },
                    }
            );
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1123",
                        ActivityType = "PR Review",
                        DateTime = new DateTime(2019, 1, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "Did a PR review",
                            DisplayName = "Did a PR review",
                            IconUrl = "assests/images/users/githublogo.jpg",
                            Name = "github",
                            Platform = "github"
                        },
                    }
            );
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1123",
                        ActivityType = "PR Review",
                        DateTime = new DateTime(2019, 1, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "Did a PR review",
                            DisplayName = "Did a PR review",
                            IconUrl = "assests/images/users/githublogo.jpg",
                            Name = "github",
                            Platform = "github"
                        },
                    }
            );
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1123",
                        ActivityType = "PR Review",
                        DateTime = new DateTime(2019, 1, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "Did a PR review",
                            DisplayName = "Did a PR review",
                            IconUrl = "assests/images/users/githublogo.jpg",
                            Name = "github",
                            Platform = "github"
                        },
                    }
            );
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1123",
                        ActivityType = "PR Review",
                        DateTime = new DateTime(2019, 1, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "Did a PR review",
                            DisplayName = "Did a PR review",
                            IconUrl = "assests/images/users/githublogo.jpg",
                            Name = "github",
                            Platform = "github"
                        },
                    }
            );
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1123",
                        ActivityType = "PR Review",
                        DateTime = new DateTime(2019, 1, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "Did a PR review",
                            DisplayName = "Did a PR review",
                            IconUrl = "assests/images/users/githublogo.jpg",
                            Name = "github",
                            Platform = "github"
                        },
                    }
            );
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1123",
                        ActivityType = "PR Review",
                        DateTime = new DateTime(2019, 1, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "Did a PR review",
                            DisplayName = "Did a PR review",
                            IconUrl = "assests/images/users/githublogo.jpg",
                            Name = "github",
                            Platform = "github"
                        },
                    }
            );
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1123",
                        ActivityType = "PR Review",
                        DateTime = new DateTime(2019, 1, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "Did a PR review",
                            DisplayName = "Did a PR review",
                            IconUrl = "assests/images/users/githublogo.jpg",
                            Name = "github",
                            Platform = "github"
                        },
                    }
            );
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1123",
                        ActivityType = "PR Review",
                        DateTime = new DateTime(2019, 1, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "Did a PR review",
                            DisplayName = "Did a PR review",
                            IconUrl = "assests/images/users/githublogo.jpg",
                            Name = "github",
                            Platform = "github"
                        },
                    }
            );
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1123",
                        ActivityType = "PR Review",
                        DateTime = new DateTime(2019, 1, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "Did a PR review",
                            DisplayName = "Did a PR review",
                            IconUrl = "assests/images/users/githublogo.jpg",
                            Name = "github",
                            Platform = "github"
                        },
                    }
            );
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1124",
                        ActivityType = "TimeSheet",
                        DateTime = new DateTime(2019, 1, 17),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    }
            );
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1124",
                       ActivityType = "TimeSheet",
                       DateTime = new DateTime(2019, 1, 17),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "TimeSheet Submitted Successfully",
                           DisplayName = "Submitted time sheet",
                           IconUrl = "assests/images/users/timesheetlogo.jpg",
                           Name = "TimeSheet",
                           Platform = "TimeSheet"
                       },
                   }
           );
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1124",
                       ActivityType = "TimeSheet",
                       DateTime = new DateTime(2019, 1, 17),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "TimeSheet Submitted Successfully",
                           DisplayName = "Submitted time sheet",
                           IconUrl = "assests/images/users/timesheetlogo.jpg",
                           Name = "TimeSheet",
                           Platform = "TimeSheet"
                       },
                   }
           );
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1124",
                       ActivityType = "TimeSheet",
                       DateTime = new DateTime(2019, 1, 17),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "TimeSheet Submitted Successfully",
                           DisplayName = "Submitted time sheet",
                           IconUrl = "assests/images/users/timesheetlogo.jpg",
                           Name = "TimeSheet",
                           Platform = "TimeSheet"
                       },
                   }
           );
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1124",
                       ActivityType = "TimeSheet",
                       DateTime = new DateTime(2019, 1, 17),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "TimeSheet Submitted Successfully",
                           DisplayName = "Submitted time sheet",
                           IconUrl = "assests/images/users/timesheetlogo.jpg",
                           Name = "TimeSheet",
                           Platform = "TimeSheet"
                       },
                   }
           );
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1124",
                       ActivityType = "TimeSheet",
                       DateTime = new DateTime(2019, 1, 17),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "TimeSheet Submitted Successfully",
                           DisplayName = "Submitted time sheet",
                           IconUrl = "assests/images/users/timesheetlogo.jpg",
                           Name = "TimeSheet",
                           Platform = "TimeSheet"
                       },
                   }
           );
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1124",
                       ActivityType = "TimeSheet",
                       DateTime = new DateTime(2019, 1, 17),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "TimeSheet Submitted Successfully",
                           DisplayName = "Submitted time sheet",
                           IconUrl = "assests/images/users/timesheetlogo.jpg",
                           Name = "TimeSheet",
                           Platform = "TimeSheet"
                       },
                   }
           );
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1124",
                       ActivityType = "TimeSheet",
                       DateTime = new DateTime(2019, 1, 17),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "TimeSheet Submitted Successfully",
                           DisplayName = "Submitted time sheet",
                           IconUrl = "assests/images/users/timesheetlogo.jpg",
                           Name = "TimeSheet",
                           Platform = "TimeSheet"
                       },
                   }
           );
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1124",
                       ActivityType = "TimeSheet",
                       DateTime = new DateTime(2019, 1, 17),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "TimeSheet Submitted Successfully",
                           DisplayName = "Submitted time sheet",
                           IconUrl = "assests/images/users/timesheetlogo.jpg",
                           Name = "TimeSheet",
                           Platform = "TimeSheet"
                       },
                   }
           );
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1124",
                       ActivityType = "TimeSheet",
                       DateTime = new DateTime(2019, 1, 17),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "TimeSheet Submitted Successfully",
                           DisplayName = "Submitted time sheet",
                           IconUrl = "assests/images/users/timesheetlogo.jpg",
                           Name = "TimeSheet",
                           Platform = "TimeSheet"
                       },
                   }
           );
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1124",
                       ActivityType = "TimeSheet",
                       DateTime = new DateTime(2019, 1, 17),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "TimeSheet Submitted Successfully",
                           DisplayName = "Submitted time sheet",
                           IconUrl = "assests/images/users/timesheetlogo.jpg",
                           Name = "TimeSheet",
                           Platform = "TimeSheet"
                       },
                   }
           );
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1125",
                        ActivityType = "PR Review",
                        DateTime = new DateTime(2019, 1, 12),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "Did a Pr Review",
                            DisplayName = "Did a Pr review",
                            IconUrl = "assests/images/users/githublogo.jpg",
                            Name = "github",
                            Platform = "github"
                        },
                    });
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1125",
                       ActivityType = "PR Review",
                       DateTime = new DateTime(2019, 1, 12),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "Did a Pr Review",
                           DisplayName = "Did a Pr review",
                           IconUrl = "assests/images/users/githublogo.jpg",
                           Name = "github",
                           Platform = "github"
                       },
                   });
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1125",
                       ActivityType = "PR Review",
                       DateTime = new DateTime(2019, 1, 12),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "Did a Pr Review",
                           DisplayName = "Did a Pr review",
                           IconUrl = "assests/images/users/githublogo.jpg",
                           Name = "github",
                           Platform = "github"
                       },
                   });
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1125",
                       ActivityType = "PR Review",
                       DateTime = new DateTime(2019, 1, 12),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "Did a Pr Review",
                           DisplayName = "Did a Pr review",
                           IconUrl = "assests/images/users/githublogo.jpg",
                           Name = "github",
                           Platform = "github"
                       },
                   });
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1125",
                       ActivityType = "PR Review",
                       DateTime = new DateTime(2019, 1, 12),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "Did a Pr Review",
                           DisplayName = "Did a Pr review",
                           IconUrl = "assests/images/users/githublogo.jpg",
                           Name = "github",
                           Platform = "github"
                       },
                   });
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1125",
                       ActivityType = "PR Review",
                       DateTime = new DateTime(2019, 1, 12),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "Did a Pr Review",
                           DisplayName = "Did a Pr review",
                           IconUrl = "assests/images/users/githublogo.jpg",
                           Name = "github",
                           Platform = "github"
                       },
                   });
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1125",
                       ActivityType = "PR Review",
                       DateTime = new DateTime(2019, 1, 12),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "Did a Pr Review",
                           DisplayName = "Did a Pr review",
                           IconUrl = "assests/images/users/githublogo.jpg",
                           Name = "github",
                           Platform = "github"
                       },
                   });
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1125",
                       ActivityType = "PR Review",
                       DateTime = new DateTime(2019, 1, 12),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "Did a Pr Review",
                           DisplayName = "Did a Pr review",
                           IconUrl = "assests/images/users/githublogo.jpg",
                           Name = "github",
                           Platform = "github"
                       },
                   });
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1125",
                       ActivityType = "PR Review",
                       DateTime = new DateTime(2019, 1, 12),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "Did a Pr Review",
                           DisplayName = "Did a Pr review",
                           IconUrl = "assests/images/users/githublogo.jpg",
                           Name = "github",
                           Platform = "github"
                       },
                   });
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1125",
                       ActivityType = "PR Review",
                       DateTime = new DateTime(2019, 1, 12),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "Did a Pr Review",
                           DisplayName = "Did a Pr review",
                           IconUrl = "assests/images/users/githublogo.jpg",
                           Name = "github",
                           Platform = "github"
                       },
                   });
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1125",
                       ActivityType = "PR Review",
                       DateTime = new DateTime(2019, 1, 12),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "Did a Pr Review",
                           DisplayName = "Did a Pr review",
                           IconUrl = "assests/images/users/githublogo.jpg",
                           Name = "github",
                           Platform = "github"
                       },
                   });
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1125",
                       ActivityType = "PR Review",
                       DateTime = new DateTime(2019, 1, 12),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "Did a Pr Review",
                           DisplayName = "Did a Pr review",
                           IconUrl = "assests/images/users/githublogo.jpg",
                           Name = "github",
                           Platform = "github"
                       },
                   });
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1125",
                       ActivityType = "PR Review",
                       DateTime = new DateTime(2019, 1, 12),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "Did a Pr Review",
                           DisplayName = "Did a Pr review",
                           IconUrl = "assests/images/users/githublogo.jpg",
                           Name = "github",
                           Platform = "github"
                       },
                   });
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1126",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 3, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    }
            );
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1126",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 3, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    }
            );
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1126",
                       ActivityType = "Timesheet submission",
                       DateTime = new DateTime(2019, 3, 1),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "TimeSheet Submitted Successfully",
                           DisplayName = "Submitted time sheet",
                           IconUrl = "assests/images/users/timesheetlogo.jpg",
                           Name = "TimeSheet",
                           Platform = "TimeSheet"
                       },
                   }
           );
            _employeeActivities.Add(
                   new EmployeeActivity
                   {
                       EmployeeId = "1126",
                       ActivityType = "Timesheet submission",
                       DateTime = new DateTime(2019, 3, 1),
                       Activity = new Activity
                       {
                           Id = "1",
                           ActionVerb = "TimeSheet Submitted Successfully",
                           DisplayName = "Submitted time sheet",
                           IconUrl = "assests/images/users/timesheetlogo.jpg",
                           Name = "TimeSheet",
                           Platform = "TimeSheet"
                       },
                   }
           );
            _employeeActivities.Add(
                  new EmployeeActivity
                  {
                      EmployeeId = "1126",
                      ActivityType = "Timesheet submission",
                      DateTime = new DateTime(2019, 3, 1),
                      Activity = new Activity
                      {
                          Id = "1",
                          ActionVerb = "TimeSheet Submitted Successfully",
                          DisplayName = "Submitted time sheet",
                          IconUrl = "assests/images/users/timesheetlogo.jpg",
                          Name = "TimeSheet",
                          Platform = "TimeSheet"
                      },
                  }
          );
            _employeeActivities.Add(
                  new EmployeeActivity
                  {
                      EmployeeId = "1126",
                      ActivityType = "Timesheet submission",
                      DateTime = new DateTime(2019, 3, 1),
                      Activity = new Activity
                      {
                          Id = "1",
                          ActionVerb = "TimeSheet Submitted Successfully",
                          DisplayName = "Submitted time sheet",
                          IconUrl = "assests/images/users/timesheetlogo.jpg",
                          Name = "TimeSheet",
                          Platform = "TimeSheet"
                      },
                  }
          );




            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1126",
                        ActivityType = "PR Review",
                        DateTime = new DateTime(2019, 3, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "Did a Pr Review",
                            DisplayName = "Did a Pr Review",
                            IconUrl = "assests/images/users/githublogo.jpg",
                            Name = "github",
                            Platform = "github"
                        },
                    });
                    _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1127",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 3, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    });
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1127",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 3, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    });
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1127",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 3, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    });
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1127",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 3, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    });
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1127",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 3, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    });
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1127",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 3, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    });
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1127",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 3, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    });
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1127",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 3, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    });
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1127",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 3, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    });
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1127",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 3, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    });
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1127",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 3, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    });
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1127",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 3, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    });
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1127",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 3, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    });
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1127",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 3, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    });
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1127",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 3, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    });
            _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1127",
                        ActivityType = "Timesheet submission",
                        DateTime = new DateTime(2019, 3, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet Submitted Successfully",
                            DisplayName = "Submitted time sheet",
                            IconUrl = "assests/images/users/timesheetlogo.jpg",
                            Name = "TimeSheet",
                            Platform = "TimeSheet"
                        },
                    });
            _employeeActivities.Add(
            new EmployeeActivity
            {
                EmployeeId = "1128",
                ActivityType = "github",
                DateTime = new DateTime(2019, 1, 1),
                Activity = new Activity
                {
                    Id = "1",
                    ActionVerb = "PR reviewed ",
                    DisplayName = "PR reviewed",
                    IconUrl = "assests/images/users/githublogo.jpg",
                    Name = "Github",
                    Platform = "Github"
                },
            });
            _employeeActivities.Add(
            new EmployeeActivity
            {
                EmployeeId = "1128",
                ActivityType = "github",
                DateTime = new DateTime(2019, 1, 1),
                Activity = new Activity
                {
                    Id = "1",
                    ActionVerb = "PR reviewed ",
                    DisplayName = "PR reviewed",
                    IconUrl = "assests/images/users/githublogo.jpg",
                    Name = "Github",
                    Platform = "Github"
                },
            });
            _employeeActivities.Add(
            new EmployeeActivity
            {
                EmployeeId = "1128",
                ActivityType = "github",
                DateTime = new DateTime(2019, 1, 1),
                Activity = new Activity
                {
                    Id = "1",
                    ActionVerb = "PR reviewed ",
                    DisplayName = "PR reviewed",
                    IconUrl = "assests/images/users/githublogo.jpg",
                    Name = "Github",
                    Platform = "Github"
                },
            });
            _employeeActivities.Add(
            new EmployeeActivity
            {
                EmployeeId = "1128",
                ActivityType = "github",
                DateTime = new DateTime(2019, 1, 1),
                Activity = new Activity
                {
                    Id = "1",
                    ActionVerb = "PR reviewed ",
                    DisplayName = "PR reviewed",
                    IconUrl = "assests/images/users/githublogo.jpg",
                    Name = "Github",
                    Platform = "Github"
                },
            });
            _employeeActivities.Add(
            new EmployeeActivity
            {
                EmployeeId = "1128",
                ActivityType = "github",
                DateTime = new DateTime(2019, 1, 1),
                Activity = new Activity
                {
                    Id = "1",
                    ActionVerb = "PR reviewed ",
                    DisplayName = "PR reviewed",
                    IconUrl = "assests/images/users/githublogo.jpg",
                    Name = "Github",
                    Platform = "Github"
                },
            });
            _employeeActivities.Add(
            new EmployeeActivity
            {
                EmployeeId = "1128",
                ActivityType = "github",
                DateTime = new DateTime(2019, 1, 1),
                Activity = new Activity
                {
                    Id = "1",
                    ActionVerb = "PR reviewed ",
                    DisplayName = "PR reviewed",
                    IconUrl = "assests/images/users/githublogo.jpg",
                    Name = "Github",
                    Platform = "Github"
                },
            });
            _employeeActivities.Add(
            new EmployeeActivity
            {
                EmployeeId = "1128",
                ActivityType = "github",
                DateTime = new DateTime(2019, 1, 1),
                Activity = new Activity
                {
                    Id = "1",
                    ActionVerb = "PR reviewed ",
                    DisplayName = "PR reviewed",
                    IconUrl = "assests/images/users/githublogo.jpg",
                    Name = "Github",
                    Platform = "Github"
                },
            });
            _employeeActivities.Add(
            new EmployeeActivity
            {
                EmployeeId = "1128",
                ActivityType = "github",
                DateTime = new DateTime(2019, 1, 1),
                Activity = new Activity
                {
                    Id = "1",
                    ActionVerb = "PR reviewed ",
                    DisplayName = "PR reviewed",
                    IconUrl = "assests/images/users/githublogo.jpg",
                    Name = "Github",
                    Platform = "Github"
                },
            });
            _employeeActivities.Add(
            new EmployeeActivity
            {
                EmployeeId = "1128",
                ActivityType = "github",
                DateTime = new DateTime(2019, 1, 1),
                Activity = new Activity
                {
                    Id = "1",
                    ActionVerb = "PR reviewed ",
                    DisplayName = "PR reviewed",
                    IconUrl = "assests/images/users/githublogo.jpg",
                    Name = "Github",
                    Platform = "Github"
                },
            });
            _employeeActivities.Add(
            new EmployeeActivity
            {
                EmployeeId = "1128",
                ActivityType = "github",
                DateTime = new DateTime(2019, 1, 1),
                Activity = new Activity
                {
                    Id = "1",
                    ActionVerb = "PR reviewed ",
                    DisplayName = "PR reviewed",
                    IconUrl = "assests/images/users/githublogo.jpg",
                    Name = "Github",
                    Platform = "Github"
                },
            });
            _employeeActivities.Add(
            new EmployeeActivity
            {
                EmployeeId = "1128",
                ActivityType = "timesheet",
                DateTime = new DateTime(2018, 11, 1),
                Activity = new Activity
                {
                    Id = "1",
                    ActionVerb = "TimeSheet filled Daily ",
                    DisplayName = "TimeSheet filled",
                    IconUrl = "assests/images/users/githublogo.jpg",
                    Name = "Github",
                    Platform = "Github"
                },
            });
                    _employeeActivities.Add(
                    new EmployeeActivity
                    {
                        EmployeeId = "1128",
                        ActivityType = "github",
                        DateTime = new DateTime(2018, 11, 1),
                        Activity = new Activity
                        {
                            Id = "1",
                            ActionVerb = "TimeSheet filled Daily ",
                            DisplayName = "TimeSheet filled",
                            IconUrl = "assests/images/users/githublogo.jpg",
                            Name = "Github",
                            Platform = "Github"
                        },
                    });



        }

        public Task<EmployeeActivity> AddActivity(EmployeeActivity employeeActivity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteActivity(string activityId)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedActivity> GetActivities(string employeeId, string pageState, int pageSize)
        {
            List<string> pageStateList = new List<string>() { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            List<EmployeeActivity> employeeActivities;
            if (pageState == null)
            {
                employeeActivities = _employeeActivities.FindAll(c => c.EmployeeId == employeeId).Take(pageSize).ToList();
                pageState = pageStateList[0];
            }

            else
            {
                int index = pageStateList.FindIndex(x => x == pageState);
                employeeActivities = _employeeActivities.FindAll(c => c.EmployeeId == employeeId).Skip((index+1)*pageSize).Take(pageSize).ToList();
                if (employeeActivities[employeeActivities.Count-1].Activity.Id== _employeeActivities[_employeeActivities.Count - 1].Activity.Id)
                    pageState = null;
                else
                    pageState = pageStateList[index + 1];
            }

            

            return new PagedActivity
            {
                Activities = employeeActivities,
                PageState=pageState
            };
        }

        public Task<EmployeeActivity> UpdateActivity(EmployeeActivity employeeActivity)
        {
            throw new NotImplementedException();
        }
    }
}
