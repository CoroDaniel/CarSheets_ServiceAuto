using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarSheets_ServiceAuto.Data;
using CarSheets_ServiceAuto.Models;

namespace CarSheets_ServiceAuto.Pages.CarModels
{
    public class DeleteModel : PageModel
    {
        private readonly CarSheets_ServiceAuto.Data.CarSheets_ServiceAutoContext _context;

        public DeleteModel(CarSheets_ServiceAuto.Data.CarSheets_ServiceAutoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CarModel CarModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CarModel = await _context.CarModel.FirstOrDefaultAsync(m => m.ID == id);

            if (CarModel == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CarModel = await _context.CarModel.FindAsync(id);

            if (CarModel != null)
            {
                _context.CarModel.Remove(CarModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
