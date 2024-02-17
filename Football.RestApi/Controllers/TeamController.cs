using Library.Services.Players.Contract.Dtos;
using Library.Services.Players.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Library.Services.Teams.Contracts.Dtos;
using Library.Services.Teams.Contracts;

namespace Library.RestApi.Controllers
{
    [Route("api/Teams")]
    [ApiController]
    public class TeamController : ControllerBase
    {

        private readonly TeamService _service;

        public TeamController(TeamService service)
        {
            this._service = service;
        }
        [HttpPost("Add Team")]
        public async Task Add(AddTeamDto dto)
        {
            await _service.Add(dto);
        }
        public List<GetTeamDto> Get(GetTeamDto dto)
        {
            return _service.GetAll();
        }
        public async Task Update(UpdateTeamDto dto, [FromRoute] int id)
        {
            await _service.Update(id, dto);
        }
        public void Delete([FromRoute] int id)
        {
            _service.Delete(id);
        }
    }
}
