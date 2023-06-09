﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMicroservice.Models
{
    internal class TextFragment : Fragment
    {
        public override string FragmentType { get; set; } = "text";
        [Required]
        public string Body { get; set; }
    }
}
