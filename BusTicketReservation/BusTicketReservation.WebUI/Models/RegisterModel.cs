﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BusTicketReservation.WebUI.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "First Name length to be 3-25!")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [Display(Name = "Last Name")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Last Name length to be 3-25!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "User Name is required.")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "RePassword is required.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords does not match.")]
        public string RePassword { get; set; }

    }
}
