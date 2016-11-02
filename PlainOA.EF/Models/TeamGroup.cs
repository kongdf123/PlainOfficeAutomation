using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int TeamGroupId { get; set; }

        [MaxLength(50)]
        public string TeamGroupName { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
