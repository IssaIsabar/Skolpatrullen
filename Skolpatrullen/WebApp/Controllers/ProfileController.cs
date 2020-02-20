using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class ProfileController : AppController
    {
        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> ProfileDetailsPageAsync()
        {
            string message = await GetUser();
            if (User != null)
            {
                ProfileViewModel profileVM = new ProfileViewModel();
                var response = await APIGetUserById(User.Id);
                profileVM.User = response.Data;
                return View(profileVM);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}