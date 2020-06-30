using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MVCMyDatabase.Models;

namespace MVCMyDatabase.Models
{
    public class MyDatabase
    {
        //Members
        [Required]
        public int ID { get; set; }
        [Required]
        public string HireLevelName { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
        public int AddressID { get; set; }
        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string SIN { get; set; }
    }
}
