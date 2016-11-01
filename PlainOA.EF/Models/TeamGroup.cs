using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlainOA.EF.Models
{
    [Table("TeamGroup")]
    public class TeamGroup
    {
        [Key]
        public int Id { get; set; }

        public string GroupName { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
