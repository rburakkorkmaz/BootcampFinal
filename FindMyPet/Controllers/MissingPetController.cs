using AutoMapper;
using BusinessLayer.Concrete;
using BusinessLayer.Validation.MissingPetValidations;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using EntityLayer.Concrete.MissingPetVM;
using EntityLayer.Concrete.UserVM;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace FindMyPet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MissingPetController : Controller
    {
        MissingPetManager missingPetManager = new MissingPetManager(new MissingPetRepository());
        private readonly IMapper _mapper;
        public MissingPetController(IMapper mapper)
        {
            _mapper = mapper;
        }

        /// <summary>
        /// Get all missing pets
        /// </summary>
        [HttpGet]
        public IEnumerable<MissingPetGetDTO> Get()
        {
            return _mapper.Map<IEnumerable<MissingPetGetDTO>>(missingPetManager.GetMissingPets());
        }

        /// <summary>
        /// Get a missing pet by its ID
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<MissingPetGetDTO>> Get(int id)
        {
            var result = await missingPetManager.GetById(id);

            if (result == null)
                return NotFound();


            return _mapper.Map<MissingPetGetDTO>(result);
        }

        /// <summary>
        /// Get address of missing pet by its ID
        /// </summary>
        [HttpGet("{id}/MissingPetAddress")]
        public async Task<ActionResult<string>> GetMissingAddress(int id)
        {
            var result = await missingPetManager.GetMissingAddress(id);

            return result != null ? result : NotFound();
        }

        /// <summary>
        /// Get missing date of missing pet by its ID
        /// </summary>
        [HttpGet("{id}/MissingDate")]
        public async Task<ActionResult<DateTime>> GetMissingDate(int id)
        {
            var result = await missingPetManager.GetMissingDate(id);

            return result != null ? result : NotFound();
        }

        /// <summary>
        /// Get Owner of missing pet by its ID
        /// </summary>
        [HttpGet("{id}/Owner")]
        public async Task<ActionResult<UserDTO>> GetOwner(int id)
        {
            var result = await missingPetManager.GetOwner(id);

            return result != null ? _mapper.Map<UserDTO>(result) : NotFound();
        }

        /// <summary>
        /// Get Description of missing pet by its ID
        /// </summary>
        [HttpGet("{id}/Description")]
        public async Task<ActionResult<string>> GetDescription(int id)
        {
            var result = await missingPetManager.GetDescription(id);

            return result != null ? result : NotFound();
        }

        /// <summary>
        /// Create a new Missing Pet
        /// </summary>
        [HttpPost]
        public async Task<ActionResult> Post(MissingPetPostPutDTO missingPetDto)
        {
            MissingPetPutDTOValidator wv = new MissingPetPutDTOValidator();
            ValidationResult results = wv.Validate(missingPetDto);

            if (results.IsValid)
            {
                var missingPet = _mapper.Map<MissingPet>(missingPetDto);
                await missingPetManager.MissingPetAdd(missingPet);

                return Ok(missingPet);
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
        /// Update a missing pet
        /// </summary>
        [HttpPut]
        public async Task<ActionResult> Put(int id, MissingPetPostPutDTO missingPetDto)
        {
            MissingPetPutDTOValidator wv = new MissingPetPutDTOValidator();
            ValidationResult results = wv.Validate(missingPetDto);

            if (results.IsValid)
            {
                var missingPet = await missingPetManager.GetById(id);
                var mappedEntity = _mapper.Map(missingPetDto, missingPet);
                await missingPetManager.Save();

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
        /// Delete an existing missing pet
        /// </summary>
        [HttpDelete]
        public async Task Delete(int id)
        {
            await missingPetManager.MissingPetDelete(id);
        }
    }
}
