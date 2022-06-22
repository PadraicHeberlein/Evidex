using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Evidex.Utilities.EnumTypes;

namespace Evidex.Models
{
    public class UserModel
    {
        [Key]
        public string UserName { get; set; }
        
        [DataType(DataType.DateTime)]
        public DateTime SignedUpAt { get; set; }
        
        public IdentityUserToken<string> Token { get; }

        public ProfileModel Profile { get; set; }

        public UserType Type { get; set; }
    }
}
