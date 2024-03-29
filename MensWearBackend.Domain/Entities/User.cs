﻿using MensWearBackend.Domain.Abstract.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MensWearBackend.Domain.Entities
{
    public class User : IEntityBase
    {
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public ICollection<Order> Orders { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public ICollection<CartItem> Cart { get; set; }
        public int Id { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
