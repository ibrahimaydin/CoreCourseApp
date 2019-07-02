using CoreCourseApp.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourseApp.Infrastructure
{
    public class CustomUserValidator : IUserValidator<ApplicationUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<ApplicationUser> manager, ApplicationUser user)
        {
           if(user.Email.ToLower().EndsWith("@gmail.com")||user.Email.ToLower().EndsWith("@outlook.com"))
            {
                return Task.FromResult(IdentityResult.Success);
            }
            else
            {
                return Task.FromResult(IdentityResult.Failed(new IdentityError()
                {
                    Code = "EmailDomainError",
                    Description="Only accept gmail or outlook"
               
                }));
            }
        }
    }
}
