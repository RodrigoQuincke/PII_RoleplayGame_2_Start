using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    public class Elves
    {
        public string Name { get; }
        public int AttackValue { get; }
        private int DefenseValue { get; }
        private int InitialHealth { get; }
        public int Health { get; private set; }
        public List<Item> Equipment { get; private set; }
        public SpellsBook SpellsBook { get; private set; }
        public Elves(string name)
        {
            this.Name = name;
            this.AttackValue = 50;
            this.DefenseValue = 20;
            this.InitialHealth = 300;
            this.Health = this.InitialHealth;
            this.Equipment = new List<Item>();
            this.Equipment.Add(new Item("Staff", 30, 0));
            this.SpellsBook = new SpellsBook("Elves Book");
        }

        public void ReceiveAttack(int attackDamage)
        {
            int actualDamage = attackDamage - this.GetTotalDefense();
            if (actualDamage > 0)
            {
                this.Health -= actualDamage;
            }
        }

        public void Cure()
        {
            this.Health = this.InitialHealth;
        }

        public void Attack(Elves target)
        {
            target.ReceiveAttack(this.GetTotalAttack());
        }

        public void AddItem(Item item)
        {
            this.Equipment.Add(item);
        }

        public void RemoveItem(Item item)
        {
            this.Equipment.Remove(item);
        }
        public int GetTotalAttack()
        {
            int total = this.AttackValue;
            foreach (Item item in this.Equipment)
            {
                total += item.AttackValue;
            }
            foreach (Spell spell in this.SpellsBook.Spells)
            {
                total += spell.AttackValue;
            }
            return total;
        }

        public int GetTotalDefense()
        {
            int total = this.DefenseValue;
            foreach (Item item in this.Equipment)
            {
                total += item.DefenseValue;
            }
            foreach (Spell spell in this.SpellsBook.Spells)
            {
                total += spell.DefenseValue;
            }
            return total;
        }
    }
}