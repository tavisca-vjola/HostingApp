using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Applause.Core
{
    public interface ITimesheetService
    {
        Task ProcessTimesheet(Stream stream, DateTime date, bool IsEndOfMonth);
    }
}
