using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EndeKissie.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; } // Primary Key

        [ForeignKey("ProjectId")]
        public int ProjectId { get; set; }

        [ForeignKey("SenderId")]
        public int SenderId { get; set; }

        public string? Description { get; set; }

        public double CalcShare { get; set; }

        public DateTime TransactionDate { get; set; }

        // Navigation Properties
        public ApplicationUser? Sender { get; set; }
        public Project? Project { get; set; }
    }
}
