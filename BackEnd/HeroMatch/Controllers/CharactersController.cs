using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HeroMatch;
using HeroMatch.Models;
using HeroMatch.Repositories;

namespace HeroMatch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        IRepository<Character> charRepos;
        private SiteContext db;

        public CharactersController(SiteContext db)
        {
            this.db = db; 
        }

        [HttpGet]
        public ActionResult<IEnumerable<Character>> Get()
        {
            return db.Character;
        }

        [HttpGet("{difficulty}/{role}/{subRole}")]
        public ActionResult<Character> GetByProperties(int difficulty, int role, int subRole)
        {
            Character obj = new Character(difficulty, role, subRole);
            return db.Character.Single(c => c.Difficulty == obj.Difficulty && c.Role == obj.Role && c.SubRole == obj.SubRole);
            
        }

    }
}