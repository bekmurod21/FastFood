﻿using System.ComponentModel.DataAnnotations;

namespace FastFood.Service.DTOs.ProductDto
{
    public class ProductForCreationDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public long CategoryId { get; set; }
    }
}