using EntityLayer.Concrete.PetVM;

namespace EntityLayer.Concrete.FoundPetVM
{
    public class FoundPetGetDTO : PetDTO
    {
        public DateTime FindingDate { get; set; }

        public string FoundAddress { get; set; }
    }
}
