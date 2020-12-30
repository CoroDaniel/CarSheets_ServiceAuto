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
    public class IndexModel : PageModel
    {
        private readonly CarSheets_ServiceAuto.Data.CarSheets_ServiceAutoContext _context;

        public IndexModel(CarSheets_ServiceAuto.Data.CarSheets_ServiceAutoContext context)
        {
            _context = context;
        }

        public IList<CarSheet> CarSheet { get;set; }

        public async Task OnGetAsync()
        {
            CarSheet = await _context.CarSheet.Include(b => b.CarModel).ToListAsync();
            CarSheet = await _context.CarSheet.Include(c => c.Customer).ToListAsync();
        }
    }
}
