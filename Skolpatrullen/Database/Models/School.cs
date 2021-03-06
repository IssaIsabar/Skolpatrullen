﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.Models
{ 
    public class School
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string PostalCode { get; set; }

        public ICollection<UserSchool> UserSchools { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
