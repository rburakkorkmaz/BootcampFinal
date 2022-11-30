using EntityLayer.Concrete.PetVM;

namespace EntityLayer.Concrete.MissingPetVM
{
    public class MissingPetGetDTO : PetDTO
    {
        public DateTime MissingDate { get; set; }

        public string LastSeenAddress { get; set; }
    }
}
