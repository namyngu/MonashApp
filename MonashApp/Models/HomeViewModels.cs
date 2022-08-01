﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MonashApp.Models
{
    public class ContactViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Your Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Subject cannot be greater than 30 characters.")]
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Message must be between 10-500 characters!", MinimumLength = 10)]
        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}