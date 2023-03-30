using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMicroservice.Models
{
    internal class TextFragment
    {
        [Key]
        public string IdentifyingName { get; set; }
        public int FragmentID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
