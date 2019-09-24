using BlazorApp1.Application.Contracts;
using BlazorApp1.DataAccess.Contracts;
using BlazorApp1.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp1.Application
{
    public class FightService : IFightService
    {
        private readonly IWarriorRepository _warriorRepository;
        private readonly IPlayerRepository _playerRepository;
        private readonly IGameRepository _gameRepository;

        public FightService(IWarriorRepository warriorRepository, IGameRepository gameRepository, IPlayerRepository playerRepository)
        {
            _gameRepository = gameRepository;
            _playerRepository = playerRepository;
            _warriorRepository = warriorRepository;
        }

        public async Task<Game> CreateGame(Game game)
        {
            await _gameRepository.CreateGame(game);

            var createdGame = _gameRepository.GetLastGame();
            return createdGame;
        }

        public async Task AddPlayer(Player player, Game game)
        {
            await _playerRepository.AddPlayers(player, game);
        }

        public async Task SelectWarrior(int playerId, int warriorId)
        {
            await _playerRepository.SelectWarrior(playerId, warriorId);
        }

        public async Task<Warrior> AddWarrior(Warrior warrior)
        {
            return await _warriorRepository.Add(warrior);
        }

        public async Task<List<Warrior>> GetAllWarriors()
        {
            return await _warriorRepository.GetAll();
        }
    }
}
