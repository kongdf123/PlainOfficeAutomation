using System;
using System.Collections.Generic;
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

        public string ProjectName { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
