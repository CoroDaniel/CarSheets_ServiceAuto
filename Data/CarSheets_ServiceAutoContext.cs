using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarSheets_ServiceAuto.Models;

namespace CarSheets_ServiceAuto.Data
{
    public class CarSheets_ServiceAutoContext : DbContext
    {
        public CarSheets_ServiceAutoContext (DbContextOptions<CarSheets_ServiceAutoContext> options)
            : base(options)
        {
        }

        public DbSet<CarSheets_ServiceAuto.Models.CarSheet> CarSheet { get; set; }

        public DbSet<CarSheets_ServiceAuto.Models.CarModel> CarModel { get; set; }

        public DbSet<CarSheets_ServiceAuto.Models.Customer> Customer { get; set; }
    }
}
