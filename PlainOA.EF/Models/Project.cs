using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlainOA.EF.Models
{
    [Table("Project")]
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string ProjectName { get; set; }
        
        public int DepartmentId { get; set; }

        public DateTime ProjectDate { get; set; }

        public Department Department { get; set; }

        public List<Employee> Employees { get; set; }

    }
}
