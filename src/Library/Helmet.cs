using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    public class Helmet: IDefensiveItem
    {
        public string Name { get; }
        public int DefenseValue { get; }

        public Helmet(string name, int defenseValue)
        {
            this.Name = name;
            this.DefenseValue = defenseValue;
        }
    }
}