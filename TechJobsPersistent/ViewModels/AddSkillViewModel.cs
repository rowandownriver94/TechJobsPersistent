using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddSkillViewModel
    {
            [Required(ErrorMessage = "Please enter a skill name.")]
            [StringLength(50, MinimumLength = 3)]
            public string Name { get; set; }

            [Required(ErrorMessage = "Please enter a skill description.")]
            [StringLength(50, MinimumLength = 3)]
            public string Description { get; set; }

    }
}
