namespace EntityLayer.Concrete.PetVM
{
    public class PetDTO
    {
        public string? Name { get; set; }

        public string? Breed { get; set; }

        public string? Species { get; set; }

        public int? Age { get; set; }

        public string Health { get; set; }

        public bool IsMissing { get; set; }

        public string? Description { get; set; }

        public virtual PetUserGetDTO User { get; set; }
    }
}
