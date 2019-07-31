using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HeroMatch;
using HeroMatch.Models;

namespace HeroMatch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        private readonly SiteContext _context;

        public CharactersController(SiteContext context)
        {
            _context = context;
        }

        // GET: api/Characters
        [HttpGet]
        public IEnumerable<Character> GetCharacter()
        {
            return _context.Character;
        }

        // GET: api/Characters/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCharacter([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var character = await _context.Character.FindAsync(id);

            if (character == null)
            {
                return NotFound();
            }

            return Ok(character);
        }

        private bool CharacterExists(int id)
        {
            return _context.Character.Any(e => e.CharacterId == id);
        }
    }
}