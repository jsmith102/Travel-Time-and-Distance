using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Travel_Time_and_Distance.Models;

namespace Travel_Time_and_Distance.Pages.Locations
{
    public class AddLocationsModel : PageModel
    {
        [BindProperty]
        public LocationsModel Locations { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Save Model to database


            return RedirectToPage("/Index", new { StartLocation = Locations.LocationStart });
        }
    }
}
