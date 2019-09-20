using BlazorApp1.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Application.Contracts
{
    public interface IFightService
    {
        Task<Warrior> AddWarrior(Warrior warrior);
        Task<List<Warrior>> GetAllWarriors();
    }
}
