using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarSheets_ServiceAuto.Data;
using CarSheets_ServiceAuto.Models;

namespace CarSheets_ServiceAuto.Pages.CarSheets
{
    public class DetailsModel : PageModel
    {
        private readonly CarSheets_ServiceAuto.Data.CarSheets_ServiceAutoContext _context;

        public DetailsModel(CarSheets_ServiceAuto.Data.CarSheets_ServiceAutoContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
