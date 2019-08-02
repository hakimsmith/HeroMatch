using HeroMatch.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroMatch
{
    public class SiteContext : DbContext
    {
        public DbSet<Character> Character { get; set; }
        public DbSet<Filter> Filter { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=HeroMatch;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString);
            //UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().HasData(
                new Character
                {
                    GameId = 1,
                    CharacterId = 1,
                    Name = "Reinhardt",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/reinhardt/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/reinhardt/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/reinhardt/",
                    Difficulty = 1,
                    Role = 1,
                    SubRole = 1
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 2,
                    Name = "Orisa",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/orisa/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/orisa/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/orisa/",
                    Difficulty = 2,
                    Role = 1,
                    SubRole = 1
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 3,
                    Name = "D. Va",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/dva/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/dva/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/dva/",
                    Difficulty = 3,
                    Role = 1,
                    SubRole = 1
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 4,
                    Name = "Winston",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/winston/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/winston/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/Winston/",
                    Difficulty = 2,
                    Role = 1,
                    SubRole = 1
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 5,
                    Name = "Roadhog",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/roadhog/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/roadhog/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/roadhog/",
                    Difficulty = 1,
                    Role = 1,
                    SubRole = 2
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 6,
                    Name = "Wrecking Ball",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/wrecking-ball/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/wrecking-ball/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/wrecking-ball/",
                    Difficulty = 2,
                    Role = 1,
                    SubRole = 2
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 7,
                    Name = "Sigma",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/sigma/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/sigma/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/sigma/",
                    Difficulty = 3,
                    Role = 1,
                    SubRole = 2
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 8,
                    Name = "Zarya",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/zarya/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/zarya/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/zarya/",
                    Difficulty = 3,
                    Role = 1,
                    SubRole = 2,
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 9,
                    Name = "Ashe",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/ashe/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/ashe/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/ashe/",
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 1
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 10,
                    Name = "McCree",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/mccree/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/mccree/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/mccree/",
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 1
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 11,
                    Name = "Hanzo",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/hanzo/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/hanzo/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/hanzo/",
                    Difficulty = 3,
                    Role = 2,
                    SubRole = 1
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 12,
                    Name = "Widowmaker",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/widowmaker/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/widowmaker/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/widowmaker/",
                    Difficulty = 3,
                    Role = 2,
                    SubRole = 1
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 13,
                    Name = "Soldier: 76",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/soldier-76/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/soldier-76/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/soldier-76/",
                    Difficulty = 1,
                    Role = 2,
                    SubRole = 1
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 14,
                    Name = "Reaper",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/reaper/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/reaper/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/reaper/",
                    Difficulty = 1,
                    Role = 2,
                    SubRole = 2
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 15,
                    Name = "Sombra",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/sombra/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/sombra/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/sombra/",
                    Difficulty = 3,
                    Role = 2,
                    SubRole = 2,
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 16,
                    Name = "Genji",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/genji/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/genji/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/genji/",
                    Difficulty = 3,
                    Role = 2,
                    SubRole = 2,
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 17,
                    Name = "Doomfist",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/doomfist/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/doomfist/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/doomfist/",
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 2
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 18,
                    Name = "Tracer",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/tracer/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/tracer/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/tracer/",
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 2
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 19,
                    Name = "Torbjörn",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/torbjorn/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/torbjorn/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/torbjorn/",
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 3
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 20,
                    Name = "Symmetra",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/symmetra/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/symmetra/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/symmetra/",
                    Difficulty = 3,
                    Role = 2,
                    SubRole = 3
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 21,
                    Name = "Pharah",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/pharah/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/pharah/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/pharah/",
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 3
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 22,
                    Name = "Mei",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/mei/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/mei/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/mei/",
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 3
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 23,
                    Name = "Junkrat",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/junkrat/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/junkrat/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/junkrat/",
                    Difficulty = 1,
                    Role = 2,
                    SubRole = 3
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 24,
                    Name = "Bastion",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/bastion/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/bastion/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/bastion/",
                    Difficulty = 1,
                    Role = 2,
                    SubRole = 3,
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 25,
                    Name = "Baptiste",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/baptiste/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/baptiste/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/baptiste/",
                    Difficulty = 2,
                    Role = 3,
                    SubRole = 1
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 26,
                    Name = "Brigitte",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/brigitte/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/brigitte/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/brigitte/",
                    Difficulty = 1,
                    Role = 3,
                    SubRole = 1,
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 27,
                    Name = "Ana",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/ana/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/ana/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/ana/",
                    Difficulty = 3,
                    Role = 3,
                    SubRole = 1

                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 28,
                    Name = "Lúcio",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/lucio/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/lucio/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/lucio/",
                    Difficulty = 2,
                    Role = 3,
                    SubRole = 2

                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 29,
                    Name = "Mercy",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/mercy/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/mercy/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/mercy/",
                    Difficulty = 1,
                    Role = 3,
                    SubRole = 2
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 30,
                    Name = "Moira",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/moira/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/moira/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/moira/",
                    Difficulty = 2,
                    Role = 3,
                    SubRole = 2
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 31,
                    Name = "Zenyatta",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/zenyatta/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/zenyatta/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/zenyatta/",
                    Difficulty = 3,
                    Role = 3,
                    SubRole = 2
                }
                );

            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    GameId = 1,
                    Name = "Overwatch",
                    Description = "Overwatch is a colorful team-based shooter game starring a diverse cast of powerful heroes. Travel the world, build a team, and contest objectives in exhilarating 6v6 combat.",
                    Download = "https://us.shop.battle.net/en-us/product/overwatch?blzcmp=ow_buy_nav",
                    Image = "https://stmed.net/sites/default/files/overwatch-hd-wallpapers-33472-8666477.jpg",
                    Video = "https://www.youtube.com/watch?v=dushZybUYnM&t=9s"

                }
                );





        }

    }

}
