using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kandidattest.Models
{
    public class VMsignup
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "Vennligst oppgi ditt Fornavn")]
        public string Fornavn { get; set; }

        [Required(ErrorMessage = "Vennligst oppgi ditt Etternavn")]
        public string Etternavn { get; set; }

        [Required(ErrorMessage = "Vennligst oppgi din Epost")]
        [EmailAddress(ErrorMessage = "Ugyldig Epost")]
        public string Epost { get; set; }

        [Required(ErrorMessage = "Vennligst oppgi ditt Fødselsnr")]
        [RegularExpression(@"[0-9]{11}",ErrorMessage ="Ugyldig Fødselsnr")]
        public string Fødselsnummer { get; set; }

    }
}