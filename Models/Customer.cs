using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSheets_ServiceAuto.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [RegularExpression(@"^[A-Z][a-z]+\s[A-Z][a-z]+$", ErrorMessage = "Numele autorului trebuie sa fie de forma 'Nume Prenume'"), 
         Required, StringLength(40, MinimumLength = 4)]
        [Display(Name ="Numele si Prenumele")]
        public string CustomerName { get; set; }

        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Numarul de telefon trebuie sa contina doar cifre si fara spatiu"), Required,
         StringLength(14, MinimumLength = 10, ErrorMessage = "Minim 10 cifre, Maximum 12 cifre")]
        [Display(Name ="Telefon")]
        public int CustomerPhone { get; set; }

        [Display(Name="Adresa")]
        public string CustomerAddress { get; set; }

        public ICollection<CarSheet> CarSheets { get; set; }
    }
}
