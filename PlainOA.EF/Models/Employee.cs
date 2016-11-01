using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlainOA.EF.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        [ForeignKey("EmployeeAccount")]
        public int AccountId { get; set; }

        public Department Department { get; set; }

        public EmployeeAccount EmployeeAccount { get; set; }

    }
}
