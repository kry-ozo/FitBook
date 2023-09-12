using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBook.Models
{
    public class AppUser: IdentityUser
    {
        [Required]
        public  string Name { get; set; }

    }
}
