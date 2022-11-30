using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class MissingPetManager : IMissingPetService
    {
        IMissingPetRepository _missingPetRepository;

        public MissingPetManager(IMissingPetRepository missingPetRepository)
        {
            _missingPetRepository = missingPetRepository;
        }

        public async Task<string?> GetMissingAddress(int id)
        {
            return await _missingPetRepository.GetMissingAddress(id);
        }
        public async Task<DateTime?> GetMissingDate(int id)
        {
            return await _missingPetRepository.GetMissingDate(id);
        }

        public async Task<User?> GetOwner(int id)
        {
            return await _missingPetRepository.GetOwner(id);
        }

        public async Task<string?> GetDescription(int id)
        {
            return await _missingPetRepository.GetDescription(id);
        }

        public async Task<MissingPet?> GetById(int id)
        {
            return await _missingPetRepository.GetById(id);
        }

        public List<MissingPet> GetMissingPets()
        {
            return _missingPetRepository.GetAll();
        }

        public async Task MissingPetAdd(MissingPet missingPet)
        {
            await _missingPetRepository.Create(missingPet);
        }

        public async Task MissingPetDelete(MissingPet missingPet)
        {
            await _missingPetRepository.Delete(missingPet);
        }
        public async Task MissingPetDelete(int id)
        {
            await _missingPetRepository.Delete(id);
        }

        public async Task MissingPetUpdate(MissingPet missingPet)
        {
            await _missingPetRepository.Update(missingPet);
        }
        public async Task<bool> Save()
        {
            return await _missingPetRepository.Save();
        }
    }
}
