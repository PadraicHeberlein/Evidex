using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Evidex.Utilities.EnumTypes;

namespace Evidex.Models
{
    public class UserModel
    {
        [Key]
        [StringLength(100)]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Signed Up At")]
        public DateTime SignedUpAt { get; set; }

        [Required]
        public UserType Type { get; set; }

        public IdentityUserToken<string> Token { get; }

        public ProfileModel Profile { get; set; }
    }
}
