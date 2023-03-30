using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMicroservice.Models
{
    internal class APIKey
    {
        [Key]
        public int Id { get; set; }
        public string Key { get; set; }
        public string Originator { get; set; }
        public TimeSpan TimeToLive { get; set; }
        [ForeignKey(nameof(Role))]
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
