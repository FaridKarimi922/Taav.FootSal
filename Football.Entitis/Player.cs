using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librari.Entitis
{
    public class player
    {
        public player()
        {
        }

        public player(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public int Id { get; set; }
        public string Name  { get; set; }
        public DateTime BirthDate { get; set; }
        public Team Team { get; set; }
        public int TeamId { get; set; }


    }
}
