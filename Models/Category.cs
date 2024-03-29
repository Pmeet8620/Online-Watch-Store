﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineWatchStore.Models
{
    public class Category
    {
        public int CategoryId { get; set; } //PK
        [Required]
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
