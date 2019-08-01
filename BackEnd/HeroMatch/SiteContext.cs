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
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/reinhardt/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 2,
                    Name = "Orisa",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/orisa/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 3,
                    Name = "D. Va",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/dva/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 4,
                    Name = "Winston",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/winston/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 5,
                    Name = "Roadhog",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/roadhog/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 6,
                    Name = "Wrecking Ball",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/wrecking-ball/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 7,
                    Name = "Sigma",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/sigma/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 8,
                    Name = "Zarya",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/zarya/hero-select-portrait.png",
                },
                new Character
                {
                    CharacterId = 9,
                    Name = "Ashe",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/ashe/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 10,
                    Name = "McCree",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/mccree/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 11,
                    Name = "Hanzo",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/hanzo/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 12,
                    Name = "Widowmaker",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/widowmaker/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 13,
                    Name = "Soldier: 76",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/soldier-76/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 14,
                    Name = "Reaper",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/reaper/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 15,
                    Name = "Sombra",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/sombra/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 16,
                    Name = "Genji",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/genji/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 17,
                    Name = "Doomfist",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/doomfist/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 18,
                    Name = "Tracer",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/tracer/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 19,
                    Name = "Torbjörn",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/torbjorn/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 20,
                    Name = "Symmetra",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/symmetra/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 21,
                    Name = "Pharah",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/pharah/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 22,
                    Name = "Mei",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/mei/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 23,
                    Name = "Junkrat",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/junkrat/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 24,
                    Name = "Bastion",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/bastion/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 25,
                    Name = "Baptiste",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/baptiste/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 26,
                    Name = "Brigitte",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/brigitte/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 27,
                    Name = "Ana",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/ana/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 28,
                    Name = "Lúcio",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/lucio/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 29,
                    Name = "Mercy",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/mercy/hero-select-portrait.png",
                },
                new Character
                {
                    CharacterId = 30,
                    Name = "Moira",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/moira/hero-select-portrait.png"
                },
                new Character
                {
                    CharacterId = 31,
                    Name = "Zenyatta",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/zenyatta/hero-select-portrait.png"
                }
                );

            modelBuilder.Entity<Filter>().HasData(
                new Filter
                {
                    FilterId = 1,
                    Difficulty = 1,
                    Role = 1,
                    SubRole = 1,
                    CharacterId = 1
                },
                new Filter
                {
                    FilterId = 2,
                    Difficulty = 2,
                    Role = 1,
                    SubRole = 1,
                    CharacterId = 2
                },
                new Filter
                {
                    FilterId = 3,
                    Difficulty = 3,
                    Role = 1,
                    SubRole = 1,
                    CharacterId = 3,
                },
                new Filter
                {
                    FilterId = 4,
                    Difficulty = 2,
                    Role = 1,
                    SubRole = 1,
                    CharacterId = 4,
                },
                new Filter
                {
                    FilterId = 5,
                    Difficulty = 1,
                    Role = 1,
                    SubRole = 2,
                    CharacterId = 5
                },
                new Filter
                {
                    FilterId = 6,
                    Difficulty = 2,
                    Role = 1,
                    SubRole = 2,
                    CharacterId = 6
                },
                new Filter
                {
                    FilterId = 7,
                    Difficulty = 3,
                    Role = 1,
                    SubRole = 2,
                    CharacterId = 7
                },
                new Filter
                {
                    FilterId = 8,
                    Difficulty = 3,
                    Role = 1,
                    SubRole = 2,
                    CharacterId = 8

                },
                new Filter
                {
                    FilterId = 9,
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 1,
                    CharacterId = 9
                },
                new Filter
                {
                    FilterId = 10,
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 1,
                    CharacterId = 10
                },
                new Filter
                {
                    FilterId = 11,
                    Difficulty = 3,
                    Role = 2,
                    SubRole = 1,
                    CharacterId = 11
                },
                new Filter
                {
                    FilterId = 12,
                    Difficulty = 3,
                    Role = 2,
                    SubRole = 1,
                    CharacterId = 12
                },
                new Filter
                {
                    FilterId = 13,
                    Difficulty = 1,
                    Role = 2,
                    SubRole = 1,
                    CharacterId = 13
                },
                new Filter
                {
                    FilterId = 14,
                    Difficulty = 1,
                    Role = 2,
                    SubRole = 2,
                    CharacterId = 14
                },
                new Filter
                {
                    FilterId = 15,
                    Difficulty = 3,
                    Role = 2,
                    SubRole = 2,
                    CharacterId = 15
                },
                new Filter
                {
                    FilterId = 16,
                    Difficulty = 3,
                    Role = 2,
                    SubRole = 2,
                    CharacterId = 16
                },
                new Filter
                {
                    FilterId = 17,
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 2,
                    CharacterId = 17
                },
                new Filter
                {
                    FilterId = 18,
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 2,
                    CharacterId = 18
                },
                new Filter
                {
                    FilterId = 19,
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 3,
                    CharacterId = 19
                },
                new Filter
                {
                    FilterId = 20,
                    Difficulty = 3,
                    Role = 2,
                    SubRole = 3,
                    CharacterId = 20
                },
                new Filter
                {
                    FilterId = 21,
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 3,
                    CharacterId = 21
                },
                new Filter
                {
                    FilterId = 22,
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 3,
                    CharacterId = 22
                },
                new Filter
                {
                    FilterId = 23,
                    Difficulty = 1,
                    Role = 2,
                    SubRole = 3,
                    CharacterId = 23
                },
                new Filter
                {
                    FilterId = 24,
                    Difficulty = 1,
                    Role = 2,
                    SubRole = 3,
                    CharacterId = 24
                },
                new Filter
                {
                    FilterId = 25,
                    Difficulty = 2,
                    Role = 3,
                    SubRole = 1,
                    CharacterId = 25
                },
                new Filter
                {
                    FilterId = 26,
                    Difficulty = 1,
                    Role = 3,
                    SubRole = 1,
                    CharacterId = 26
                },
                new Filter
                {
                    FilterId = 27,
                    Difficulty = 3,
                    Role = 3,
                    SubRole = 1,
                    CharacterId = 27
                },
                new Filter
                {
                    FilterId = 28,
                    Difficulty = 2,
                    Role = 3,
                    SubRole = 2,
                    CharacterId = 28
                },
                new Filter
                {
                    FilterId = 29,
                    Difficulty = 1,
                    Role = 3,
                    SubRole = 2,
                    CharacterId = 29
                },
                new Filter
                {
                    FilterId = 30,
                    Difficulty = 2,
                    Role = 3,
                    SubRole = 2,
                    CharacterId = 30
                },
                new Filter
                {
                    FilterId = 31,
                    Difficulty = 3,
                    Role = 3,
                    SubRole = 2,
                    CharacterId = 31
                }
                );





        }

    }

}
