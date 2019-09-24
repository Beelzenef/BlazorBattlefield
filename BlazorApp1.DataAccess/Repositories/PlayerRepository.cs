using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorApp1.DataAccess.Contracts;
using BlazorApp1.DataAccess.Entities;

namespace BlazorApp1.DataAccess.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly DemoContext _context;

        public PlayerRepository(DemoContext context)
        {
            _context = context;
        }

        public async Task AddPlayers(List<Player> players, Game game)
        {
            foreach (var p in players)
            {
                p.Game = game;
            }

            _context.Players.AddRange(players);
            await _context.SaveChangesAsync();
        }
    }
}
