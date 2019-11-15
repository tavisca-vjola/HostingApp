using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tavisca.Applause.Core.Validators
{
    public class EmployeeValidator
    {
        public static void ValidateEmployeeId(string id)
        {
            if (id == null || !Regex.IsMatch("^[0-9]+$", id.Substring(1)))
                throw new BadRequestException("Not a valid Employee Id");
        }

    

    }
}
