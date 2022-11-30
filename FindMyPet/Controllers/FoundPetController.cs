using AutoMapper;
using BusinessLayer.Concrete;
using BusinessLayer.Validation.FoundPetValidations;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using EntityLayer.Concrete.FoundPetVM;
using EntityLayer.Concrete.UserVM;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace FindMyPet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoundPetController : Controller
    {
        FoundPetManager foundPetManager = new FoundPetManager(new FoundPetRepository());
        private readonly IMapper _mapper;
        public FoundPetController(IMapper mapper)
        {
            _mapper = mapper;
        }

        /// <summary>
        /// Get all found pets
        /// </summary>
        [HttpGet]
        public List<FoundPetGetDTO> Get()
        {
            return _mapper.Map<List<FoundPetGetDTO>>(foundPetManager.GetFoundPets());
        }

        /// <summary>
        /// Get a found pet by its ID
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<FoundPetGetDTO>> Get(int id)
        {
            var result = await foundPetManager.GetById(id);

            if (result == null)
                return NotFound();

            return _mapper.Map<FoundPetGetDTO>(result);
        }

        /// <summary>
        /// Get finder of a found pet by its ID
        /// </summary>
        [HttpGet("{id}/Finder")]
        public async Task<ActionResult<UserDTO>> GetFinder(int id)
        {
            var result = await foundPetManager.GetFinder(id);

            return result != null ? _mapper.Map<UserDTO>(result) : NotFound();
        }

        /// <summary>
        /// Get finding date of a found pet by its ID
        /// </summary>
        [HttpGet("{id}/FindingDate")]
        public async Task<ActionResult<DateTime>> GetFindingDate(int id)
        {
            var result = await foundPetManager.GetFindingDate(id);

            return result != null ? result : NotFound();
        }

        /// <summary>
        /// Get found address of a found pet by its ID
        /// </summary>
        [HttpGet("{id}/FoundAddress")]
        public async Task<ActionResult<string>> GetFoundAddress(int id)
        {
            var result = await foundPetManager.GetFoundAddress(id);

            return result != null ? result : NotFound();
        }

        /// <summary>
        /// Get Description of a found pet by its ID
        /// </summary>
        [HttpGet("{id}/Description")]
        public async Task<ActionResult<string>> GetDescription(int id)
        {
            var result = await foundPetManager.GetDescription(id);

            return result != null ? result : NotFound();
        }

        /// <summary>
        /// Create a new found pet
        /// </summary>
        [HttpPost]
        public async Task<ActionResult> Post(FoundPetPostPutDTO foundPetDto)
        {
            FoundPetPutDTOValidator wv = new FoundPetPutDTOValidator();
            ValidationResult results = wv.Validate(foundPetDto);

            if (results.IsValid)
            {
                var foundPet = _mapper.Map<FoundPet>(foundPetDto);
                await foundPetManager.FoundPetAdd(foundPet);

                return Ok(foundPet);
            }
            else
            {
                foreach (var failure in results.Errors)
                {
                    ModelState.AddModelError(failure.PropertyName, failure.ErrorMessage);
                }

                return BadRequest(ModelState);
            }
        }

        /// <summary>
        /// Update a found pet
        /// </summary>
        [HttpPut]
        public async Task<ActionResult> Put(int id, FoundPetPostPutDTO foundPetDto)
        {
            FoundPetPutDTOValidator wv = new FoundPetPutDTOValidator();
            ValidationResult results = wv.Validate(foundPetDto);

            if (results.IsValid)
            {
                var foundPet = await foundPetManager.GetById(id);
                var mappedEntity = _mapper.Map(foundPetDto, foundPet);
                await foundPetManager.Save();

                return Ok();
            }
            else
            {
                foreach (var failure in results.Errors)
                {
                    ModelState.AddModelError(failure.PropertyName, failure.ErrorMessage);
                }

                return BadRequest(ModelState);
            }
        }

        /// <summary>
        /// Delete a found pet
        /// </summary>
        [HttpDelete]
        public async Task Delete(int id)
        {
            await foundPetManager.FoundPetDelete(id);
        }
    }
}
