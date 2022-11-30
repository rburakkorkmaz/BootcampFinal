using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class FoundPet : Pet
    {
        [Required]
        public DateTime FindingDate { get; set; } = DateTime.Now;

        [Required]
        [StringLength(300)]
        public string FoundAddress { get; set; }
    }
}
