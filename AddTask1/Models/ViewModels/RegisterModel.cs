using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AddTask1.Models.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Enter email")]
        public string Email { get; set; }

        [UIHint("Password")]
        [Required(ErrorMessage = "Enter password")]
        public string Password { get; set; }

        [UIHint("Password")]
        [Compare("Password", ErrorMessage = "Passwords are not equal!")]
        public string ConfirmPassword { get; set; }

        
        [Required(ErrorMessage = "Enter your name")]
        public string Name { get; set; }



    }
}
