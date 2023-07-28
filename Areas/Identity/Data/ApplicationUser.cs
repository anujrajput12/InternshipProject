using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;



namespace InternshipProject.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string? First_Name { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string? Last_Name { get; set; }
    }
}
