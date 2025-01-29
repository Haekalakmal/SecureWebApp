using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SecureWebApp.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [Required]
        public int ItemId { get; set; }

        [ForeignKey("ItemId")]
        public InventoryItem Item { get; set; }

        [Required]
        public string TransactionType { get; set; } // "IN" or "OUT"

        [Required]
        public int Quantity { get; set; }

        public DateTime TransactionDate { get; set; } = DateTime.UtcNow;
    }
}