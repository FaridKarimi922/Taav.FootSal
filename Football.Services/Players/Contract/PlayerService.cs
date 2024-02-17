using Library.Services.Players.Contract.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Players.Contract
{
    public interface PlayerService
    {
        Task Add(AddPlayerDto dto);
        List<GetPlayerDto> GetAll(GetPlayerFilterDto filterDto);
        Task Get(int  id);
        Task Update(UpdatePlayerDto dto);
        Task Delete(DeletePlayerDto dto);
        List<GetPlayerDto> GetAll();
    }
}
