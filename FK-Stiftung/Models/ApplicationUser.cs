using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;


namespace FK_Stiftung.Models
{
    public class ApplicationUser:IdentityUser 
    {
        [Required]
        public int Name { get; set; }

        public string? StreetAdress { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }

        public string? PostalCode { get; set; }

    }
}
