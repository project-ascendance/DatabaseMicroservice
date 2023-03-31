using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMicroservice.Models
{
    internal class ExternalFragment : Fragment
    {
        public override string FragmentType { get; set; } = "external";
        [Required]
        public string ExcernalType { get; set; }
        [Required]
        public string ExternalId { get; set; }
    }
}
