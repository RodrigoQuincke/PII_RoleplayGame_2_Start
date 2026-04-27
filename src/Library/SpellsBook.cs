using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    public class SpellsBook
    {
        public string Name { get; }
        public int AttackValue { get; set; }
        public int DefenseValue { get; set; }
        public List<Spell> Spells { get; private set; }
    

        public SpellsBook(string name)
        {
            this.Name = name;
            this.Spells = new List<Spell>();

        }

        public void AddSpell(Spell spell)
        {
            this.Spells.Add(spell);
        }

        public void RemoveSpell(Spell spell)
        {
            this.Spells.Remove(spell);
        }

        public int GetTotalAttack()
        {
            int total = 0;
            foreach (Spell spell in this.Spells)
            {
                total += spell.AttackValue;
            }
            return this.AttackValue = total;
        }
        
        public int GetTotalDefense()
        {
            int total = 0;
            foreach (Spell spell in this.Spells)
            {
                total += spell.DefenseValue;
            }
            return this.DefenseValue = total;
        }
    }
}