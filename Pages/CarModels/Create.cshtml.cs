using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CarSheets_ServiceAuto.Data;
using CarSheets_ServiceAuto.Models;

namespace CarSheets_ServiceAuto.Pages.CarModels
{
    public class CreateModel : PageModel
    {
        private readonly CarSheets_ServiceAuto.Data.CarSheets_ServiceAutoContext _context;

        public CreateModel(CarSheets_ServiceAuto.Data.CarSheets_ServiceAutoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CarModel CarModel { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CarModel.Add(CarModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
