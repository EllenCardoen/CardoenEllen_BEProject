using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BEProjectEllen.Core.Repositories;
using BEProjectEllen.Core.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace BEProjectEllen.Web.Controllers
{
    public class UserManagementController : Controller
    {
        private readonly IUserRepo _userRepo;
        private readonly ILogger<UserManagementController> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IRoleRepo _roleRepo;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserManagementController(IUserRepo userRepo, ILogger<UserManagementController> logger, UserManager<IdentityUser> userManager, IRoleRepo roleRepo, RoleManager<IdentityRole> roleManager)
        { 
            _userRepo = userRepo;
            _logger = logger;
            _userManager = userManager;
            _roleRepo = roleRepo;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            List<IdentityRole> identityList = new List<IdentityRole>();
            identityList.AddRange(await _roleRepo.GetAllAsync());
            ViewBag.RoleList = new SelectList(identityList, "Id", "Name");

            var users = await _userRepo.GetAllAsync();

            var roles = await _roleRepo.GetAllAsync();

            var userManagerVMs = new UserManagerVM()
                {
                    Roles = roles,
                    UserVMS = new List<UserVM>()
                };

            foreach (var user in users)
            {
                var uservm = new UserVM
                {
                    Id = user.Id,
                    Email = user.Email,
                    UserRoles = await _userManager.GetRolesAsync(user)
                };

                userManagerVMs.UserVMS.Add(uservm);
            }

            return View(userManagerVMs);
        }


        public async Task<IActionResult> AddRoleToUser(string userId)
        {
            IdentityUser user = new IdentityUser();

            if (!String.IsNullOrEmpty(userId))
                user = await _userManager.FindByIdAsync(userId);

            if (user == null)
                return RedirectToAction("Index");

            return View();
        }

        


    }
}