using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    [Table("tblEmp")]
    public class Employee
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [ReadOnly(true)] //need to look at read only.
        [Required]
        public string Email { get; set; }
        [Required]
        public string Department { get; set; }
    }
}
