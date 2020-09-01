using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Shop.Models
{
    public class LoginViewModel
    {
        [Display(Name = "Електронна адреса")]
        [Required(ErrorMessage = "Вкажіть пошту")]
        public string Email { get; set; }

        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Вкажіть пароль")]
        public string Password { get; set; }
    }
    public class RegistrationViewModel
    {
        [Display(Name = "User name")]
        [Required(ErrorMessage = "Invalid user name")]
        public string UserName { get; set; }
        //
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Invalid email")]
        public string Email { get; set; }
        //
        [Display(Name = "Phone number")]
        [Required(ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }
        //
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Invalid password")]
        public string Password { get; set; }
    }
}
