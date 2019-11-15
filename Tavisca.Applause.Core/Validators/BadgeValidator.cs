using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Applause.Core.Validators
{
    public class BadgeValidator
    {
        public static void ValidateBadgeType(string badgeType)
        {
            if (badgeType == null)
              new BadRequestException("BadgeType is missing");
            if(badgeType!=Constants.BadgeType.Gold && badgeType!=Constants.BadgeType.Silver && badgeType != Constants.BadgeType.Bronze)
            {
                new BadRequestException("BadgeType is incorrect");
            }
        }
    }
}
