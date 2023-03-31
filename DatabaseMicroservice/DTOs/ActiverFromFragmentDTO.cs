using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMicroservice.DTOs
{
    internal class ActiverFromFragmentDTO : FragmentDTO
    {
        public override string FragmentType { get; set; } = "activeFrom";
        public DateTime ActiveFrom { get; set; }
        public DateTime? ActiveTo { get; set; }
    }
}
