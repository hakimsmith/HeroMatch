﻿// <auto-generated />
using HeroMatch;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HeroMatch.Migrations
{
    [DbContext(typeof(SiteContext))]
    [Migration("20190802152030_AddedGameIDandCharURLtoCharacters")]
    partial class AddedGameIDandCharURLtoCharacters
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HeroMatch.Models.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CharacterUrl");

                    b.Property<int>("Difficulty");

                    b.Property<int>("GameId");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<int>("Role");

                    b.Property<int>("SubRole");

                    b.HasKey("CharacterId");

                    b.ToTable("Character");

                    b.HasData(
                        new { CharacterId = 1, CharacterUrl = "https://playoverwatch.com/en-us/heroes/reinhardt/", Difficulty = 1, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/reinhardt/hero-select-portrait.png", Name = "Reinhardt", Role = 1, SubRole = 1 },
                        new { CharacterId = 2, CharacterUrl = "https://playoverwatch.com/en-us/heroes/orisa/", Difficulty = 2, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/orisa/hero-select-portrait.png", Name = "Orisa", Role = 1, SubRole = 1 },
                        new { CharacterId = 3, CharacterUrl = "https://playoverwatch.com/en-us/heroes/dva/", Difficulty = 3, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/dva/hero-select-portrait.png", Name = "D. Va", Role = 1, SubRole = 1 },
                        new { CharacterId = 4, CharacterUrl = "https://playoverwatch.com/en-us/heroes/Winston/", Difficulty = 2, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/winston/hero-select-portrait.png", Name = "Winston", Role = 1, SubRole = 1 },
                        new { CharacterId = 5, CharacterUrl = "https://playoverwatch.com/en-us/heroes/roadhog/", Difficulty = 1, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/roadhog/hero-select-portrait.png", Name = "Roadhog", Role = 1, SubRole = 2 },
                        new { CharacterId = 6, CharacterUrl = "https://playoverwatch.com/en-us/heroes/wrecking-ball/", Difficulty = 2, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/wrecking-ball/hero-select-portrait.png", Name = "Wrecking Ball", Role = 1, SubRole = 2 },
                        new { CharacterId = 7, CharacterUrl = "https://playoverwatch.com/en-us/heroes/sigma/", Difficulty = 3, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/sigma/hero-select-portrait.png", Name = "Sigma", Role = 1, SubRole = 2 },
                        new { CharacterId = 8, CharacterUrl = "https://playoverwatch.com/en-us/heroes/zarya/", Difficulty = 3, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/zarya/hero-select-portrait.png", Name = "Zarya", Role = 1, SubRole = 2 },
                        new { CharacterId = 9, CharacterUrl = "https://playoverwatch.com/en-us/heroes/ashe/", Difficulty = 2, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/ashe/hero-select-portrait.png", Name = "Ashe", Role = 2, SubRole = 1 },
                        new { CharacterId = 10, CharacterUrl = "https://playoverwatch.com/en-us/heroes/mccree/", Difficulty = 2, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/mccree/hero-select-portrait.png", Name = "McCree", Role = 2, SubRole = 1 },
                        new { CharacterId = 11, CharacterUrl = "https://playoverwatch.com/en-us/heroes/hanzo/", Difficulty = 3, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/hanzo/hero-select-portrait.png", Name = "Hanzo", Role = 2, SubRole = 1 },
                        new { CharacterId = 12, CharacterUrl = "https://playoverwatch.com/en-us/heroes/widowmaker/", Difficulty = 3, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/widowmaker/hero-select-portrait.png", Name = "Widowmaker", Role = 2, SubRole = 1 },
                        new { CharacterId = 13, CharacterUrl = "https://playoverwatch.com/en-us/heroes/soldier-76/", Difficulty = 1, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/soldier-76/hero-select-portrait.png", Name = "Soldier: 76", Role = 2, SubRole = 1 },
                        new { CharacterId = 14, CharacterUrl = "https://playoverwatch.com/en-us/heroes/reaper/", Difficulty = 1, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/reaper/hero-select-portrait.png", Name = "Reaper", Role = 2, SubRole = 2 },
                        new { CharacterId = 15, CharacterUrl = "https://playoverwatch.com/en-us/heroes/sombra/", Difficulty = 3, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/sombra/hero-select-portrait.png", Name = "Sombra", Role = 2, SubRole = 2 },
                        new { CharacterId = 16, CharacterUrl = "https://playoverwatch.com/en-us/heroes/genji/", Difficulty = 3, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/genji/hero-select-portrait.png", Name = "Genji", Role = 2, SubRole = 2 },
                        new { CharacterId = 17, CharacterUrl = "https://playoverwatch.com/en-us/heroes/doomfist/", Difficulty = 2, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/doomfist/hero-select-portrait.png", Name = "Doomfist", Role = 2, SubRole = 2 },
                        new { CharacterId = 18, CharacterUrl = "https://playoverwatch.com/en-us/heroes/tracer/", Difficulty = 2, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/tracer/hero-select-portrait.png", Name = "Tracer", Role = 2, SubRole = 2 },
                        new { CharacterId = 19, CharacterUrl = "https://playoverwatch.com/en-us/heroes/torbjorn/", Difficulty = 2, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/torbjorn/hero-select-portrait.png", Name = "Torbjörn", Role = 2, SubRole = 3 },
                        new { CharacterId = 20, CharacterUrl = "https://playoverwatch.com/en-us/heroes/symmetra/", Difficulty = 3, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/symmetra/hero-select-portrait.png", Name = "Symmetra", Role = 2, SubRole = 3 },
                        new { CharacterId = 21, CharacterUrl = "https://playoverwatch.com/en-us/heroes/pharah/", Difficulty = 2, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/pharah/hero-select-portrait.png", Name = "Pharah", Role = 2, SubRole = 3 },
                        new { CharacterId = 22, CharacterUrl = "https://playoverwatch.com/en-us/heroes/mei/", Difficulty = 2, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/mei/hero-select-portrait.png", Name = "Mei", Role = 2, SubRole = 3 },
                        new { CharacterId = 23, CharacterUrl = "https://playoverwatch.com/en-us/heroes/junkrat/", Difficulty = 1, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/junkrat/hero-select-portrait.png", Name = "Junkrat", Role = 2, SubRole = 3 },
                        new { CharacterId = 24, CharacterUrl = "https://playoverwatch.com/en-us/heroes/bastion/", Difficulty = 1, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/bastion/hero-select-portrait.png", Name = "Bastion", Role = 2, SubRole = 3 },
                        new { CharacterId = 25, CharacterUrl = "https://playoverwatch.com/en-us/heroes/baptiste/", Difficulty = 2, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/baptiste/hero-select-portrait.png", Name = "Baptiste", Role = 3, SubRole = 1 },
                        new { CharacterId = 26, CharacterUrl = "https://playoverwatch.com/en-us/heroes/brigitte/", Difficulty = 1, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/brigitte/hero-select-portrait.png", Name = "Brigitte", Role = 3, SubRole = 1 },
                        new { CharacterId = 27, CharacterUrl = "https://playoverwatch.com/en-us/heroes/ana/", Difficulty = 3, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/ana/hero-select-portrait.png", Name = "Ana", Role = 3, SubRole = 1 },
                        new { CharacterId = 28, CharacterUrl = "https://playoverwatch.com/en-us/heroes/lucio/", Difficulty = 2, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/lucio/hero-select-portrait.png", Name = "Lúcio", Role = 3, SubRole = 2 },
                        new { CharacterId = 29, CharacterUrl = "https://playoverwatch.com/en-us/heroes/mercy/", Difficulty = 1, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/mercy/hero-select-portrait.png", Name = "Mercy", Role = 3, SubRole = 2 },
                        new { CharacterId = 30, CharacterUrl = "https://playoverwatch.com/en-us/heroes/moira/", Difficulty = 2, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/moira/hero-select-portrait.png", Name = "Moira", Role = 3, SubRole = 2 },
                        new { CharacterId = 31, CharacterUrl = "https://playoverwatch.com/en-us/heroes/zenyatta/", Difficulty = 3, GameId = 1, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/zenyatta/hero-select-portrait.png", Name = "Zenyatta", Role = 3, SubRole = 2 }
                    );
                });

            modelBuilder.Entity("HeroMatch.Models.Filter", b =>
                {
                    b.Property<int>("FilterId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CharacterId");

                    b.Property<int>("Difficulty");

                    b.Property<int>("Role");

                    b.Property<int>("SubRole");

                    b.HasKey("FilterId");

                    b.ToTable("Filter");
                });
#pragma warning restore 612, 618
        }
    }
}
