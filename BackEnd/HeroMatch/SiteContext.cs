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
                    CharacterId = 1,
                    Name = "Reinhardt",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/reinhardt/hero-select-portrait.png",
                    Difficulty = 1,
                    Role = 1,
                    SubRole = 1
                },
                new Character
                {
                    CharacterId = 2,
                    Name = "Orisa",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/orisa/hero-select-portrait.png",
                    Difficulty = 2,
                    Role = 1,
                    SubRole = 1
                },
                new Character
                {
                    CharacterId = 3,
                    Name = "D. Va",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/dva/hero-select-portrait.png",
                    Difficulty = 3,
                    Role = 1,
                    SubRole = 1
                },
                new Character
                {
                    CharacterId = 4,
                    Name = "Winston",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/winston/hero-select-portrait.png",
                    Difficulty = 2,
                    Role = 1,
                    SubRole = 1
                },
                new Character
                {
                    CharacterId = 5,
                    Name = "Roadhog",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/roadhog/hero-select-portrait.png",
                    Difficulty = 1,
                    Role = 1,
                    SubRole = 2
                },
                new Character
                {
                    CharacterId = 6,
                    Name = "Wrecking Ball",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/wrecking-ball/hero-select-portrait.png",
                    Difficulty = 2,
                    Role = 1,
                    SubRole = 2
                },
                new Character
                {
                    CharacterId = 7,
                    Name = "Sigma",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/sigma/hero-select-portrait.png",
                    Difficulty = 3,
                    Role = 1,
                    SubRole = 2
                },
                new Character
                {
                    CharacterId = 8,
                    Name = "Zarya",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/zarya/hero-select-portrait.png",
                    Difficulty = 3,
                    Role = 1,
                    SubRole = 2,
                },
                new Character
                {
                    CharacterId = 9,
                    Name = "Ashe",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/ashe/hero-select-portrait.png",
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 1
                },
                new Character
                {
                    CharacterId = 10,
                    Name = "McCree",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/mccree/hero-select-portrait.png",
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 1
                },
                new Character
                {
                    CharacterId = 11,
                    Name = "Hanzo",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/hanzo/hero-select-portrait.png",
                    Difficulty = 3,
                    Role = 2,
                    SubRole = 1
                },
                new Character
                {
                    CharacterId = 12,
                    Name = "Widowmaker",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/widowmaker/hero-select-portrait.png",
                    Difficulty = 3,
                    Role = 2,
                    SubRole = 1
                },
                new Character
                {
                    CharacterId = 13,
                    Name = "Soldier: 76",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/soldier-76/hero-select-portrait.png",
                    Difficulty = 1,
                    Role = 2,
                    SubRole = 1
                },
                new Character
                {
                    CharacterId = 14,
                    Name = "Reaper",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/reaper/hero-select-portrait.png",
                    Difficulty = 1,
                    Role = 2,
                    SubRole = 2
                },
                new Character
                {
                    CharacterId = 15,
                    Name = "Sombra",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/sombra/hero-select-portrait.png",
                    Difficulty = 3,
                    Role = 2,
                    SubRole = 2,
                },
                new Character
                {
                    CharacterId = 16,
                    Name = "Genji",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/genji/hero-select-portrait.png",
                    Difficulty = 3,
                    Role = 2,
                    SubRole = 2,
                },
                new Character
                {
                    CharacterId = 17,
                    Name = "Doomfist",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/doomfist/hero-select-portrait.png",
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 2
                },
                new Character
                {
                    CharacterId = 18,
                    Name = "Tracer",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/tracer/hero-select-portrait.png",
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 2
                },
                new Character
                {
                    CharacterId = 19,
                    Name = "Torbjörn",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/torbjorn/hero-select-portrait.png",
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 3
                },
                new Character
                {
                    CharacterId = 20,
                    Name = "Symmetra",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/symmetra/hero-select-portrait.png",
                    Difficulty = 3,
                    Role = 2,
                    SubRole = 3
                },
                new Character
                {
                    CharacterId = 21,
                    Name = "Pharah",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/pharah/hero-select-portrait.png",
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 3
                },
                new Character
                {
                    CharacterId = 22,
                    Name = "Mei",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/mei/hero-select-portrait.png",
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 3
                },
                new Character
                {
                    CharacterId = 23,
                    Name = "Junkrat",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/junkrat/hero-select-portrait.png",
                    Difficulty = 1,
                    Role = 2,
                    SubRole = 3
                },
                new Character
                {
                    CharacterId = 24,
                    Name = "Bastion",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/bastion/hero-select-portrait.png",
                    Difficulty = 1,
                    Role = 2,
                    SubRole = 3,
                },
                new Character
                {
                    CharacterId = 25,
                    Name = "Baptiste",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/baptiste/hero-select-portrait.png",
                    Difficulty = 2,
                    Role = 3,
                    SubRole = 1
                },
                new Character
                {
                    CharacterId = 26,
                    Name = "Brigitte",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/brigitte/hero-select-portrait.png",
                    Difficulty = 1,
                    Role = 3,
                    SubRole = 1,
                },
                new Character
                {
                    CharacterId = 27,
                    Name = "Ana",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/ana/hero-select-portrait.png",
                    Difficulty = 3,
                    Role = 3,
                    SubRole = 1

                },
                new Character
                {
                    CharacterId = 28,
                    Name = "Lúcio",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/lucio/hero-select-portrait.png",
                    Difficulty = 2,
                    Role = 3,
                    SubRole = 2

                },
                new Character
                {
                    CharacterId = 29,
                    Name = "Mercy",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/mercy/hero-select-portrait.png",
                    Difficulty = 1,
                    Role = 3,
                    SubRole = 2
                },
                new Character
                {
                    CharacterId = 30,
                    Name = "Moira",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/moira/hero-select-portrait.png",
                    Difficulty = 2,
                    Role = 3,
                    SubRole = 2
                },
                new Character
                {
                    CharacterId = 31,
                    Name = "Zenyatta",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/zenyatta/hero-select-portrait.png",
                    Difficulty = 3,
                    Role = 3,
                    SubRole = 2
                }
                );





        }

    }

}
