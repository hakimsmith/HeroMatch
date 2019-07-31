using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroMatch.Models
{
    public class Filter
    {
        public int FilterId { get; set; }
        public int Difficulty { get; set; }
        public int Role { get; set; }
        public int SubRole { get; set; }

        public virtual int CharacterId { get; set; }
    }
}
