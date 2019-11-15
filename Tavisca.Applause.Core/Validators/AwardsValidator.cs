using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tavisca.Applause.Core.Validators
{
    public class AwardsValidator
    {
        public static void ValidateInputsForAnnualAwards(string awardType, int year)
        {
            if (awardType == null)
                throw new BadRequestException("AwardType not mentioned");
            if (awardType != Constants.AwardType.Annual)
                throw new BadRequestException("Wrong award type");
            if (year == 0)
                throw new BadRequestException("Year not mentioned");
            if (year >DateTime.Now.Year || year<0)
                throw new BadRequestException("Mentioned year is wrong");
        }

        public static void ValidateInputsForMonthlyAwards(string awardName, int month, int year)
        {
            if (awardName == null)
                throw new BadRequestException("AwardType not mentioned");
            if (awardName != Constants.AwardName.Kudos && awardName != Constants.AwardName.Shoutout)
                throw new BadRequestException("Wrong award name");
            if (year == 0)
                throw new BadRequestException("Year not mentioned");
            if (year > DateTime.Now.Year || year < 0)
                throw new BadRequestException("Mentioned year is wrong");
            if (month == 0)
                throw new BadRequestException("Month not mentioned");
            if ((year == DateTime.Now.Year && month > DateTime.Now.Month) || month < 0)
                throw new BadRequestException("Mentioned month is wrong");
        }
    }
}
