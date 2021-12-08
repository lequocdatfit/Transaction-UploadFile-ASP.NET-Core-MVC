using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UploadFileMVC.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public string CurrencyCode { get; set; }
        [Required]
        [ForeignKey("TransactionStatus")]
        public int TransactionStatusId { get;set; }
        [Required]
        public DateTime TransactionDate { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
    }
}
