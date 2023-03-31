using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMicroservice.DTOs
{
    internal class ExternalFragmentDTO : FragmentDTO
    {
        public override string FragmentType { get; set; } = "external";
        public string ExcernalType { get; set; }
        public string ExternalId { get; set; }
    }
}
