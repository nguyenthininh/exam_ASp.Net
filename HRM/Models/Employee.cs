using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
        public int Telephone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; } 
    }
}
