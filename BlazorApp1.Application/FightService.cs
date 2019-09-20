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

        public FightService(IWarriorRepository warriorRepository)
        {
            _warriorRepository = warriorRepository;
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
