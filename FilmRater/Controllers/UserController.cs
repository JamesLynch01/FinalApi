using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FilmRater.Core.Services;
using FilmRater.ApiModels;

namespace FilmRater.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var userModels = _userService.GetAll().ToApiModels();
            return Ok(userModels);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = _userService.Get(id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Post([FromBody] UserModel newUser)
        {
            try
            {
                // add the new user
                _userService.Add(newUser.ToDomainModel());
            }
            catch (System.Exception ex)
            {
                ModelState.AddModelError("AddUser", ex.GetBaseException().Message);
                return BadRequest(ModelState);
            }

            return CreatedAtAction("Get", new { Id = newUser.Id }, newUser);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UserModel updatedUser)
        {
            var user = _userService.Update(updatedUser.ToDomainModel());
            if (user == null) return NotFound();
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = _userService.Get(id);
            if (user == null) return NotFound();
            _userService.Remove(user);
            return NoContent();
        }
    }
}
