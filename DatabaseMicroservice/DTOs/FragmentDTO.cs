using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMicroservice.DTOs
{
    internal abstract class FragmentDTO
    {
        public string BelongsTo { get; set; }
        public string FragmentID { get; set; }
        public string NextFragmentId { get; set; }
        public int TotalFragmentCount { get; set; }
        abstract public string FragmentType { get; set; }
    }
}
