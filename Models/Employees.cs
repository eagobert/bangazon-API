using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using bangazon_inc.Data;

namespace bangazon_inc.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]

        // department id foreign key
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        [Required]
        public bool Supervisor { get; set; }
        [Required]
        public string StartDate { get; set; }
        public string EndDate { get; set; }

    }
}