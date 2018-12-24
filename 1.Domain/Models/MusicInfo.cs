using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class MusicInfo : EntityBase<MusicInfo, int>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
