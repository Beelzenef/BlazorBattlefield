using BlazorApp1.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Application.Contracts
{
    public interface IFightService
    {
        Task<Game> CreateGame(Game game);
        Task AddPlayer(Player player, Game game);
        Task SelectWarrior(int playerId, int warriorId);

        Task<Warrior> AddWarrior(Warrior warrior);
        Task<List<Warrior>> GetAllWarriors();
    }
}
