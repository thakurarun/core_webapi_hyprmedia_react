﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimpleAPI.Controllers.ProductArea.ProductModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductModel
    {
        [Required(
            AllowEmptyStrings = false,
            ErrorMessage = "Product name is required and can't be empty")]
        public string Name { get; set; }
        [Required(
            AllowEmptyStrings = false,
            ErrorMessage = "Category is required for each product")]
        public string Category { get; set; }

        [Required]
        [Range(0.01, 200)]
        public decimal Price { get; set; }

    }

    public static class ProductProducer
    {
        public static IList<Product> Products = new List<Product>
        {
            new Product{ Id = 1, Name = "ABC", Price = 10.25M, Category = "Automatic" },
            new Product{ Id = 2, Name = "EFG", Price = 20.00M, Category = "Automatic" },
            new Product{ Id = 3, Name = "HKL", Price = 12.45M, Category = "Automatic" },
            new Product{ Id = 4, Name = "MBP", Price = 56.00M, Category = "Automatic" },
            new Product{ Id = 5, Name = "XYZ", Price = 15.30M, Category = "Automatic" }
        };
    }
}
