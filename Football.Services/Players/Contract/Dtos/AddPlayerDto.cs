using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Players.Contract.Dtos
{
    public class AddPlayerDto
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
