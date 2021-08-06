using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using den_office.ViewModels;

namespace den_office.Models
{
    
    public class AdminController : Controller
    
    
    {
        private readonly RoleManager<IdentityRole> roleManager;


        public AdminController(RoleManager<IdentityRole> roleManager)
        {
//            this.roleManager = roleManager;
            this.roleManager = roleManager;

        }

 

       [HttpGet]
        public JsonResult ListRoles()

        {
            var roles = roleManager.Roles;
            return Json(roles);
        }

    }
    
}
