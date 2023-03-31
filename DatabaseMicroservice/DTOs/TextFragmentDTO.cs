using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMicroservice.DTOs
{
    internal class TextFragmentDTO : FragmentDTO
    {
        public override string FragmentType { get; set; } = "text";
        public string Body { get; set; }
    }
}
