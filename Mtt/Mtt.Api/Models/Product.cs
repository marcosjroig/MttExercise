﻿using System.ComponentModel.DataAnnotations;

namespace Mtt.Api.Models
{
    public class Product
    {
        [Key]
        public int Sku { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
