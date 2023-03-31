using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMicroservice.Models
{
    [PrimaryKey(nameof(BelongsTo),nameof(FragmentId))]
    internal abstract class Fragment
    {
        public string BelongsTo { get; set; }
        public string FragmentId { get; set; }
        [ForeignKey(nameof(Fragment))]
        public string? NextFragmentId { get; set; }
        [ForeignKey(nameof(Fragment))]
        public string? NextBelongsTo { get; set; }
        public Fragment NextFragment { get; set; }
        public int TotalFragmentCount { get; set; }
        abstract public string FragmentType { get; set; }
    }
}
