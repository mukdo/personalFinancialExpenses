using System;

using Microsoft.AspNetCore.Identity;

namespace PFE.MemberShip.Entities
{
    public class UserToken
        : IdentityUserToken<Guid>
    {
        public UserToken()
            : base()
        {

        }
    }
}
