using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Intro.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Observation { get; set; }
        public string Age { get; set; }
        public string Mail { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
    }
}