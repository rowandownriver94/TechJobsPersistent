using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Please enter the name of the employer.")]
        [StringLength(50, MinimumLength =3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a location.")]
        [StringLength(100, MinimumLength =3)]
        public string Location { get; set; }

        public AddEmployerViewModel()
        {

        }
    }
}
