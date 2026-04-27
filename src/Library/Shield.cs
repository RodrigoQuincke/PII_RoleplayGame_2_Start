using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    public class Shield : IDefensiveItem
    {
        public string Name { get; }
        public int DefenseValue { get; }

        public Shield(string name, int defenseValue)
        {
            this.Name = name;
            this.DefenseValue = defenseValue;
        }
    }
}