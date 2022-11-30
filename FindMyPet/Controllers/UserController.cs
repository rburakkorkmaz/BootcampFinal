using AutoMapper;
using BusinessLayer.Concrete;
using BusinessLayer.Validation.UserValidations;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using EntityLayer.Concrete.PetVM;
using EntityLayer.Concrete.UserVM;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FindMyPet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        UserManager userManager = new UserManager(new UserRepository());
        private readonly IMapper _mapper;
        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }


        /// <summary>
        /// Get All Users
        /// </summary>
        [HttpGet]
        public IEnumerable<UserDTO> Get()
        {
            return _mapper.Map<IEnumerable<UserDTO>>(userManager.GetUsers());
        }

        /// <summary>
        /// Get an User by its ID
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDTO>> Get(int id)
        {
            var result = await userManager.GetById(id);

            if (result == null)
                return NotFound();

            return _mapper.Map<UserDTO>(result);
        }


        /// <summary>
        /// Get an Address of User by its id
        /// </summary>
        [HttpGet("{id}/Address")]
        public async Task<ActionResult<string>> GetAddress(int id)
        {
            var result = await userManager.GetAddress(id);

            if (result == null)
                return NotFound();

            return result;
        }

        /// <summary>
        /// Get an Username of User by its id
        /// </summary>
        [HttpGet("{id}/Username")]
        public async Task<ActionResult<string>> GetUsername(int id)
        {
            var result = await userManager.GetUsername(id);

            if (result == null)
                return NotFound();

            return result;
        }

        /// <summary>
        /// Get an Pets of User by its id
        /// </summary>
        [HttpGet("{id}/Pets")]
        public async Task<ActionResult<IEnumerable<UserPetGetDTO>>> GetPets(int id)
        {
            var result = _mapper.Map<IEnumerable<UserPetGetDTO>>(await userManager.GetPets(id));

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        /// <summary>
        /// Get an Pets Found of User by its id
        /// </summary>
        [HttpGet("{id}/PetsFound")]
        public async Task<ActionResult<int>> GetPetsFound(int id)
        {
            var result = await userManager.GetPetsFound(id);

            if (result == null)
                return NotFound();

            return result;

        }

        /// <summary>
        /// Get an Phone number of User by its id
        /// </summary>
        [HttpGet("{id}/Phonenumber")]
        public async Task<ActionResult<string>> GetPhoneNumber(int id)
        {
            var result = await userManager.GetPhoneNumber(id);

            if (result == null)
                return NotFound();

            return result;
        }

        /// <summary>
        /// Get an Password of User by its id
        /// </summary>
        [HttpGet("{id}/Password")]
        public async Task<ActionResult<string>> GetPassword(int id)
        {
            var result = await userManager.GetPassword(id);

            return result != null ? result : NotFound();
        }

        /// <summary>
        /// Create a new User
        /// </summary>
        [HttpPost]
        public async Task<ActionResult> Post(UserPostDTO userDto)
        {
            UserPostDTOValidator wv = new UserPostDTOValidator();
            ValidationResult results = wv.Validate(userDto);

            if (results.IsValid)
            {
                var user = _mapper.Map<User>(userDto);
                await userManager.UserAdd(user);

                return Ok(user);
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
        /// Update an existing User
        /// </summary>
        [HttpPut]
        public async Task<ActionResult> Put(int id, UserPutDTO userDto)
        {
            UserPutDTOValidator wv = new UserPutDTOValidator();
            ValidationResult results = wv.Validate(userDto);


            if (results.IsValid)
            {
                var user = await userManager.GetById(id);
                var mappedEntity = _mapper.Map(userDto, user);
                await userManager.Save();

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
        /// Delete an existing User
        /// </summary>
        [HttpDelete]
        public async Task Delete(int id)
        {
            await userManager.UserDelete(id);
        }

    }
}
