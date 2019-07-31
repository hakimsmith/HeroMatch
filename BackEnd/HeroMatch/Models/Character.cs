using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroMatch.Models
{
    public class Character
    {   
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public virtual int FilterId {get; set;}
    }
}
