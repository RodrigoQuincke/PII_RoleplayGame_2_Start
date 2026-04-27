using System;

namespace Ucu.Poo.RolePlayGame
{
    public class Axe : IOffensiveItem
    {
        public string Name { get; }
        public int AttackValue { get; }
    

    public Axe(string name, int attackValue)
        {
            this.Name = name;
            this.AttackValue = attackValue;
        }
    }
}