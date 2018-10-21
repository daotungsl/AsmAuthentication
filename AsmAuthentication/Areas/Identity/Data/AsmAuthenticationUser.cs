using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AsmAuthentication.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the AsmAuthenticationUser class
    public class AsmAuthenticationUser : IdentityUser
    {
        [PersonalData] public string FullName { get; set; }
        [PersonalData] public DateTime Birthday { get; set; }
        [PersonalData] public string RollNumber { get; set; }
        [PersonalData] public string Gender { get; set; }
    }
}
