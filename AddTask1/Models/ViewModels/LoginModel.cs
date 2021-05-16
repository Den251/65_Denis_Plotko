using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AddTask1.Models.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Enter email")]
        public string Email { get; set; }

        [UIHint("Password")]
        [Required(ErrorMessage ="Enter password")]
        public string Password { get; set; }
    }
}
