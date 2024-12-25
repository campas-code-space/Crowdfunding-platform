using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EndeKissie.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; } // Primary Key

        [ForeignKey("ProjectId")]
        public int ProjectId { get; set; }

        [Required]
        public int UserId { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        // Navigation Properties
        public ApplicationUser? User { get; set; }
        public Project? Project { get; set; }
    }
}
