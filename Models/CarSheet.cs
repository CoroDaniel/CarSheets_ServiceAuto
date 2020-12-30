using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSheets_ServiceAuto.Models
{
    public class CarSheet
    {
        public int ID { get; set; }

        public int CarModelId { get; set; }
        public CarModel CarModel { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required, StringLength(15, MinimumLength = 7)]
        [Display(Name ="Numar de inmatriculare")]
        public string nrInmatriculare { get; set; }

        [Required, StringLength(17, MinimumLength = 17)]
        [Display(Name ="Nr. identificare talon")]
        public string nrIdentificareTalon { get; set; }

        [Required, StringLength(350, MinimumLength = 2)]
        [Display(Name ="Descriere defectiuni")]
        public string descriereDefectiuni { get; set; }

        [Display(Name ="Total plata reparatii")]
        public decimal totalPlata { get; set; }

        [Range(1, 120)]
        [Display(Name ="Garantie (luni)")]
        public int luniGarantie { get; set; }
    }
}
