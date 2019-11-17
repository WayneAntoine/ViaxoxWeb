using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmartPax.Models
{
    public class RoleModel
    {

        [Required(ErrorMessage = "Role is required")]
        public string RoleName { get; set; }

        public string RoleDescription { get; set; }
    }
}