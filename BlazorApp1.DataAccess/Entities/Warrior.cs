using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1.DataAccess.Entities
{
    public class Warrior
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int Magic { get; set; }

        //public int PlayerId { get; set; }
        public List<Player> Players { get; set; }
    }
}
