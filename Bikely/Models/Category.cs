﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bikely.Models
{
    public class Category
    {
        public byte Id { get; set; }

        [Required(ErrorMessage = "Boş buraxılmamalıdır")]
        [Display(Name = "Kateqoriya adı")]
        public string Name { get; set; }
    }
}