using Librari.Entitis;
using Library.Services.Players.Contract;
using Library.Services.Players.Contract.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistence.Ef.Players
{
    internal class EfPlayerRepository :PlayerRepository
    {
        private readonly EfDataContext _context;

        public EfPlayerRepository(EfDataContext context)
        {
            this._context = context;
           
        }


        public void Add(player player)
        {
            _context.Add(player);
        }
        public List<GetPlayerDto> GetAll()
        {
            _context.players.ToList();
                
        }
        public void Delete(player player)
        {
            _context.players.Remove(player);
        }
        public void Update(player olayer)
        {
            _Context.Players.Update(player);
        }









      
    }
}
