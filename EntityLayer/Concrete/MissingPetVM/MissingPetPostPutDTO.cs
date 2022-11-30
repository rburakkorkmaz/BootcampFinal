using EntityLayer.Concrete.PetVM;

namespace EntityLayer.Concrete.MissingPetVM
{
    public class MissingPetPostPutDTO : PetPostDTO
    {
        public DateTime MissingDate { get; set; }

        public string? LastSeenAddress { get; set; }
    }
}
