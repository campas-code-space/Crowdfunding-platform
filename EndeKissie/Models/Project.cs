using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EndeKissie.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; } // Primary Key

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        [ForeignKey("ImageId")]
        public int ImageId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string Category { get; set; } = null!;

        [Required]
        public string Size { get; set; } = null!;


        public byte[]? ProjectImage { get; set; } // direct DB store


        public DateTime NeedDeadLineTime { get; set; }

        public DateTime? SubmissionDeadLineTime { get; set; }

        [Required]
        public decimal TargetAmount { get; set; }

        public string Description { get; set; } = null!;

        // Navigation Properties
        public ApplicationUser? User { get; set; }
        public List<Comment>? Comments { get; set; }
        public List<ImageStore>? Images { get; set; }
        public List<Transaction>? Transactions { get; set; }
        public List<ProjectStatus>? ProjectStats { get; set; }
    }
}
