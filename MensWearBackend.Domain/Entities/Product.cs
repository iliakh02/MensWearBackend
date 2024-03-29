﻿using MensWearBackend.Domain.Abstract.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MensWearBackend.Domain.Entities
{
    public class Product : IEntityBase
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Producer { get; set; }
        [Required]
        [Range(0, 1)]
        public double Discount { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string Description { get; set; }
        public int Amount { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public ICollection<CartItem> CartItems { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
