using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librari.Entitis
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ColorClothes Origine { get; set; }
        public ColorClothes Sub { get; set; }
        public HashSet<player> Players { get; set; }

    }
}
