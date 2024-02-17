using Librari.Entitis;
using Library.Services.Players.Contract.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Players.Contract
{
    public interface PlayerRepository
    {
        void Add(player player);
        void GetAll(player player);
        void Get(int Id );
        void Update(player player);
        void Delete(player player);
        void GetName(string name);
        List<GetPlayerDto> GetAll(GetPlayerFilterDto filterDto);
       
        
    }
}
