using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models
{
    public class product
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string? name { get; set; }

        [Required]
        public int? quantity { get; set; }

        [Required]
        public decimal? price { get; set; }

        public bool? IsActive { get; set; } = true;

        public DateTime? CreateDate { get; set; } = DateTime.Now;

        public string? CreatedBy { get; set; }

        public DateTime? ModifiedAt { get; set; }

        public string? ModifiedBy { get; set; }
    }
}
