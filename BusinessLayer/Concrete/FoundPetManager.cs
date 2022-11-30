using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class FoundPetManager : IFoundPetService
    {
        IFoundPetRepository _foundPetRepository;

        public FoundPetManager(IFoundPetRepository foundPetRepository)
        {
            _foundPetRepository = foundPetRepository;
        }

        public async Task<User?> GetFinder(int id)
        {
            return await _foundPetRepository.GetFinder(id);
        }

        public async Task<DateTime?> GetFindingDate(int id)
        {
            return await _foundPetRepository.GetFindingDate(id);
        }

        public async Task<string?> GetFoundAddress(int id)
        {
            return await _foundPetRepository.GetFoundAddress(id);
        }

        public async Task<string?> GetDescription(int id)
        {
            return await _foundPetRepository.GetDescription(id);
        }

        public async Task FoundPetAdd(FoundPet foundPet)
        {
            await _foundPetRepository.Create(foundPet);
        }

        public async Task FoundPetDelete(FoundPet foundPet)
        {
            await _foundPetRepository.Delete(foundPet);
        }
        public async Task FoundPetDelete(int id)
        {
            await _foundPetRepository.Delete(id);
        }

        public async Task FoundPetUpdate(FoundPet foundPet)
        {
            await _foundPetRepository.Update(foundPet);
        }

        public async Task<FoundPet?> GetById(int id)
        {
            return await _foundPetRepository.GetById(id);
        }

        public List<FoundPet> GetFoundPets()
        {
            return _foundPetRepository.GetAll();
        }
        public async Task<bool> Save()
        {
            return await _foundPetRepository.Save();
        }
    }
}
