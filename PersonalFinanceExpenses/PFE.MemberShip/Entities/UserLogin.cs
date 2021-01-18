using System;

using Microsoft.AspNetCore.Identity;

namespace PFE.MemberShip.Entities
{
    public class UserLogin
        : IdentityUserLogin<Guid>
    {
        public UserLogin()
            : base()
        {

        }
    }
}
