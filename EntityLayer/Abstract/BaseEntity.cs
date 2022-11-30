using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Abstract
{
    public abstract class BaseEntity : IEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public int UpdatedBy { get; set; }
        public DateTime DeletedAt { get; set; } = DateTime.Now;
        public int DeletedBy { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
