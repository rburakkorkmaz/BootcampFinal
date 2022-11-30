using EntityLayer.Abstract;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class User : BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        public string Surname { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }


        [StringLength(200)]
        public string? Address { get; set; }


        [Range(0, 250)]
        [DefaultValue(0)]
        public int PetsFound { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }

    }
}
