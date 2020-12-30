using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarSheets_ServiceAuto.Data;
using CarSheets_ServiceAuto.Models;

namespace CarSheets_ServiceAuto.Pages.CarSheets
{
    public class EditModel : PageModel
    {
        private readonly CarSheets_ServiceAuto.Data.CarSheets_ServiceAutoContext _context;

        public EditModel(CarSheets_ServiceAuto.Data.CarSheets_ServiceAutoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CarSheet CarSheet { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CarSheet = await _context.CarSheet.FirstOrDefaultAsync(m => m.ID == id);

            if (CarSheet == null)
            {
                return NotFound();
            }
            ViewData["CarModelId"] = new SelectList(_context.Set<CarModel>(), "ID", "carModelName");
            ViewData["CustomerId"] = new SelectList(_context.Set<Customer>(), "ID", "CustomerName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CarSheet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarSheetExists(CarSheet.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CarSheetExists(int id)
        {
            return _context.CarSheet.Any(e => e.ID == id);
        }
    }
}
