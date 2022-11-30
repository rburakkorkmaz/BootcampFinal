using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class MissingPet : Pet
    {
        [Required]
        public DateTime MissingDate { get; set; } = DateTime.Now;

        [Required]
        [StringLength(300)]
        public string LastSeenAddress { get; set; }
    }
}
