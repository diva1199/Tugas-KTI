using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.Models
{
    public class LoginNew
    {
        public string Username{ get ; set; } = string.Empty;
        public string Password{ get ; set; } = string.Empty;
        public bool Remember{ get ; set; } 
        public string ReturnUrl{ get ; set; } = string.Empty;
    }
}