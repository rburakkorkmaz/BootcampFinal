
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    internal interface IFoundPetService
    {
        Task FoundPetAdd(FoundPet foundPet);
        Task FoundPetDelete(FoundPet foundPet);
        Task FoundPetUpdate(FoundPet foundPet);
        List<FoundPet> GetFoundPets();
        Task<FoundPet?> GetById(int id);
    }
}
