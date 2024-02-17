using Library.Services.Teams.Contracts;
using Library.Services.Teams.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taav.Contracts;

namespace Library.Services.Teams
{
    public class TeamAppSevice : TeamService
    {
        private readonly TeamRepository _repository;
        private readonly UnitOfWork _unitOfWork;

        public TeamAppSevice(TeamRepository repository,UnitOfWork unitOfWork)
        {
            this._repository = repository;
            this._unitOfWork = unitOfWork;
        }



        public async Task Add(AddTeamDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(DeleteTeamDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task Get(GetTeamDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task Update(UpdateTeamDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
