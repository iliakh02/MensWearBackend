﻿using MensWearBackend.Domain.Abstract.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MensWearBackend.Domain.Entities
{
    public class Category : IEntityBase
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public ICollection<Product> Products { get; set; }
    }
}