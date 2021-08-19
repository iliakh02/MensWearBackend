using MensWearBackend.Domain.Abstract.Base;
using System.ComponentModel.DataAnnotations;

namespace MensWearBackend.Domain.Entities
{
    public class ProductOrder : IEntityBase
    {
        public int Id { get; set; }
        [Required]
        public int ProductId { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public Product Product { get; set; }
        [Required]
        public int OrderId { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public Order Order { get; set; }
        [Required]
        public int Amount { get; set; }
    }
}