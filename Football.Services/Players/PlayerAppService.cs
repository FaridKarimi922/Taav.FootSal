using Librari.Entitis;
using Library.Services.Players.Contract;
using Library.Services.Players.Contract.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Taav.Contracts;

namespace Library.Services.Players
{
    internal class PlayerAppService : PlayerService
    {

        private readonly PlayerRepository _repository;
        private readonly UnitOfWork _unitOfWork;

        public PlayerAppService(PlayerRepository repository, UnitOfWork unitOfWork)
        {
            this._repository = repository;
            this._unitOfWork = unitOfWork;
        }

        public async Task Add(AddPlayerDto dto)
        {
            var player = new player(dto.Name, dto.BirthDate);
            var player1 = _repository.GetName(dto.Name);
            if (player.Name == player1.Name)
            {
                throw new Exception();
            }
            else
            {
                var player2 = new player()
                {
                    Name = dto.Name,
                    BirthDate = dto.BirthDate
                };
                _repository.Add(player);
                await _unitOfWork.Complete();
            }
            
        }


        public List<GetPlayerDto> Get(GetPlayerFilterDto filterDto)
        {

            return _repository.GetAll(filterDto);

        }



        public List<GetPlayerDto> GetAll()
        {
            var players = _repository.GetAll();
            var playersDTO = new List<GetPlayerDto>();
            if (players == null)
            {
                throw new Exception();
            }
            foreach (var player in players)
            {
                var playerDTO = new GetPlayerDto()
                {
                    Name = player.Name,
                    Id = player.Id,


                };
                playersDTO.Add(playerDTO);
            }
            return playersDTO;
        }

        public void Update(int id, UpdatePlayerDto dto)
        {
           
            _repository.Update(player);
            _unitOfWork.Complete();
        }















        public List<GetPlayerDto> GetAll(GetPlayerFilterDto filterDto)
        {
            throw new NotImplementedException();
        }

        public async Task Update(UpdatePlayerDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
