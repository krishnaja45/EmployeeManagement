using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeShared
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is mandatory")]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Department is mandatory")]
        [StringLength(50)]
        public string? Department { get; set; }

        [Required(ErrorMessage = "Place is mandatory")]
        [StringLength(100)]
        public string? Place { get; set; }

        [Range(1, 99999999, ErrorMessage = "Salary must be valid")]
        public decimal Salary { get; set; }

        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
