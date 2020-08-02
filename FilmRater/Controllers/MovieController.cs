using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmRater.ApiModels;
using FilmRater.Core.Models;
using FilmRater.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmRater.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService myMovieService)
        {
            _movieService = myMovieService;
        }
        // GET api/entrainment
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_movieService.GetAll().ToApiModels());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("GetMovie", ex.Message);
                return BadRequest(ModelState);
            }

        }

        [HttpGet("/Api/User/{userId}/movie")]
        public IActionResult GetMovieForUser(int userId)
        {
            return Ok(_movieService.GetMovieForUser(userId).ToApiModels());
        }

        // GET api/entrainment/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var movie = _movieService.Get(id);
            if (movie == null) return NotFound();
            return Ok(movie);
        }

        // POST api/entrainment
        [HttpPost]
        public IActionResult Post([FromBody] Movie myNewMovie)
        {
            var movie = _movieService.Add(myNewMovie);
            if (movie == null) return BadRequest();
            return CreatedAtAction("Get", new { Id = myNewMovie.Id }, myNewMovie);
        }

        // PUT api/entrainment/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Movie myUpdatedMovie)
        {
            var movie = _movieService.Update(myUpdatedMovie);
            if (movie == null) return BadRequest();
            return Ok(movie);
        }

        // DELETE api/entrainment/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var movie = _movieService.Get(id);
            _movieService.Delete(movie);
            return NoContent();
        }
    }
}
