using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels
{
    public class ProfileViewModel : LayoutViewModel
    {
        public string FirstName { get; set; }
        public string LastNames { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string NewPassword { get; set; }
        public string ReNewPassword { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}
