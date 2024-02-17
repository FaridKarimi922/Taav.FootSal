using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Players.Contract.Dtos
{
    public class GetPlayerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int TeamId { get; set; }
    }
    public class GetPlayerFilterDto
    {
        public string Name { get; set; }
    }
}
