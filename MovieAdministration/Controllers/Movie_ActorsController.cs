using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieAdministration.Models;

namespace MovieAdministration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Movie_ActorsController : ControllerBase
    {
        private readonly MovieAdministrationDbContext _context;

        public Movie_ActorsController(MovieAdministrationDbContext context)
        {
            _context = context;
        }

        // GET: api/Movie_Actors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie_Actors>>> GetMovie_Actors_1()
        {
            return await _context.Movie_Actors_1.ToListAsync();
        }

        // GET: api/Movie_Actors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie_Actors>> GetMovie_Actors(int id)
        {
            var movie_Actors = await _context.Movie_Actors_1.FindAsync(id);

            if (movie_Actors == null)
            {
                return NotFound();
            }

            return movie_Actors;
        }

        // PUT: api/Movie_Actors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovie_Actors(int id, Movie_Actors movie_Actors)
        {
            if (id != movie_Actors.Id)
            {
                return BadRequest();
            }

            _context.Entry(movie_Actors).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Movie_ActorsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Movie_Actors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Movie_Actors>> PostMovie_Actors(Movie_Actors movie_Actors)
        {
            _context.Movie_Actors_1.Add(movie_Actors);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovie_Actors", new { id = movie_Actors.Id }, movie_Actors);
        }

        // DELETE: api/Movie_Actors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie_Actors(int id)
        {
            var movie_Actors = await _context.Movie_Actors_1.FindAsync(id);
            if (movie_Actors == null)
            {
                return NotFound();
            }

            _context.Movie_Actors_1.Remove(movie_Actors);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Movie_ActorsExists(int id)
        {
            return _context.Movie_Actors_1.Any(e => e.Id == id);
        }
    }
}
