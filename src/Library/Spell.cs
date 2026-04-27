using System;

namespace Ucu.Poo.RolePlayGame
{
    public class Spell
    {
        public string Name { get; }
        public int AttackValue { get; }
        public int DefenseValue { get; }
    

    public Spell(string name, int attackValue, int defenseValue)
        {
            this.Name = name;
            this.AttackValue = attackValue;
            this.DefenseValue = defenseValue;

        }
    }
}