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
        public int Id { get; set; }

        public string Name { get; set; }

    }
}
