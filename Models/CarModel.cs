using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSheets_ServiceAuto.Models
{
    public class CarModel
    {
        public int ID { get; set; }

        [RegularExpression(@"[a-zA-Z\s]+$", ErrorMessage = "Introduceti numele marcii de masini"),
         Required, StringLength(20, MinimumLength = 2, ErrorMessage = "Trebuie sa contina minim 2 litere si maxim 20")]
        [Display(Name ="Marca masina")]
        public string carModelName { get; set; }
        
        public ICollection<CarSheet> CarSheets { get; set; }
    }
}
