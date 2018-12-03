using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kandidattest.Models
{
    public class VMsignup
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Fornavn { get; set; }
        [Required]
        public string Etternavn { get; set; }
        [Required]
        public int Fødselsnummer { get; set; }

    }
}