using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    public class Armor: IDefensiveItem
    {
        public string Name { get; }
        public int DefenseValue { get; }

        public Armor(string name, int defenseValue)
        {
            this.Name = name;
            this.DefenseValue = defenseValue;
        }
    }
}
