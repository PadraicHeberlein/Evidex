using System.ComponentModel.DataAnnotations;

namespace Evidex.Models
{
    public class ClaimModel : IndexItemModel
    {
        [Required]
        [StringLength(250, 
            ErrorMessage ="A claim should be 50-250 characters.", 
            MinimumLength = 50)]
        public string Claim { get; set; }
    }
}
