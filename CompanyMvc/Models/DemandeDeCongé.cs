using System;
using System.Collections.Generic;

namespace CompanyMvc.Models
{
    public class DemandeDeCongé
    {
        public int Id { get; set; }

        public Employee Employee { get; set; }

        public DateTime DateDebut { get; set; }

        public DateTime DateRetour { get; set; }

        public string TypeDeCongé { get; set; }

        public string Cause { get; set; }

        public int NombreJours { get; set; }

        public string Status { get; set; }

        public Admin Validateur { get; set; }
    }
}
 