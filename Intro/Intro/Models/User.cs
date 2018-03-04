using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Intro.Models
{
    public class User
    {
        [Required(ErrorMessage = "Name Required!")]
        public string Name { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Min 50 and Max 50 characters!")]
        public string Observation { get; set; }
        [Range(18, 70, ErrorMessage = "Age between 18 and 70!")]
        public string Age { get; set; }
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Invalid e-mail!")]
        public string Mail { get; set; }
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Only letters between 5 - 15 characters!")] // 5 - 10 characters
        [Required(ErrorMessage = "Login Required!")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Password Required!")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage ="Different Passwords!")]
        public string RepeatPassword { get; set; }
    }
}