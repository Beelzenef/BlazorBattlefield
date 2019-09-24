using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorApp1.DataAccess.Contracts;
using BlazorApp1.DataAccess.Entities;
using System.Linq;

namespace BlazorApp1.DataAccess.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly DemoContext _context;

        public PlayerRepository(DemoContext context)
        {
            _context = context;
        }

        public async Task AddPlayers(Player player, Game game)
        {
            player.Game = game;

            _context.Players.AddRange(player);
            await _context.SaveChangesAsync();
        }

        public async Task SelectWarrior(int playerId, int warriorId)
        {
            var player = _context.Players.FirstOrDefault(p => p.Id == playerId);

            player.WarriorId = warriorId;
            _context.Players.Update(player);
            await _context.SaveChangesAsync();
        }
    }
}
