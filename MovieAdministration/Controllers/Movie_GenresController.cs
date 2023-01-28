using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieAdministration.Models;

namespace MovieAdministration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Movie_GenresController : ControllerBase
    {
        private readonly MovieAdministrationDbContext _context;

        public Movie_GenresController(MovieAdministrationDbContext context)
        {
            _context = context;
        }

        // GET: api/Movie_Genres
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie_Genres>>> GetMovie_Genres()
        {
            return await _context.Movie_Genres.ToListAsync();
        }

        // GET: api/Movie_Genres/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie_Genres>> GetMovie_Genres(int id)
        {
            var movie_Genres = await _context.Movie_Genres.FindAsync(id);

            if (movie_Genres == null)
            {
                return NotFound();
            }

            return movie_Genres;
        }

        // PUT: api/Movie_Genres/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovie_Genres(int id, Movie_Genres movie_Genres)
        {
            if (id != movie_Genres.Id)
            {
                return BadRequest();
            }

            _context.Entry(movie_Genres).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Movie_GenresExists(id))
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

        // POST: api/Movie_Genres
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Movie_Genres>> PostMovie_Genres(Movie_Genres movie_Genres)
        {
            _context.Movie_Genres.Add(movie_Genres);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovie_Genres", new { id = movie_Genres.Id }, movie_Genres);
        }

        // DELETE: api/Movie_Genres/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie_Genres(int id)
        {
            var movie_Genres = await _context.Movie_Genres.FindAsync(id);
            if (movie_Genres == null)
            {
                return NotFound();
            }

            _context.Movie_Genres.Remove(movie_Genres);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Movie_GenresExists(int id)
        {
            return _context.Movie_Genres.Any(e => e.Id == id);
        }
    }
}
