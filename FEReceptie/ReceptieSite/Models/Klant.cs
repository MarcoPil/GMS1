using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReceptieSite.Models
{
    public class Klant
    {
        public long? Klantnummer { get; set; }
        public string Naam { get; set; }
        public string Telefoonnummer { get; set; }
        public string Emailadres { get; set; }
    }
}