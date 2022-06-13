using System.ComponentModel.DataAnnotations;

namespace Evidex.Models
{
    public class IndexItemModel
    {
        [Key]
        public Guid Id { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CatalogedAt { get; set; }
    }
}
