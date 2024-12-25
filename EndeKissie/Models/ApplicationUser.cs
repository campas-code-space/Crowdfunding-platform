using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace EndeKissie.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int AccountNum { get; set; } 
        public byte[] UserImage { get; set; } = null!;

        [ForeignKey("ImageId")]
        public int ImageId { get; set; }
        public List<ImageStore>? Images { get; set; }
    }
}
