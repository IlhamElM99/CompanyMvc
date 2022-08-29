using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyMvc.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string EmployeeName { get; set; }

        [Display(Name = "DateOfBirth"), DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [StringLength(20, MinimumLength = 1)]
        [Required]
        public string Gender { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string CurrentAdress { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string PermanentAdress { get; set; }

        [StringLength(20, MinimumLength = 3), Required]
        public string City { get; set; }

        [StringLength(20, MinimumLength = 3), Required]
        public string Nationality { get; set; }
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), Required, StringLength(6)]
        public string PINCode { get; set; }
        
        public string Position { get; set; }

        public int IdDemandeDeCongé { get; set; }

        public DemandeDeCongé DemandeDeCongé { get; set; }

        public int SoldeDeCongé { get; set; }
    }
}
