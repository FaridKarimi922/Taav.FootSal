using Library.Services.Players.Contract;
using Library.Services.Players.Contract.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Library.RestApi.Controllers
{
    [Route("api/Players")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly PlayerService _service;

        public PlayerController(PlayerService service)
        {
            this._service = service;
        }
        [HttpPost("Add Player")]
        public async Task Add(AddPlayerDto dto)
        {
           await _service.Add(dto);
        }
        [HttpGet("Get Player")]

        public List<GetPlayerDto> Get(GetPlayerDto dto)
        {
            return _service.GetAll();
        }
        public async Task Update(UpdatePlayerDto dto, [FromRoute] int id)
        {
          await  _service.Update(id, dto);
        }
        public void Delete([FromRoute] int id)
        {
            _service.Delete(id);
        }

    }
}
