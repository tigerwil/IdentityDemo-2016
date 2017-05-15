using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using IdentityDemo.Models;
using IdentityDemo.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace IdentityDemo.Controllers
{
    public class AdminController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context, 
                               RoleManager<IdentityRole> roleManager,
                               UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        //GET Index (return all users)
        public IActionResult Index()
        {
            return View(_context.ApplicationUser.ToList());
        }

        //GET Edit (return all users)
        public IActionResult Edit(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }



            return View();
        }
    }
}