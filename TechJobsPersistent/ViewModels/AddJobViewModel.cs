using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        public int EmployerId { get; set; }
        public List<SelectListItem> AllEmployers { get; set; }

        public AddJobViewModel(List<Employer> employers)
        {

            AllEmployers = new List<SelectListItem>();

            foreach (var employer in employers)
            {
                AllEmployers.Add
                (
                    new SelectListItem
                    {
                        Value = employer.Id.ToString(),
                        Text = employer.Name
                    }
                );
            }
        }

        public AddJobViewModel()
        {

        }
    }
}
