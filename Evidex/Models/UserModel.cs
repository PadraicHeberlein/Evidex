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

        public Guid ProfileID { get;}
    }
}
