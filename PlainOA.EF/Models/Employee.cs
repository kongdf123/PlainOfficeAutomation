using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int EmployeeId { get; set; }

        [MaxLength(50)]
        public string EmployeeName { get; set; }
        
        public int DepartmentId { get; set; }
         
        public int AccountId { get; set; }

        public Department Department { get; set; }

        public EmployeeAccount EmployeeAccount { get; set; }

        public List<TeamGroup> TeamGroups { get; set; }

    }
}
