using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMyDatabase.Models
{
    public class Employee
    {
        //Members
        public int ID { get; set; }
        [Required]
        public string HireLevelName { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
        [Required]
        public string AddressID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string SIN { get; set; }
        [Required]
    }
}
