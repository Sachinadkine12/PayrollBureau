﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System.Security.Principal;
using System.Web;
namespace PayrollBureau.Extensions
{
    public static class IdentityExtensions
    {
        public static string GetName(this IIdentity identity)
        {
            var user = HttpContext.Current.GetOwinContext().Get<ApplicationUserManager>().FindById(identity.GetUserId());
            return user?.UserName ?? string.Empty;
        }
    }
}