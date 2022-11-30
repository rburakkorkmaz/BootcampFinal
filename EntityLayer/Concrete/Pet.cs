using EntityLayer.Abstract;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Pet : BaseEntity
    {
        [StringLength(25)]
        public string? Name { get; set; }

        [StringLength(50)]
        public string? Breed { get; set; }

        [StringLength(25)]
        public string? Species { get; set; }

        [Range(0, 30, ErrorMessage = "Yaş değeri pozitif olabilir ve max 30 değerini alabilir")]
        public int? Age { get; set; }

        [Required]
        [StringLength(50)]
        public string Health { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool IsMissing { get; set; }

        [StringLength(200)]
        public string? Description { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

    }
}
