using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlainOA.EF.Models
{
    [Table("EmployeeAccount")]
    public class EmployeeAccount
    {
        [Key]
        public int EmployeeId { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Password { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }

        public Employee Employee { get; set; }
    }
}
