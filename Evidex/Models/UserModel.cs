using System.ComponentModel.DataAnnotations;

namespace Evidex.Models
{
    public class UserModel
    {
        [Key]
        public Guid UserId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "User name must be of " +
            "positive length less than 100 charachters.",
            MinimumLength = 1)]
        [Display(Name = "User name:")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "First name must be of " +
            "positive length less than 100 charachters.",
            MinimumLength = 1)]
        [Display(Name = "Last name:")]
        public string LastName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Last name must be of " +
            "positive length less than 100 charachters.",
            MinimumLength = 1)]
        [Display(Name = "First name:")]
        public string FirstName { get; set; }

        [Display(Name = "Email address:")]
        public string? Email { get; set; }

        public Guid? ProfileID { get; }
    }
}
