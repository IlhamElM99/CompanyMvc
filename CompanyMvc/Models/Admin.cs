using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CompanyMvc.Models
{
    public class Admin
    {
        [Key]
        public int IdAdmin { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public List<DemandeDeCongé> DemandesDeCongé { get; set; }
    }
}
