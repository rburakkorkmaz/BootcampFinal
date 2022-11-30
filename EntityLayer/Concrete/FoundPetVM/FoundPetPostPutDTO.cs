using EntityLayer.Concrete.PetVM;

namespace EntityLayer.Concrete.FoundPetVM
{

    public class FoundPetPostPutDTO : PetPostDTO
    {
        public DateTime FindingDate { get; set; }

        public string? FoundAddress { get; set; }
    }
}
