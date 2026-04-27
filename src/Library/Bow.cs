using System;

namespace Ucu.Poo.RolePlayGame
{
    public class Bow : IOffensiveItem
    {
        public string Name { get; }
        public int AttackValue { get; }
    

    public Bow(string name, int attackValue)
        {
            this.Name = name;
            this.AttackValue = attackValue;
        }
    }
}