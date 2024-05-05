using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteLagoon.Domain.Entities
{
    public class Member
    {
        [Key]
        public String MSSV { get; set; }
        public required String Name { get; set; }
        public required String Email { get; set; }
    }
}
