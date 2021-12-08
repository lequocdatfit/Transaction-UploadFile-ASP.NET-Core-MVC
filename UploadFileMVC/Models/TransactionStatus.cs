using System.ComponentModel.DataAnnotations;

namespace UploadFileMVC.Models
{
    public class TransactionStatus
    {
        [Key]
        public int TransactionStatusId { get; set; }
        [Required]
        public string TransactionStatusName { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
    }
}
