using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IMissingPetService
    {
        Task MissingPetAdd(MissingPet missingPet);
        Task MissingPetDelete(MissingPet missingPet);
        Task MissingPetUpdate(MissingPet missingPet);
        List<MissingPet> GetMissingPets();
        Task<MissingPet> GetById(int id);
    }
}
