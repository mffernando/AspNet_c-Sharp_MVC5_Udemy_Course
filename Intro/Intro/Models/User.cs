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
        [StringLength(50, MinimumLength = 5, ErrorMessage ="Min 50 and Max 50 characters!")]
        public string Observation { get; set; }
        public string Age { get; set; }
        public string Mail { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
    }
}