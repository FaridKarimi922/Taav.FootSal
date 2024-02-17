
using Library.Services.Teams.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Teams.Contracts
{
    public interface TeamService
    {
        Task Add(AddTeamDto dto);
        Task Get(GetTeamDto dto);
        Task Update(UpdateTeamDto dto);
        Task Delete(DeleteTeamDto dto);
    }
}
