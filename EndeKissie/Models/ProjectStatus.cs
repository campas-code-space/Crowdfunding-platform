using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EndeKissie.Models
{
    public class ProjectStatus
    {
        [Key]
        public int Id { get; set; } // Primary Key

        [ForeignKey("ProjectId")]
        public int ProjectId { get; set; }

        public bool Banned { get; set; } = false;

        public bool Funded { get; set; } = false;

        [ForeignKey("SenderId")]
        public int SenderId { get; set; }

        public string? Description { get; set; }

        public DateTime TimeDeadline { get; set; }

        public double FundedAmout { get; set; }
        // if the deadline passed without this property be 0 then send founder into to inverstots

        // Navigation Properties
        public Project? Project { get; set; }
        public ApplicationUser? Sender { get; set; }
    }
}
