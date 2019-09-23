using BlazorApp1.DataAccess.Contracts;
using BlazorApp1.DataAccess.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.DataAccess.Repositories
{
    public class WarriorRepository : IWarriorRepository
    {
        public readonly DemoContext _context;
        public WarriorRepository(DemoContext context)
        {
            _context = context;
        }

        public async Task<Warrior> Add(Warrior warrior)
        {
            _context.Warrior.Add(warrior);
            await _context.SaveChangesAsync();

            return warrior;
        }

        public async Task<List<Warrior>> GetAll()
        {
            return _context.Warrior.ToList();
        }

    }
}
