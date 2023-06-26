using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using den_office.ViewModels;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using den_office.Data;
using Microsoft.AspNet.Identity;

namespace den_office.Models
{
    
    public class ApplicationRoleManager : Controller
    
    
    {
        /*private readonly RoleManager<IdentityRole> roleManager;


        public ApplicationRoleManager(IRoleStore<IdentityRole, string> roleStore)
            : base(roleStore)
        {
        }
        public static ApplicationRoleManager Create(IdentityFactoryOptions<ApplicationRoleManager> options, IOwinContext context)
        {
            var appRoleManager = new ApplicationRoleManager(new RoleStore<IdentityRole>(context.Get<ApplicationDbContext>()));

            return appRoleManager;
        }
        


        [HttpGet]
        public JsonResult ListRoles()

        {
            var roles= roleManager.Roles;
            return Json(roles);
        }
        */
    }
    
}
