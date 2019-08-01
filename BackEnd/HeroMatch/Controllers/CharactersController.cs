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
    public class CharacterController : Controller
    {
        IRepository<Character> charRepos;

        public CharacterController(IRepository<Character> charRepos)
        {
            this.charRepos = charRepos;
        }

        public ViewResult AllCharacters()
        {
            var model = charRepos.GetAll();
            return View(model);
        }

        public object SingleCharacter(Character character)
        {
            var model = charRepos.GetByProperties(character);
            return View(model);
        }

        

    }
}