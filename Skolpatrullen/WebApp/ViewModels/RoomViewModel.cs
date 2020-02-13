using Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels
{
    public class RoomViewModel
    {
        [Required]
        public string Name { get; set; }
        public string SchoolName{ get; set; }
    }
}
