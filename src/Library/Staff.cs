using System;

namespace Ucu.Poo.RolePlayGame
{
    public class Staff : IOffensiveItem
    {
        public string Name { get; }
        public int AttackValue { get; }
    

    public Staff(string name, int attackValue)
        {
            this.Name = name;
            this.AttackValue = attackValue;
        }
    }
}