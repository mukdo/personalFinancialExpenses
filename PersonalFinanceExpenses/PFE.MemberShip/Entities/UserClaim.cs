using System;

using Microsoft.AspNetCore.Identity;

namespace PFE.MemberShip.Entities
{
    public class UserClaim
        : IdentityUserClaim<Guid>
    {
        public UserClaim()
            : base()
        {

        }
    }
}
