using System;

namespace Ucu.Poo.RolePlayGame
{
    public class Sword : IOffensiveItem
    {
        public string Name { get; }
        public int AttackValue { get; }
    

    public Sword(string name, int attackValue)
        {
            this.Name = name;
            this.AttackValue = attackValue;
        }
    }
}