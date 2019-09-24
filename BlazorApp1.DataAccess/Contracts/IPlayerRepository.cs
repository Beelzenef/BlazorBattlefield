using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorApp1.DataAccess.Entities;

namespace BlazorApp1.DataAccess.Contracts
{
    public interface IPlayerRepository
    {
        public Task AddPlayers(List<Player> players, Game game);
    }
}
