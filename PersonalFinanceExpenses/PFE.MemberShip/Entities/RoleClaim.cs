using System;

using Microsoft.AspNetCore.Identity;

namespace PFE.MemberShip.Entities
{
    public class RoleClaim
        : IdentityRoleClaim<Guid>
    {
        public RoleClaim()
            : base()
        {

        }
    }
}
